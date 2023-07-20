```csharp
using System;

namespace DungeonCrawler
{
    public class Shield
    {
        public string Name { get; set; }
        public int DefenseBonus { get; set; }
        public int Durability { get; set; }

        public Shield(string name, int defenseBonus, int durability)
        {
            Name = name;
            DefenseBonus = defenseBonus;
            Durability = durability;
        }

        public void TakeDamage(int damage)
        {
            Durability -= damage;
            if (Durability < 0)
            {
                Durability = 0;
            }
        }
    }
}
```