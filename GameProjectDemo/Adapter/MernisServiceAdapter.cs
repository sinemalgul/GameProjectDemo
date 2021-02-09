using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(gamer.IdentityNumber, gamer.FirstName, gamer.LastName, gamer.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
