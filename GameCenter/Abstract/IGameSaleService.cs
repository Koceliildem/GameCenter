using GameCenter.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Abstract
{
    interface IGameSaleService
    {
        public void GetGameSale(Games games);
        public void Delete(Games games);
        public void Update(Games games);

    }
}
