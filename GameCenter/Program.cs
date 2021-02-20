using GameCenter.Concrete;
using GameCenter.Entitites;
using System;

namespace GameCenter
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                Name = "İLDEM",
                Surname = "KOÇELİ",
                Password = "********"

            });
            Console.WriteLine( );

            GameManager gameManager = new GameManager(new GameManager());
            gameManager.
        }
    }
}
