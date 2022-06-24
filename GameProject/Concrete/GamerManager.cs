using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {   
        IPersonCheckService _personCheckService;

        public GamerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_personCheckService.GamerIsRealPerson(gamer))
            {
                Console.WriteLine("{0} {1} adlı kişi oyuna kaydedildi",gamer.FirstName,gamer.LastName);
            }
            else
            {
                Console.WriteLine("Bilgilerinizi yanlış girdiniz. Kayıt başarısız.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine($"{0} {1} adlı kişi sisteme güncellendi.", gamer.FirstName, gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine($"{0} {1} adlı kişi sisteme silindi.", gamer.FirstName, gamer.LastName);
        }
    }
}
