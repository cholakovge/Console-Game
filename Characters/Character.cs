﻿namespace Game.Characters
{
    using Game.Items;
    using Game.Methods;
    using System;
    public abstract class Character
    {
        private string name;
        private int damage;
        private int health;
        public Character(string name, int damage, int health)
        {
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Player name must be at least 3 symbols.", "Name");
                }

                this.name = value;
            }
        }
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Damage must be a positive number.");
                }

                this.damage = value;
            }
        }
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public void DefaultValues(Player player, Monster monster)
        {
            player.Health = 30;
            monster.Health = UtilityMethods.Random(30, 40);
        }

        public void FightEngine(Player player, Monster monster)
        {
            monster.Damage = UtilityMethods.Random(5, 14);

            player.Health -= monster.Damage - player.DamageAbsorb;

            monster.Health -= player.Damage;
        }

        public void IncreaseDamage(Player player)
        {
            if (player.Level <= 2)
            {
                player.Damage = 9;
            }

            else if (player.Level > 2 && player.Level <= 4)
            {
                player.Damage = 10;
            }

            else if (player.Level > 4 && player.Level <= 6)
            {
                player.Damage = 12;
            }

            else
            {
                player.Damage = 15;
            }
        }
    }
}
