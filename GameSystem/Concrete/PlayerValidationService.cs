using GameSystem.Abstract;
using GameSystem.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using TCKimlikNoDogrulama.Core;

namespace GameSystem.Concrete
{
    class PlayerValidationService : IPlayerValidationService
    {
        public bool Validate(Player player)
        {
            bool cevap = new TCKimlikNoDogrulamaCORE(player.TcKimlikNo, player.FirstName, player.LastName, player.YearOfBirth).KisiVarMi();
            return cevap;
        }
    }
}
