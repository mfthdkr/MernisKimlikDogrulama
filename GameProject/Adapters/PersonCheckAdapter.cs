using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;

namespace GameProject.Adapters
{
    public class PersonCheckAdapter : IPersonCheckService
    {
        public bool GamerIsRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client =
                new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId),
                gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);
            var result = response.Result.Body.TCKimlikNoDogrulaResult;
            return result;
        }
    }
}
