﻿namespace Game.Items
{
    using Game.Items.Weapons;
    using Game.Items.Gears;
    using Game.Items.Gems;

    public sealed class ItemManager
    {
        public void LoadItems(ItemsList collection)
        {
            AddWeapons(collection);
            AddGears(collection);
            //AddGems(collection);

            //foreach (var weapon in collection)
            //{
            //    System.Console.WriteLine(weapon);
            //}
        }

        private void AddWeapons(ItemsList collection)
        {
            collection.ItemsCollection.Add(new Weapon("Bronze Sword", 5, 5));
            collection.ItemsCollection.Add(new Weapon("Silver Sword", 10, 7));
            collection.ItemsCollection.Add(new Weapon("Golden Sword", 15, 9));
        }

        private void AddGears(ItemsList collection)
        {
            collection.ItemsCollection.Add(new Gear("Bronze Cuirass", 10, 2));
            collection.ItemsCollection.Add(new Gear("Silver Cuirass", 20, 3));
            collection.ItemsCollection.Add(new Gear("Golden Cuirass", 30, 4));

            collection.ItemsCollection.Add(new Gear("Bronze Boots", 10, 2));
            collection.ItemsCollection.Add(new Gear("Silver Boots", 20, 3));
            collection.ItemsCollection.Add(new Gear("Golden Boots", 30, 4));

            collection.ItemsCollection.Add(new Gear("Bronze Armguard", 10, 2));
            collection.ItemsCollection.Add(new Gear("Silver Armguard", 20, 3));
            collection.ItemsCollection.Add(new Gear("Golden Armguard", 30, 4));
        }

        private void AddGems(ItemsList collection)
        {
            collection.GemsCollection.Add(new Gem("Small Ruby", 1, 0));
            collection.GemsCollection.Add(new Gem("Medium Ruby", 3, 0));
            collection.GemsCollection.Add(new Gem("Large Ruby", 5, 0));

            collection.GemsCollection.Add(new Gem("Small Emerald", 1, 0));
            collection.GemsCollection.Add(new Gem("Medium Emerald", 3, 0));
            collection.GemsCollection.Add(new Gem("Large Emerald", 5, 0));
        }
    }
}