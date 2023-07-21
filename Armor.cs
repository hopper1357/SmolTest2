```csharp
using System;

namespace DungeonCrawler
{
    public class Armor
    {
        public string Name { get; set; }
        public int Defense { get; set; }
        public int Durability { get; set; }

        public Armor(string name, int defense, int durability)
        {
            Name = name;
            Defense = defense;
            Durability = durability;
        }
    }
}
```