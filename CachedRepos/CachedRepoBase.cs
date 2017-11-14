using System;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace CachedRepos
{
    public class CachedRepoBase
    {
        public static Func<DateTime> DefaultExpireDate = () => DateTime.Now.AddMonths(1);

        /// <summary>
        /// aynı günün 23:59:00 da expire olması
        /// </summary>
        public static Func<DateTime> DefaultExpireDate1Day = () => DateTime.Now.AddDays(1).Subtract(DateTime.Now.TimeOfDay).AddMinutes(-1);

        public static Func<DateTime> DefaultExpireDate5Min = () => DateTime.Now.AddMinutes(5);

        public static Func<DateTime> DefaultExpireDate1Hour = () => DateTime.Now.AddHours(1);


        protected static readonly object LOCK = new object();

        /// <summary>
        /// Cache'lenmiş bütün entityleri JSON olarka string serialize eder. Loglama gibi işlevler içni kullanılabilir.
        /// </summary>
        public static void DumpCachedItems(object cachedEntities, Action<string> writeFunc)
        {
            var str = JsonConvert.SerializeObject(cachedEntities);
            writeFunc(str);
        }
    }

    public class CachedRepoBase<T> : CachedRepoBase
        where T : class
    {
        protected IMemoryCache _cache;

        public CachedRepoBase(IMemoryCache cache)
        {
            _cache = cache;
        }

        protected virtual string GetCacheKey()
        {
            return "CachedRepoBase-" + GetType().FullName;
        }

        protected T GetFromCache(String key)
        {
            lock (LOCK)
            {
                object cachedItem;
                if (!_cache.TryGetValue(key, out cachedItem))
                    return null;

                if (cachedItem == null)
                    return null;
                var casted = cachedItem as T;
                if (casted == null)
                    throw new Exception(String.Format("Cache'de '{0}' key'ine karşılık '{1}' objesi bulunuyor, fakat tipi '{2}' değil. Cache'leri kontrol edin.", key, cachedItem, typeof(T)));
                return casted;
            }
        }

        /// <summary>
        /// Runtime Cache'e yazmakla görevlidir. Default davranışı 15 gün cache'de kalacak ve NotRemovable olacak şekilde cache'lemektir.
        /// Davranışını değiştirmek için extend edilmelidir.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        protected void SetCache(String key, T value)
        {
            lock (LOCK)
            {
                if (value == null)
                    _cache.Remove(key);
                else
                    _cache.Set(key, value, CachedRepoBase.DefaultExpireDate());
            }
        }

        protected virtual DateTime GetCacheExpireDate()
        {
            var expiration = DefaultExpireDate();
            return expiration;
        }

    }
}
