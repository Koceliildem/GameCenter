using GameCenter.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Entitites
{
    public class Games:IGameSaleService

    {
        public int Id { get; set; }
        public string  GameName { get; set; }
        public int GamePrice { get; set; }

        public void GetGameSale(Games games)
        {
            
        }
    }
}
