using System.Collections.Generic;
using BayiService;
using CachedRepos;

namespace BayiServiceTest2.Application.Repos
{
    public class CategoryRepo : CachedRepo<CategoryFor3rdParty>
    {
        protected override IEnumerable<CategoryFor3rdParty> GetDataToBeCached()
        {
            var categories = ServiceCaller.CallVenüsBayi(ws => ws.GetCategoriesAsync(ServiceCaller.AuthToken));
            return categories;
        }
    }
}
