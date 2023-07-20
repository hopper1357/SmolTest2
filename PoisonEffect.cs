```csharp
using System;

namespace DungeonCrawler
{
    public class PoisonEffect : Effect
    {
        public int Damage { get; private set; }
        public int Duration { get; private set; }

        public PoisonEffect(int damage, int duration)
        {
            Damage = damage;
            Duration = duration;
        }

        public override void Apply(Character character)
        {
            character.TakeDamage(Damage);
            Duration--;
        }

        public override void Remove(Character character)
        {
            // No action needed
        }
    }
}
```