using GameSystem.Abstract;
using GameSystem.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public Campaign Add(Campaign campaign)
        {
            Console.Write("Kampanya Id: ");
            campaign.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kampanya Adı: ");
            campaign.Name = Console.ReadLine();
            Console.Write("İndirim Tutarı: ");
            campaign.DiscountAmount = Convert.ToInt32(Console.ReadLine());
            return campaign;
        }

        public Campaign Delete(List<Campaign> campaigns)
        {
            Console.Write("Silmek istediğiniz kampanyanın id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            return campaigns.Find(x => x.Id == id);
        }

        public void ListCampaigns(List<Campaign> campaigns)
        {
            foreach (var item in campaigns)
            {
                Console.WriteLine("Id: " + item.Id + "\n" + "Ad: " + item.Name + "\n" + "Kampanyadaki İndirim Tutarı: " +item.DiscountAmount);
            }
        }

        public void Update(List<Campaign> campaigns)
        {
            Console.Write("Güncellemek istediğiniz kampanyanın id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var campaign = campaigns.Find(x => x.Id == id);
            Console.Write("Kampanya Adı: ");
            campaign.Name = Console.ReadLine();
            Console.Write("Kampanya İndirim Tutarı: ");
            campaign.DiscountAmount = Convert.ToInt32(Console.ReadLine());
        }
    }
}
