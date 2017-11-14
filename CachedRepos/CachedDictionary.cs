using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Extensions.Caching.Memory;

namespace CachedRepos
{
    #region Overloads of CachedDictionary

    /// <summary>
    /// Runtime Cache'de kaydedilmek üzere, cached dictionary yazmak için kullanılabilr.
    /// Key'ler üzerinden ilgil entity'leri döner.
    /// </summary>
    /// <typeparam name="TEntity">Repository'nin içerdiği entity tipi</typeparam>
    public abstract class CachedDictionary<TEntity, TKey1, TKey2, TKey3> : CachedDictionary<TEntity, Tuple<TKey1, TKey2, TKey3>>
    //where TEntity : class
    {
        protected CachedDictionary(IMemoryCache cache) : base(cache)
        {
        }
    }

    /// <summary>
    /// Runtime Cache'de kaydedilmek üzere, cached dictionary yazmak için kullanılabilr.
    /// Key'ler üzerinden ilgil entity'leri döner.
    /// </summary>
    /// <typeparam name="TEntity">Repository'nin içerdiği entity tipi</typeparam>
    public abstract class CachedDictionary<TEntity, TKey1, TKey2> : CachedDictionary<TEntity, Tuple<TKey1, TKey2>>
    //where TEntity : class
    {
        protected CachedDictionary(IMemoryCache cache) : base(cache)
        {
        }
    }

    /// <summary>
    /// Runtime Cache'de kaydedilmek üzere, cached dictionary yazmak için kullanılabilr.
    /// Key'ler üzerinden ilgil entity'leri döner.
    /// </summary>
    /// <typeparam name="TEntity">Repository'nin içerdiği entity tipi</typeparam>
    public abstract class CachedDictionary<TEntity> : CachedDictionary<TEntity, int>
    //where TEntity : class
    {
        protected CachedDictionary(IMemoryCache cache) : base(cache)
        {
        }
    }

    #endregion

    /// <summary>
    /// Runtime Cache'de kaydedilmek üzere, cached dictionary yazmak için kullanılabilr.
    /// Key'ler üzerinden ilgil entity'leri döner.
    /// </summary>
    /// <typeparam name="TEntity">Repository'nin içerdiği entity tipi</typeparam>
    /// <typeparam name="TKey">Bu entity'lerin Get edilirken key olarak kullanılcak alanların tipi. string yada int gibi bir tip olabilir.</typeparam>
    /// <typeparam name="TGetResult">GetValue çağırılırken return type'ın ne olacağını belirler. Entity'nin kendisi de dönebilir veya bir property değeri de olabilir.</typeparam>
    public abstract class CachedDictionary<TEntity, TKey> : CachedRepoBase<Dictionary<TKey, TEntity>>
    //where TEntity : class
    //where TGetResult : class
    {
        #region Get Cached Entities (private)

        protected CachedDictionary(IMemoryCache cache) : base(cache)
        {
        }

        private Dictionary<TKey, TEntity> CachedEntities
        {
            get
            {
                lock (LOCK)
                {
                    var cachedEntities = GetFromCache(GetCacheKey());
                    if (cachedEntities != null)
                        return cachedEntities;
                    cachedEntities = CreateCacheDictionary();
                    SetCache(GetCacheKey(), cachedEntities);
                    return cachedEntities;
                }
            }
            set
            {
                lock (LOCK)
                {
                    SetCache(GetCacheKey(), value);
                }
            }
        }

        protected virtual Dictionary<TKey, TEntity> CreateCacheDictionary()
        {
            return new Dictionary<TKey, TEntity>();
        }

        #endregion

        public virtual void Remove(TKey key)
        {
            lock (LOCK)
            {
                var cachedEntities = GetCachedEntities();
                if (cachedEntities == null)
                    return;
                if (cachedEntities.ContainsKey(key))
                    cachedEntities.Remove(key);
            }
        }

        [DebuggerStepThrough]
        public virtual TEntity Get(bool hideExceptions, TKey keyForFinding)
        {
            lock (LOCK)
            {
                if (CachedEntities == null)
                    throw new Exception($"{GetType()} CachedEntities is null!");

                TEntity result;
                if (CachedEntities.TryGetValue(keyForFinding, out result))
                    return result;

                var sw = new Stopwatch();
                sw.Start();
                Debug.WriteLine($"[{GetType().Name}] Requesting data to be cached");
                result = GetDataToBeCached(keyForFinding);
                sw.Stop();
                Debug.WriteLine($"[{GetType().Name}] Completed took {sw.Elapsed}");

                if (result == null)
                {
                    if (hideExceptions)
                        return default(TEntity);
                    throw new ArgumentNullException("keyForFinding", $"{keyForFinding} key'ine karşılık source'dan null değeri döndü.");
                }
                CachedEntities.Add(keyForFinding, result);
                return result;
            }
        }

        public virtual void Set(TKey key, TEntity value)
        {
            lock (LOCK)
            {
                if (CachedEntities == null)
                    return;
                if (!CachedEntities.ContainsKey(key))
                    return;
                CachedEntities[key] = value;
            }
        }

        public void SetCachedEntities(Dictionary<TKey, TEntity> value)
        {
            lock (LOCK)
            {
                CachedEntities = value;
            }
        }

        protected virtual Dictionary<TKey, TEntity> GetCachedEntities()
        {
            return CachedEntities;
        }

        public void ReleaseCache()
        {
            lock (LOCK)
            {
                CachedEntities = null;
            }
        }

        protected abstract TEntity GetDataToBeCached(TKey key);
    }
}
