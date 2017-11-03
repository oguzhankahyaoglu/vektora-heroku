using System.Collections.Generic;
using BayiService;
using CachedRepos;

namespace BayiServiceTest2.Application.Repos
{
    public class BannerRepo : CachedRepo<VestelBanner>
    {
        protected override IEnumerable<VestelBanner> GetDataToBeCached()
        {
            var banners = ServiceCaller.CallVenüsBayi(ws => ws.GetBannersAsync(ServiceCaller.AuthToken));
            return banners;
        }
    }
}
