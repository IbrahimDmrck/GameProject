using System;

namespace GameProject.Adapters
{
    internal class KPSPublicSoapClient
    {
        private object kPSPublicSoap;

        public KPSPublicSoapClient(object kPSPublicSoap)
        {
            this.kPSPublicSoap = kPSPublicSoap;
        }

        public static object EndpointConfiguration { get; internal set; }

        internal object TCKimlikNoDogrulaAsync(TCKimlikNoDogrulaRequest tCKimlikNoDogrulaRequest)
        {
            throw new NotImplementedException();
        }
    }
}