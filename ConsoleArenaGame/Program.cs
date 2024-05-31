﻿using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            GameEngine gameEngine = new GameEngine()
            {
                HeroA = new Knight("Ninja", 10, 20, new Sword("Sword")),
                HeroB = new Assassin("Shooter", 13, 9, new Gun("Gun")),


                /*
                                NotificationsCallBack = ConsoleNotification*/
                NotificationsCallBack = args =>
                {
                    Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack:F2} and caused {args.Damage:F2} damage.");
               
                }
            };


        gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}