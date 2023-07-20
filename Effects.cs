```csharp
using System;

namespace DungeonCrawler
{
    public abstract class Effects
    {
        public abstract void ApplyEffect(Character character);
    }

    public class PoisonEffect : Effects
    {
        public override void ApplyEffect(Character character)
        {
            // Apply poison effect to the character
        }
    }

    public class FearEffect : Effects
    {
        public override void ApplyEffect(Character character)
        {
            // Apply fear effect to the character
        }
    }

    public class ParalysisEffect : Effects
    {
        public override void ApplyEffect(Character character)
        {
            // Apply paralysis effect to the character
        }
    }
}
```