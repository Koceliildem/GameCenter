using GameCenter.Abstract;
using GameCenter.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Concrete
{
    public class GameManager : IGameSaleService
    {
        public void Delete(Games games)
        {
            Console.WriteLine("Oyun silindi.");
        }

        public void GetGameSale(Games games)
        {
            Console.WriteLine("Oyun satın alındı.");
        }

        public void Update(Games games)
        {
            Console.WriteLine("Oyun güncellendi.");
        }
    }
}
