using GameSystem.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem.Abstract
{
    public interface IGameSaleManager
    {
        void Sale(List<Game> games, List<Player> players, List<Campaign> campaigns);
    }
}
