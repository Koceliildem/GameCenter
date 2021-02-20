using GameCenter.Abstract;
using GameCenter.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter
{
    public class GamerManager : IGamerService
    {
        IValidationService  _userValidationService;

        public GamerManager()
        {
        }

        public  GamerManager(IValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt başarılı.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız .Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }


}
