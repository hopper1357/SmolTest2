```csharp
using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    public class MonsterSpawner
    {
        private List<Monster> monsterList;

        public MonsterSpawner()
        {
            monsterList = new List<Monster>();
        }

        public void SpawnMonsters(Room room)
        {
            int numMonsters = GetNumMonsters(room);
            for (int i = 0; i < numMonsters; i++)
            {
                Monster monster = GenerateMonster();
                monsterList.Add(monster);
            }
        }

        private int GetNumMonsters(Room room)
        {
            // Logic to determine the number of monsters to spawn based on room size and difficulty
            return 0;
        }

        private Monster GenerateMonster()
        {
            // Logic to generate a random monster
            return null;
        }
    }

    public class Monster
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public bool IsAlive { get; set; }

        public Monster(string name, int attack, int defense, int maxHealth, int level, int experience)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Level = level;
            Experience = experience;
            IsAlive = true;
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
            if (CurrentHealth <= 0)
            {
                IsAlive = false;
            }
        }
    }
}
```
