using System;
using GameProject.Abstract;
using GameProject.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "" + gamer.LastName + "oyuncu eklendi");
            }
            else
            {
                Console.WriteLine("Verification failed. Registration Failed.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "" + gamer.LastName + "oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "" + gamer.LastName + "oyuncu güncellendi");
            }
            else
            {
                Console.WriteLine("Verification failed.Registration Failed."); 
            }
        }
    }
}
