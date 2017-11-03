using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CachedRepos
{
    //#region Overloads of CachedRepo

    ///// <summary>
    ///// Runtime Cache'de kaydedilmek üzere, cached repo yazmak için kullanılabilr.
    ///// Key'ler üzerinden ilgil entity'leri döner.
    ///// </summary>
    ///// <typeparam name="TEntity">Repository'nin içerdiği entity tipi</typeparam>
    ////public abstract class CachedRepo<TEntity> : CachedRepo<TEntity, int> where TEntity : class
    ////public abstract class CachedRepo<TEntity> : CachedRepo<TEntity, int> where TEntity : class
    ////{
    ////}

    ///// <summary>
    ///// Runtime Cache'de kaydedilmek üzere, cached repo yazmak için kullanılabilr.
    ///// Key'ler üzerinden ilgil entity'leri döner.
    ///// </summary>
    ///// <typeparam name="TEntity">Repository'nin içerdiği entity tipi</typeparam>
    ///// <typeparam name="TKey">Bu entity'lerin Get edilirken key olarak kullanılcak alanların tipi. string yada int gibi bir tip olabilir.</typeparam>
    ////public abstract class CachedRepo<TEntity, TKey> : CachedRepo<TEntity, TKey, TEntity> where TEntity : class
    ////public abstract class CachedRepo<TEntity, TKey> : CachedRepo<TEntity> where TEntity : class
    ////{
    ////    //protected override TEntity ExtractValueFieldFromEntity(TEntity entity)
    ////    //{
    ////    //    return entity;
    ////    //}
    ////}

    //#endregion

    /// <summary>
    /// Runtime Cache'de kaydedilmek üzere, cached repo yazmak için kullanılabilr.
    /// Key'ler üzerinden ilgil entity'leri döner.
    /// </summary>
    /// <typeparam name="T">Repository'nin içerdiği entity tipi</typeparam>
    /// <typeparam name="TKey">Bu entity'lerin Get edilirken key olarak kullanılcak alanların tipi. string yada int gibi bir tip olabilir.</typeparam>
    /// <typeparam name="TGetResult">GetValue çağırılırken return type'ın ne olacağını belirler. Entity'nin kendisi de dönebilir veya bir property değeri de olabilir.</typeparam>
    //public abstract class CachedRepo<T, TKey, TGetResult> : CachedRepoBase<List<T>>
    public abstract class CachedRepo<T> : CachedRepoBase<List<T>>
        where T : class
        //where TGetResult : class
    {
        #region Get Cached Entities (private)

        private List<T> CachedEntities
        {
            get
            {
                return GetFromCache(GetCacheKey());
            }
            set
            {
                SetCache(GetCacheKey(), value);
            }
        }

        #endregion

        [DebuggerStepThrough]
        public virtual List<T> GetCachedEntities()
        {
            lock (LOCK)
            {
                if (CachedEntities == null)
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    Debug.WriteLine($"[{GetType().Name}] Requesting data to be cached");
                    CachedEntities = GetDataToBeCached().ToList();
                    sw.Stop();
                    Debug.WriteLine($"[{GetType().Name}] Completed took {sw.Elapsed}");
                }
                return CachedEntities;
            }
        }


        //protected virtual bool IsEntityMatchForKeys(T entity, TKey keysForFinding)
        //{
        //    throw new NotImplementedException(GetType() + " cachedRepo'nun IsEntityMatchForKeys metodu override edilemediği için, bu metod çağırılamaz.");
        //}

        //[DebuggerStepThrough]
        //public virtual T Get(bool hideExceptions, TKey keyForFinding)
        //{
        //    lock (LOCK)
        //    {
        //        var cachedEntities = GetCachedEntities();
        //        if (cachedEntities == null)
        //            throw new Exception(String.Format("{0} CachedEntities is null!", GetType()));

        //        var filtered = cachedEntities.Where(e => IsEntityMatchForKeys(e, keyForFinding)).ToArray();
        //        if (hideExceptions)
        //            return filtered.FirstOrDefault();

        //        var count = filtered.Length;
        //        if (count == 0)
        //            throw new Exception(String.Format("'{0}' key'leri için entity cachedDataSource'da bulunamadı", keyForFinding));
        //        if (count == 2)
        //            throw new Exception(String.Format("'{0}' key'leri için birden fazla entity cachedDataSource'da bulundu.", keyForFinding));
        //        return filtered.FirstOrDefault();
        //    }
        //}

        //public virtual void Remove(TKey key)
        //{
        //    lock (LOCK)
        //    {
        //        var cachedEntities = GetCachedEntities();
        //        if (cachedEntities == null)
        //            return;
        //        cachedEntities.RemoveAll(e => IsEntityMatchForKeys(e, key));
        //    }
        //}

        //protected abstract TGetResult ExtractValueFieldFromEntity(T entity);
        //public virtual TGetResult GetValue(bool hideExceptions, TKey keysForFinding)
        //{
        //    var entity = Get(hideExceptions, keysForFinding);
        //    return entity != null ? ExtractValueFieldFromEntity(entity) : null;
        //}

        public virtual void SetCachedEntities(List<T> value)
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

        protected abstract IEnumerable<T> GetDataToBeCached();
    }
}
