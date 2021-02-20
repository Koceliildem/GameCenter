using GameCenter.Abstract;
using GameCenter.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter
{
    public class UserValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if ( gamer.Id ==3 && gamer.Name=="Ildem" && gamer.Surname=="Koceli" && gamer.Password == "***0**") 
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
