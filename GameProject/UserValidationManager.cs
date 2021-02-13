using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1994 && gamer.FirstName=="Elif" && gamer.LastName=="Pirgaip" && gamer.IdentiyNumber==123 && gamer.Id==1)
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
