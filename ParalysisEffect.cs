```csharp
using System;

namespace DungeonCrawler
{
    public class ParalysisEffect : Effect
    {
        public override void Apply(Character character)
        {
            character.IsParalyzed = true;
            Console.WriteLine($"{character.Name} is paralyzed!");
        }

        public override void Remove(Character character)
        {
            character.IsParalyzed = false;
            Console.WriteLine($"{character.Name} is no longer paralyzed.");
        }
    }
}
```