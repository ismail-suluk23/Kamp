using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.BirthYear==2003 && gamer.FirstName=="Muhammed"&& gamer.LastName=="Temizkan"
                &&gamer.IdentiyNumber==12345678910)
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
