using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool validate(Gamer gamer)
        {
            if (gamer.BirthYear==2000 && gamer.FirstName=="Mike" &&
                gamer.LastName=="Haristold" && gamer.IdentityNumber==12345678901)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
