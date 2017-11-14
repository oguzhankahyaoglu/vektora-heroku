using System.Collections.Generic;
using BayiService;
using CachedRepos;
using Microsoft.Extensions.Caching.Memory;

namespace BayiServiceTest2.Application.Repos
{
    public class BannerRepo : CachedRepo<VestelBanner>
    {
        public BannerRepo(IMemoryCache cache) : base(cache)
        {
        }

        protected override IEnumerable<VestelBanner> GetDataToBeCached()
        {
            var banners = ServiceCaller.CallVenüsBayi(ws => ws.GetBannersAsync(ServiceCaller.AuthToken));
            return banners;
        }
    }
}
