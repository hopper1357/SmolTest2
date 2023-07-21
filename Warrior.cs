using System;

namespace DungeonCrawler
{
    public class Warrior : Character
    {
        public Warrior(string name, int level) : base(name, level)
        {
            // Initialize Warrior-specific properties and abilities here
            // For example, set the starting equipment for the Warrior
            Equipment = new Equipment(EquipmentType.LightArmor, EquipmentType.Shield, EquipmentType.HandWeapon);
        }

        public override void LevelUp()
        {
            base.LevelUp();
            // Implement Warrior-specific level up logic here
            // For example, increase the Warrior's life points by 6 for each level-up
            MaxHealth += 6;
        }

        public override void Attack(Character target)
        {
            // Implement Warrior's attack logic here
            // Since the Warrior's attack roll is based on level, you can add the Warrior's level to the attack roll
            int attackRoll = RollD20() + Level;

            // Compare the attack roll with the target's defense to determine if the attack hits
            if (attackRoll >= target.Defense)
            {
                // If the attack hits, calculate the damage and apply it to the target
                int damage = RollD6(); // Roll a six-sided die for damage
                target.TakeDamage(damage);
            }
            else
            {
                Console.WriteLine("Missed!");
            }
        }
    }
}
