using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class PersonFakeCheckManager : IPersonCheckService
    {
        public bool GamerIsRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
