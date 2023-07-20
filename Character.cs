```csharp
using System;

namespace DungeonCrawler
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public Equipment Equipment { get; set; }

        public Character(string name, int level, int experience, int maxHealth, int attack, int defense)
        {
            Name = name;
            Level = level;
            Experience = experience;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Attack = attack;
            Defense = defense;
            Equipment = new Equipment();
        }

        public abstract void PerformAction();
    }
}
```