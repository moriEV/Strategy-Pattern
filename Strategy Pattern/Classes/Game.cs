using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Classes
{
    internal class Game
    {
        private Player _player;

        public Game(Player player)
        {
            _player = player;
        }

        public void Start()
        {
            Console.WriteLine("Выберите оружие для игрока:");
            Console.WriteLine("1. Меч");
            Console.WriteLine("2. Лук");
            Console.WriteLine("3. Топор");
            Console.Write("Выбор: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    _player.SetWeapon(new Sword());
                    break;
                case "2":
                    _player.SetWeapon(new Bow());
                    break;
                case "3":
                    _player.SetWeapon(new Axe());
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Установлено оружие по умолчанию (Меч).");
                    _player.SetWeapon(new Sword());
                    break;
            }
            _player.UseWeapon();
        }
    }
}
