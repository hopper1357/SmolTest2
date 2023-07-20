```csharp
using System;

namespace DungeonCrawler
{
    public class Wizard : Character
    {
        public Wizard(string name, int level) : base(name, level)
        {
            // Initialize wizard-specific properties and abilities here
        }

        public override void LevelUp()
        {
            base.LevelUp();
            // Implement wizard-specific level up logic here
        }

        public override void Attack(Character target)
        {
            // Implement wizard's attack logic here
        }

        public void CastSpell(Character target, Spell spell)
        {
            // Implement wizard's spell casting logic here
        }
    }
}
```