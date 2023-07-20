```csharp
using System;

namespace DungeonCrawler
{
    public class Fighter : Character
    {
        public Fighter(string name, int attack, int defense, int maxHealth, int level, int experience)
            : base(name, attack, defense, maxHealth, level, experience)
        {
        }

        public override void SpecialAbility()
        {
            Console.WriteLine("Fighter's special ability: Power Strike!");
        }
    }
}
```