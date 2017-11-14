using BayiService;
using CachedRepos;
using Microsoft.Extensions.Caching.Memory;

namespace BayiServiceTest2.Application.Repos
{
    public class ProductRepo : CachedDictionary<ProductFor3rdParty[]>
    {
        public ProductRepo(IMemoryCache cache) : base(cache)
        {
        }

        protected override ProductFor3rdParty[] GetDataToBeCached(int key)
        {
            var products = ServiceCaller.CallVenüsBayi(ws => ws.GetProductsOfCategoryAsync(ServiceCaller.AuthToken, key));
            return products;
        }
    }
}
