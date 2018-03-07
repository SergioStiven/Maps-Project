using System;
using System.ServiceModel;

namespace Acquaint.Native.Droid
{
    public static class Conexion_Web_Service
    {
        public static readonly EndpointAddress EndPoint = new EndpointAddress("http://folkend-001-site3.itempurl.com/Service.svc");
        public static ServiceZeusClient _client;
        private static BasicHttpBinding CreateBasicHttp()
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                Name = "basicHttpBinding",
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647,
            };

            TimeSpan timeout = new TimeSpan(0, 0, 30);
            binding.SendTimeout = timeout;
            binding.OpenTimeout = timeout;
            binding.ReceiveTimeout = timeout;
            return binding;
        }

        public static void InitializeServiceClient()
        {
            BasicHttpBinding binding = CreateBasicHttp();

            _client = new ServiceZeusClient(binding, EndPoint);
        }
    }
}
