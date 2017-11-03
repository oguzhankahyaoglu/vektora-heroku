using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Threading.Tasks;

namespace BayiServiceTest2.Application
{
    [DebuggerStepThrough]
    public static class ServiceCaller
    {
        [DebuggerStepThrough]
        public static TResult CallVenüsBayi<TResult>(Func<BayiService.ServiceClient, Task<TResult>> callMethod)
        {
            return DebugExec<BayiService.ServiceClient, BayiService.IService, TResult>(callMethod);
        }

        public static BayiService.AuthInfo AuthToken => new BayiService.AuthInfo { Username = "123", Password = "456" };

        /// <summary>
        /// Default olarak servisden 20 dk cevap bekler sonra timeout alır.
        /// </summary>
        private static TimeSpan DefaultTimeout = new TimeSpan(0, 20, 0);

        [DebuggerStepThrough]
        private static TResult DebugExec<TService, TChannel, TResult>(Func<TService, Task<TResult>> func)
            where TService : ClientBase<TChannel>, new()
            where TChannel : class
        {
            //ws.ChannelFactory.Endpoint.Binding.CloseTimeout
            var ws = new TService();
            if (ws.ChannelFactory?.Endpoint?.Binding == null)
                return Task.Run(() => func(ws)).Result;

            //maxReceivedMessageSize="20000000" maxBufferSize="20000000" maxBufferPoolSize="20000000"
            var binding = ws.ChannelFactory.Endpoint.Binding;
            var basicHttpBinding = binding as BasicHttpBinding;
            if (basicHttpBinding != null)
            {
                var limit = 2 * 10000 * 1000;
                basicHttpBinding.MaxBufferPoolSize = limit;
                basicHttpBinding.MaxBufferSize = limit;
                basicHttpBinding.MaxReceivedMessageSize = limit;
                basicHttpBinding.AllowCookies = true;
            }

            if (binding.SendTimeout < DefaultTimeout)
                binding.SendTimeout = DefaultTimeout;

            if (binding.CloseTimeout < DefaultTimeout)
                binding.CloseTimeout = DefaultTimeout;

            if (binding.OpenTimeout < DefaultTimeout)
                binding.OpenTimeout = DefaultTimeout;

            if (binding.ReceiveTimeout < DefaultTimeout)
                binding.ReceiveTimeout = DefaultTimeout;
            return Task.Run(() => func(ws)).Result;
        }

    }
}
