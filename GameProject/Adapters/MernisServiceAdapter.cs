using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    class MernisServiceAdapter : IUserValidationService
    {
        public bool validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.IdentityNumber), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
 
 