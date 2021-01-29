using GameSystem.Abstract;
using GameSystem.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem.Concrete
{
    public class GameManager : IGameManager
    {
        public Game Add(Game game)
        {
            Console.Write("Oyun Id: ");
            game.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyun Adı: ");
            game.Name = Console.ReadLine();
            Console.Write("Oyun Çıkış Yılı: ");
            game.ReleaseYear = Convert.ToInt64(Console.ReadLine());
            Console.Write("Oyun Fiyatı: ");
            game.Price = Convert.ToDouble(Console.ReadLine());
            return game;
        }

        public Game Delete(List<Game> games)
        {
            Console.Write("Silmek istediğiniz oyunun id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            return games.Find(x => x.Id == id);
        }

        public void ListGames(List<Game> games)
        {
            foreach (var item in games)
            {
                Console.WriteLine("Id: " + item.Id + "\n" + "Ad: " + item.Name + "\n" + "Çıkış Yılı: " + item.ReleaseYear + "\n" + "Fiyat: " + item.Price);
            }
        }

        public void Update(List<Game> games)
        {
            Console.Write("Güncellemek istediğiniz oyunun id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var game = games.Find(x => x.Id == id);
            Console.Write("Oyun Adı: ");
            game.Name = Console.ReadLine();
            Console.Write("Oyun Çıkış Tarihi: ");
            game.ReleaseYear = Convert.ToInt64(Console.ReadLine());
            Console.Write("Oyun Fiyatı: ");
            game.Price = Convert.ToInt32(Console.ReadLine());
        }
    }
}
