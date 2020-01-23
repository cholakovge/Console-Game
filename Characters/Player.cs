﻿namespace Game.Characters
{
    using System;
    using System.Linq;
    using System.Text;
    using Game.Items;
    using Game.Items.Gears;
    using Game.Items.Weapons;
    using Game.Methods;
    public class Player : Character
    {
        private const int ExperienceToLose = 10;
        private int level;
        public Player(string name) : base(name, 0, 30)
        {
            this.Experience = 0;
            this.Level = 1;
            this.DamageAbsorb = 0;
            this.Gold = 0;
            this.Silver = 0;
            this.Weapon = null;
            this.Cuirass = null;
            this.Boots = null;
            this.Armguard = null;
        }

        public int Experience { get; private set; }
        public int Level
        {
            get
            {
                return this.level;
            }
            private set
            {
                if (value == 8)
                {
                    throw new ArgumentException($"{this.Name} has reached max level!");
                }

                this.level = value;
            }
        }
        public int DamageAbsorb { get; private set; }
        public int Silver { get; private set; }
        public double Gold { get; private set; }
        public Weapon Weapon { get; set; }
        public Gear Cuirass { get; set; }
        public Gear Boots { get; set; }
        public Gear Armguard { get; set; }

        public void LoseExperiance()
        {
            if (this.Experience <= 10)
            {
                Console.WriteLine($"Your experience is 0%. Try harder!");
                this.Experience = 0;
            }

            else if (this.Experience > 10)
            {
                Console.WriteLine($"You lost {ExperienceToLose}% experience!");
                this.Experience -= ExperienceToLose;
            }
        }

        public void LevelUp()
        {
            if (this.Experience >= 100)
            {
                this.Level++;
                this.Experience = this.Experience - 100;
                if (this.Level < 8)
                {
                    Console.WriteLine($"{this.Name} has reached level {this.Level}");
                }
            }
        }

        public void DropSilver()
        {
            int result = UtilityMethods.Random(55, 85);
            this.Silver += result;

            if (this.Silver >= 100)
            {
                this.Silver -= 100;
                this.Gold++;
            }
        }

        public void EarnExperience()
        {
            int exp = 0;

            if (this.Level < 3)
            {
                exp = 60;
                this.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            else if (this.Level >= 3 && this.Level < 6)
            {
                exp = 30;
                this.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            else if (this.Level >= 6)
            {
                exp = 15;
                this.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            LevelUp();
        }

        public void IncreaseStats(Player player)
        {
            IncreaseDamage(player);
            IncreaseDamageAbsorb();
        }

        private void IncreaseDamageAbsorb()
        {
            if (this.Level <= 2)
            {
                this.DamageAbsorb = UtilityMethods.Random(1, 4);
            }

            else if (this.Level > 2 && this.Level <= 4)
            {
                this.DamageAbsorb = UtilityMethods.Random(2, 5);
            }

            else if (this.Level > 4 && this.Level <= 6)
            {
                this.DamageAbsorb = UtilityMethods.Random(3, 6);
            }

            else
            {
                this.DamageAbsorb = UtilityMethods.Random(4, 7);
            }
        }

        public void DropEquipment(ItemsList collection)
        {
            ItemManager manager = new ItemManager();
            manager.LoadItems(collection);

            var rnd = new Random();
            int maxIndex = collection.ItemsCollection.Count();
            var item = collection.ItemsCollection[rnd.Next(maxIndex)];


            Console.WriteLine($"You have earned {item.Name}. Congratulations!");


            if (item.Name.Contains("Armguard"))
            {
                if (this.Armguard.CompareTo((Gear)item) < 0)
                {
                    this.Armguard = (Gear)item;
                }
            }

            else if (item.Name.Contains("Boots"))
            {
                if (this.Boots.CompareTo((Gear)item) < 0)
                {
                    this.Boots = (Gear)item;
                }
            }

            else if (item.Name.Contains("Cuirass"))
            {
                if (this.Cuirass.CompareTo((Gear)item) < 0)
                {
                    this.Cuirass = (Gear)item;
                }
            }

            else if (item.Name.Contains("Sword"))
            {
                if (this.Weapon.CompareTo((Weapon)item) < 0)
                {
                    this.Weapon = (Weapon)item;
                }
            }

            // Add other junk items in player inventory.
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Level: {this.Level}");
            sb.AppendLine($"Experience: {this.Experience}");
            sb.AppendLine($"Health: {this.Health}");
            sb.AppendLine($"Gold: {this.Gold}.{this.Silver}");

            sb.AppendLine($"{this.Weapon}");
            sb.AppendLine($"{this.Cuirass}");
            sb.AppendLine($"{this.Boots}");
            sb.AppendLine($"{this.Armguard}");

            return sb.ToString().TrimEnd();
        }
    }
}
