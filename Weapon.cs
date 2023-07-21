```csharp
using System;

namespace DungeonCrawler
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Durability { get; set; }

        public Weapon(string name, int damage, int durability)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
        }

        public void Attack()
        {
            Console.WriteLine($"Attacking with {Name} for {Damage} damage.");
            Durability--;
            if (Durability <= 0)
            {
                Console.WriteLine($"{Name} broke!");
            }
        }
    }
}
```