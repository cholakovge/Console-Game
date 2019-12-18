﻿namespace Game
{
    public class ItemManager
    {
        public void LoadItems()
        {
            ItemsList collection = new ItemsList();

            AddWeapons(collection);
            AddGears(collection);
            AddGems(collection);

            //foreach (var weapon in collection)
            //{
            //    System.Console.WriteLine(weapon);
            //}
        }

        private void AddWeapons(ItemsList collection)
        {
            collection.Add(new Weapon("Bronze Sword", 5));
            collection.Add(new Weapon("Silver Sword", 7));
            collection.Add(new Weapon("Golden Sword", 9));
        }

        private void AddGears(ItemsList collection)
        {
            collection.Add(new Gear("Bronze Cuirass", 10, 2));
            collection.Add(new Gear("Silver Cuirass", 20, 3));
            collection.Add(new Gear("Golden Cuirass", 30, 4));

            collection.Add(new Gear("Bronze Boots", 10, 2));
            collection.Add(new Gear("Silver Boots", 20, 3));
            collection.Add(new Gear("Golden Boots", 30, 4));

            collection.Add(new Gear("Bronze Armguard", 10, 2));
            collection.Add(new Gear("Silver Armguard", 20, 3));
            collection.Add(new Gear("Golden Armguard", 30, 4));
        }

        private void AddGems(ItemsList collection)
        {
            collection.Add(new Gem("Small Ruby", 1));
            collection.Add(new Gem("Medium Ruby", 3));
            collection.Add(new Gem("Large Ruby", 5));

            collection.Add(new Gem("Small Emerald", 1));
            collection.Add(new Gem("Medium Emerald", 3));
            collection.Add(new Gem("Large Emerald", 5));
        }
    }
}