using GameSystem.Abstract;
using GameSystem.Concrete;
using GameSystem.Entites;
using System;
using System.Collections.Generic;

namespace GameSystem
{
    class Program
    {
        static List<Player> players = new List<Player>();
        static List<Game> games = new List<Game>();
        static List<Campaign> campaigns = new List<Campaign>();

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            PlayerManager playerManager = new PlayerManager(new PlayerValidationService());
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();
            GameSaleManager gameSaleManager = new GameSaleManager();

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.\n" +
                "1. Oyuncu İşlemleri\n" +
                "2. Oyun İşlemleri\n" +
                "3. Kampanya İşlemleri\n" +
                "4. Alış/Satış İşlemleri\n" +
                "5. Çıkış");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.\n" +
                        "1. Oyuncu Ekle\n" +
                        "2. Oyuncu Sil\n" +
                        "3. Oyuncu Güncelle\n" +
                        "4. Oyuncu Listele\n" +
                        "5. Çıkış");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            players.Add(playerManager.Add(new Player()));
                            break;
                        case "2":
                            players.Remove(playerManager.Delete(players));
                            break;
                        case "3":
                            playerManager.Update(players);
                            break;
                        case "4":
                            playerManager.ListPlayers(players);
                            break;
                        case "5":
                            Console.WriteLine("Çıkış Yapıldı.");
                            break;
                        default:
                            Console.WriteLine("Yanlış bir tuşlama yaptınız.");
                            break;
                    }
                    return true;
                case "2":
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.\n" +
                        "1. Oyun Ekle\n" +
                        "2. Oyun Sil\n" +
                        "3. Oyun Güncelle\n" +
                        "4. Oyun Listele\n" +
                        "5. Çıkış");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            games.Add(gameManager.Add(new Game()));
                            break;
                        case "2":
                            games.Remove(gameManager.Delete(games));
                            break;
                        case "3":
                            gameManager.Update(games);
                            break;
                        case "4":
                            gameManager.ListGames(games);
                            break;
                        case "5":
                            Console.WriteLine("Çıkış Yapıldı.");
                            break;
                        default:
                            Console.WriteLine("Yanlış bir tuşlama yaptınız.");
                            break;
                    }
                    return true;
                case "3":
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.\n" +
                        "1. Kampanya Ekle\n" +
                        "2. Kampanya Sil\n" +
                        "3. Kampanya Güncelle\n" +
                        "4. Kampanya Listele\n" +
                        "5. Çıkış");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            campaigns.Add(campaignManager.Add(new Campaign()));
                            break;
                        case "2":
                            campaigns.Remove(campaignManager.Delete(campaigns));
                            break;
                        case "3":
                            campaignManager.Update(campaigns);
                            break;
                        case "4":
                            campaignManager.ListCampaigns(campaigns);
                            break;
                        case "5":
                            Console.WriteLine("Çıkış Yapıldı.");
                            break;
                        default:
                            Console.WriteLine("Yanlış bir tuşlama yaptınız.");
                            break;
                    }
                    return true;
                case "4":
                    gameSaleManager.Sale(games, players, campaigns);
                    return true;
                case "5":
                    return false;
                default:
                    Console.WriteLine("Yanlış bir tuşlama yaptınız. Lütfen tekrar deneyiniz.");
                    return true;
            }
        }
    }
}
