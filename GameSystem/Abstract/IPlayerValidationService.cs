using GameSystem.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem.Abstract
{
    public interface IPlayerValidationService
    {
        bool Validate(Player player);
    }
}
