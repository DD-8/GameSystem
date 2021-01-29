using GameSystem.Abstract;
using GameSystem.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem.Concrete
{
    public class GameSaleManager : IGameSaleManager
    {
        public void Sale(List<Game> games, List<Player> players, List<Campaign> campaigns)
        {
            Console.WriteLine("Satın alacak oyuncunun id'si: ");
            int playerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Satın alınacak oyunun id'si: ");
            int gameId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kampanya id'sini giriniz: ");
            int campaignId = Convert.ToInt32(Console.ReadLine());

            Player player = new Player();
            Game game = new Game();
            Campaign campaign = new Campaign();
            foreach (var item in players)
            {
                player = players.Find(x => x.Id == playerId);
            }

            foreach (var item in games)
            {
                game = games.Find(x => x.Id == gameId);
            }

            foreach (var item in campaigns)
            {
                campaign = campaigns.Find(x => x.Id == campaignId);
            }

            Console.WriteLine(game.Name + " oyunu " + player.FirstName + " " + player.LastName + " için %" + campaign.DiscountAmount + " indirimle " + "satıldı.");
        }
    }
}
