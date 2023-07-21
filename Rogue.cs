using System;

namespace DungeonCrawler
{
    public class Rogue : Character
    {
        public Rogue(string name, int level) : base(name, level)
        {
            // Initialize Rogue-specific properties and abilities here
            // For example, set the starting equipment for the Rogue
            Equipment = new Equipment(EquipmentType.Rope, EquipmentType.LockPicks, EquipmentType.LightArmor, EquipmentType.HandWeapon);
            // Set starting health for the Rogue
            MaxHealth = 3 + level;
            CurrentHealth = MaxHealth;
        }

        public override void LevelUp()
        {
            base.LevelUp();
            // Implement Rogue-specific level up logic here
            // For example, increase the Rogue's life points by 3 for each level-up
            MaxHealth += 3;
        }

        public override void PerformAction()
        {
            // Implement Rogue's action logic here
            // For example, the Rogue can perform different actions based on the game mechanics

            // In this example, let's assume the Rogue performs the "Attack" action
            // You will need to provide the target character for the attack.
            // For now, let's assume a target named "Enemy" for demonstration purposes.
            Character target = new Character("Enemy", 1, 0, 5, 5, 3); // Replace this with an actual target instance.
            
            // Create an instance of the AttackAction class
            AttackAction attackAction = new AttackAction();
            attackAction.Execute(this, target);
        }

        // Additional methods specific to the Rogue can be implemented here.
    }
}
