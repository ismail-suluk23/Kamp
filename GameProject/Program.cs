using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1,
                BirthYear = 2003,
                FirstName = "Muhemmed",
                LastName = "Temizkan",
                IdentiyNumber = 12345678910 
                });


            Console.WriteLine();
        }
    }
}
