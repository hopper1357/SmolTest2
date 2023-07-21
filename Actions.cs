```csharp
using System;

namespace DungeonCrawler
{
    public class Actions
    {
        public void Move(Character character, Position newPosition)
        {
            // Code for moving the character to the new position
        }

        public void Attack(Character attacker, Character target)
        {
            // Code for attacking the target character
        }

        public void UseItem(Character character, Item item)
        {
            // Code for using the item by the character
        }

        public void EquipUnequip(Character character, Equipment equipment)
        {
            // Code for equipping or unequipping the equipment by the character
        }

        public void CastSpell(Character caster, Spell spell, Character target)
        {
            // Code for casting the spell on the target character
        }
    }
}
```