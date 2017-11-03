using BayiService;
using CachedRepos;

namespace BayiServiceTest2.Application.Repos
{
    public class ProductRepo : CachedDictionary<ProductFor3rdParty[]>
    {
        protected override ProductFor3rdParty[] GetDataToBeCached(int key)
        {
            var products = ServiceCaller.CallVenüsBayi(ws => ws.GetProductsOfCategoryAsync(ServiceCaller.AuthToken, key));
            return products;
        }
    }
}
