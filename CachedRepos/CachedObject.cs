using System;
using System.Diagnostics;
using Microsoft.Extensions.Caching.Memory;

namespace CachedRepos
{
    /// <summary>
    /// Runtime Cache'de kaydedilmek üzere, cached repo yazmak için kullanılabilr.
    /// Key'ler üzerinden ilgil entity'leri döner.
    /// CachedRepo'dan farklı olarak, bir koleksiyon değil, direkt olarak bir obje'yi cache'de tutar/yönetir
    /// </summary>
    /// <typeparam name="T">Repository'nin içerdiği entity tipi</typeparam>
    public abstract class CachedObject<T> : CachedRepoBase<T>
        where T : class
    {
        protected CachedObject(IMemoryCache cache) : base(cache)
        {
        }

        #region Get Cached Entities (private)

        private T CachedEntities
        {
            get => GetFromCache(GetCacheKey());
            set => SetCache(GetCacheKey(), value);
        }

        #endregion

        [DebuggerStepThrough]
        public virtual T GetCachedEntities(bool hideExceptions)
        {
            lock (LOCK)
            {
                if (CachedEntities == null)
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    Debug.WriteLine($"[{GetType().Name}] Requesting data to be cached");
                    CachedEntities = GetDataToBeCached();
                    sw.Stop();
                    Debug.WriteLine($"[{GetType().Name}] Completed took {sw.Elapsed}");
                }
                if (CachedEntities == null && !hideExceptions)
                    throw new Exception(String.Format("{0} CachedEntities is null!", GetType()));
                return CachedEntities;
            }
        }

        public virtual void SetCachedEntities(T value)
        {
            lock (LOCK)
            {
                CachedEntities = value;
            }
        }

        public void ReleaseCache()
        {
            lock (LOCK)
            {
                CachedEntities = null;
            }
        }

        protected abstract T GetDataToBeCached();
    }
}
