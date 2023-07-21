using System;

namespace DungeonCrawler
{
    public class Cleric : Character
    {
        public Cleric(string name, int level) : base(name, level)
        {
            // Initialize Cleric-specific properties and abilities here
            // For example, let's set the starting equipment for the Cleric
            Equipment = new Equipment(EquipmentType.LightArmor, EquipmentType.Shield, EquipmentType.HandWeapon);
        }

        public override void LevelUp()
        {
            base.LevelUp();
            // Implement Cleric-specific level up logic here
            // For example, increase the Cleric's life by 4 for each level-up
            MaxHealth += 4;
        }

        public override void Attack(Character target)
        {
            // Implement Cleric's attack logic here
            // Since the Cleric's attack roll is based on level, you can add the Cleric's level to the attack roll
            int attackRoll = RollD20() + Level;

            // Check if the target is an undead creature, and if so, add the Cleric's full level to the attack roll
            if (target is UndeadCreature)
            {
                attackRoll += Level;
            }

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

        public void Heal(Character target)
        {
            // Implement Cleric's healing logic here
            // The Healing power allows the Cleric to heal a number of life points equal to d6 plus his level
            int healingAmount = RollD6() + Level;
            target.Heal(healingAmount);
        }
    }
}
