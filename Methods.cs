﻿namespace Game
{
    using System;
    public class Methods
    {
        public static void FightResults(Player pl, Monster monster)
        {
            if (pl.Health <= monster.Health)
            {
                Console.WriteLine($"{monster.Name} has slain {pl.Name} and left with {monster.Health} health!");
            }
            else if (monster.Health <= pl.Health)
            {
                Console.WriteLine($"{pl.Name} has slain {monster.Name} and left with {pl.Health} health!");
            }
            //Console.WriteLine($"{pl.Name} hit {monster.Name} and dealing {pl.Damage}!");
            //Console.WriteLine($"{monster.Name} hit {pl.Name} and dealing {monster.Damage}!");
        }

        public static void FightMonsterValues(Player pl, Monster monster)
        {
            pl.Damage = pl.Random(5, 12);
            monster.Damage = monster.Random(5, 12);

            pl.DamageAbsorb = pl.Random(1, 4);

            pl.Health -= monster.Damage - pl.DamageAbsorb;

            monster.Health -= pl.Damage;
        }

        public static void Experiance(Player pl)
        {
            int exp = 0;

            if (pl.Level < 3)
            {
                exp = 60;
                pl.Damage = Random(5, 12);
                pl.Experiance += exp;
                Console.WriteLine($"{exp}% experiance earned!");
            }
            else if (pl.Level >= 3 && pl.Level < 6)
            {
                exp = 30;
                pl.Damage = Random(6, 14);
                pl.Experiance += exp;
                Console.WriteLine($"{exp}% experiance earned!");
            }

            else if (pl.Level >= 6)
            {
                exp = 15;
                pl.Damage = Random(8, 15);
                pl.Experiance += exp;
                Console.WriteLine($"{exp}% experiance earned!");
            }

            if (pl.Experiance >= 100)
            {
                pl.Level++;
                pl.Experiance = pl.Experiance - 100;
                if (pl.Level < 5)
                {
                    Console.WriteLine($"{pl.Name} has reached level {pl.Level}");
                }
            }
        }

        public static int Random(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }

        public static void LoseExperiance(Player pl, int exp)
        {
            Console.WriteLine($"You lost {exp}% experiance!");
            if (pl.Experiance >= 0)
            {
                pl.Experiance -= exp;
            }
        }
    }
}
