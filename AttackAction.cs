```csharp
using System;

namespace DungeonCrawler
{
    public class AttackAction
    {
        public void Execute(Character attacker, Character target)
        {
            int attackRoll = RollDice(attacker.Stats.Attack);
            int defenseRoll = RollDice(target.Stats.Defense);

            if (attackRoll > defenseRoll)
            {
                int damage = CalculateDamage(attacker.Stats.Attack, target.Stats.Defense);
                target.TakeDamage(damage);
                Console.WriteLine($"{attacker.Name} hits {target.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{attacker.Name} misses {target.Name}!");
            }
        }

        private int RollDice(int sides)
        {
            Random random = new Random();
            return random.Next(1, sides + 1);
        }

        private int CalculateDamage(int attack, int defense)
        {
            int damage = attack - defense;
            return Math.Max(damage, 0);
        }
    }
}
```