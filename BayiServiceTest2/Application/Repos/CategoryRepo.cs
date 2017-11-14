using System.Collections.Generic;
using BayiService;
using CachedRepos;
using Microsoft.Extensions.Caching.Memory;

namespace BayiServiceTest2.Application.Repos
{
    public class CategoryRepo : CachedRepo<CategoryFor3rdParty>
    {
        public CategoryRepo(IMemoryCache cache) : base(cache)
        {
        }

        protected override IEnumerable<CategoryFor3rdParty> GetDataToBeCached()
        {
            var categories = ServiceCaller.CallVenüsBayi(ws => ws.GetCategoriesAsync(ServiceCaller.AuthToken));
            return categories;
        }
    }
}
