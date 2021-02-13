using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1994, FirstName = "Elif", LastName = "Pirgaip", IdentiyNumber = 123 });

        }
    }
}
