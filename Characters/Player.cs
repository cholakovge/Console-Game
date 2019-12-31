﻿namespace Game.Characters
{
    using System;
    using Game.Methods;
    public class Player : Character
    {
        public Player(string name) : base(name, 0, 30)
        {
            this.Experience = 0;
            this.Level = 1;
            this.DamageAbsorb = 0;
            this.Gold = 0;
            this.Silver = 0;
        }

        public int Experience { get; set; }
        public int Level { get; set; }
        public int DamageAbsorb { get; set; }
        public int Silver { get; set; }
        public double Gold { get; set; }

        public void EarnExperience(Player pl)
        {
            int exp = 0;

            if (pl.Level < 3)
            {
                exp = 60;
                pl.Damage = UtilityMethods.Random(5, 12);
                pl.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }
            else if (pl.Level >= 3 && pl.Level < 6)
            {
                exp = 30;
                pl.Damage = UtilityMethods.Random(6, 14);
                pl.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            else if (pl.Level >= 6)
            {
                exp = 15;
                pl.Damage = UtilityMethods.Random(8, 15);
                pl.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            if (pl.Experience >= 100)
            {
                pl.Level++;
                pl.Experience = pl.Experience - 100;
                if (pl.Level < 8)
                {
                    Console.WriteLine($"{pl.Name} has reached level {pl.Level}");
                }
            }
        }

        public void LoseExperiance(Player pl, int exp)
        {
            if (pl.Experience > 0 && pl.Experience <= 10)
            {
                Console.WriteLine($"You lost {exp - pl.Experience} experience");
                pl.Experience = 0;
            }

            else if (pl.Experience > 10)
            {
                Console.WriteLine($"You lost {exp}% experience!");
                pl.Experience -= exp;
            }
        }
    }
}
