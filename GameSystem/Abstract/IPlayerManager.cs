using GameSystem.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem.Abstract
{
    public interface IPlayerManager
    {
        Player Add(Player player);
        Player Delete(List<Player> players);
        void Update(List<Player> players);
        void ListPlayers(List<Player> players);
    }
}
