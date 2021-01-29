using GameSystem.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem.Abstract
{
    public interface ICampaignManager
    {
        Campaign Add(Campaign campaign);
        Campaign Delete(List<Campaign> campaigns);
        void Update(List<Campaign> campaigns);
        void ListCampaigns(List<Campaign> campaigns);
    }
}
