using GameSystem.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem.Abstract
{
    public interface IGameManager
    {
        Game Add(Game game);
        Game Delete(List<Game> games);
        void Update(List<Game> games);
        void ListGames(List<Game> games);
        

    }
}
