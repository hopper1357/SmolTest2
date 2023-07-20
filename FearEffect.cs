```csharp
using System;

namespace DungeonCrawler
{
    public class FearEffect : Effect
    {
        public override void Apply(Character character)
        {
            character.IsAfraid = true;
            Console.WriteLine($"{character.Name} is now afraid!");
        }
    }
}
```