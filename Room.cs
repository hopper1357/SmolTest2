using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public List<Enemy> Enemies { get; set; }
        public List<Item> Items { get; set; }
        public bool IsExplored { get; set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            Enemies = new List<Enemy>();
            Items = new List<Item>();
            IsExplored = false;
        }

        public void AddEnemy(Enemy enemy)
        {
            Enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            Enemies.Remove(enemy);
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }
    }
}