```csharp
using System;

namespace DungeonCrawler
{
    public class Rogue : Character
    {
        public Rogue(string name, int level) : base(name, level)
        {
            // Set initial stats for the Rogue class
            Attack = 10;
            Defense = 5;
            MaxHealth = 50;
            CurrentHealth = MaxHealth;
            Experience = 0;
        }

        public override void LevelUp()
        {
            base.LevelUp();

            // Increase stats for the Rogue class upon leveling up
            Attack += 2;
            Defense += 1;
            MaxHealth += 10;
            CurrentHealth = MaxHealth;
        }

        public override void PerformSpecialAbility()
        {
            // Implement special ability for the Rogue class
            Console.WriteLine("Performing special ability: Stealth");
            // Code for the special ability goes here
        }
    }
}
```