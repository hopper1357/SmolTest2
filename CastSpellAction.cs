```csharp
using System;

namespace DungeonCrawler
{
    public class CastSpellAction : Action
    {
        public Spell Spell { get; set; }
        public Character Target { get; set; }

        public CastSpellAction(Spell spell, Character target)
        {
            Spell = spell;
            Target = target;
        }

        public override void Execute()
        {
            Console.WriteLine($"Casting {Spell.Name} on {Target.Name}");
            // Implement spell logic here
        }
    }
}
```