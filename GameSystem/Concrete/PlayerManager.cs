using GameSystem.Abstract;
using GameSystem.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem.Concrete
{
    public class PlayerManager : IPlayerManager 
    {
        IPlayerValidationService playerValidationService;

        public PlayerManager(IPlayerValidationService playerValidationService)
        {
            this.playerValidationService = playerValidationService;
        }

        public Player Add(Player player)
        {
            Console.Write("Oyuncu Id: ");
            player.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyuncu Adı: ");
            player.FirstName = Console.ReadLine();
            Console.Write("Oyuncu Soyadı: ");
            player.LastName = Console.ReadLine();
            Console.Write("Oyuncu Doğum Yılı: ");
            player.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyuncu TC: ");
            player.TcKimlikNo = Convert.ToInt64(Console.ReadLine());

            if (playerValidationService.Validate(player)==true)
            {
                return player;
            }
            else
            {
                throw new Exception("Doğrulama Sağlanamadı.");
            }
        }

        public Player Delete(List<Player> players)
        {
            Console.Write("Silmek istediğiniz oyuncunun id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            return players.Find(x => x.Id == id);
        }

        public void ListPlayers(List<Player> players)
        {
            foreach (var item in players)
            {
                Console.WriteLine("Id: " + item.Id + "\n" + "Ad Soyad: " + item.FirstName + " " + item.LastName + "\n" + "Doğum Yılı: " + item.YearOfBirth + "\n" + "TC: " + item.TcKimlikNo);
            }
        }

        public void Update(List<Player> players)
        {
            Console.Write("Güncellemek istediğiniz oyuncunun id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var player = players.Find(x => x.Id == id);
            Console.Write("Oyuncu Adı: ");
            player.FirstName = Console.ReadLine();
            Console.Write("Oyuncu Soyadı: ");
            player.LastName = Console.ReadLine();
            Console.Write("Oyuncu Doğum Yılı: ");
            player.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oyuncu TC: ");
            player.TcKimlikNo = Convert.ToInt64(Console.ReadLine());

            if (playerValidationService.Validate(player) == true)
            {
                Console.WriteLine("Doğrulama yapıldı.");
            }
            else
            {
                throw new Exception("Doğrulama Sağlanamadı.");
            }
        }
    }
}
