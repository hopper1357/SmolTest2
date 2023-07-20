```csharp
using System;

namespace DungeonCrawler
{
    public class Player : Character
    {
        public Player(string name, ClassType classType) : base(name, classType)
        {
        }

        public void LevelUp()
        {
            Level++;
            MaxHealth += 10;
            Attack += 2;
            Defense += 1;
        }

        public void GainExperience(int experience)
        {
            Experience += experience;
            if (Experience >= 100)
            {
                LevelUp();
                Experience -= 100;
            }
        }

        public void EquipWeapon(Weapon weapon)
        {
            if (weapon != null)
            {
                if (EquippedWeapon != null)
                {
                    UnequipWeapon();
                }
                EquippedWeapon = weapon;
                Attack += weapon.AttackBonus;
            }
        }

        public void UnequipWeapon()
        {
            if (EquippedWeapon != null)
            {
                Attack -= EquippedWeapon.AttackBonus;
                EquippedWeapon = null;
            }
        }

        public void EquipArmor(Armor armor)
        {
            if (armor != null)
            {
                if (EquippedArmor != null)
                {
                    UnequipArmor();
                }
                EquippedArmor = armor;
                Defense += armor.DefenseBonus;
            }
        }

        public void UnequipArmor()
        {
            if (EquippedArmor != null)
            {
                Defense -= EquippedArmor.DefenseBonus;
                EquippedArmor = null;
            }
        }

        public void EquipShield(Shield shield)
        {
            if (shield != null)
            {
                if (EquippedShield != null)
                {
                    UnequipShield();
                }
                EquippedShield = shield;
                Defense += shield.DefenseBonus;
            }
        }

        public void UnequipShield()
        {
            if (EquippedShield != null)
            {
                Defense -= EquippedShield.DefenseBonus;
                EquippedShield = null;
            }
        }

        public void EquipMiscGear(MiscGear miscGear)
        {
            if (miscGear != null)
            {
                if (EquippedMiscGear != null)
                {
                    UnequipMiscGear();
                }
                EquippedMiscGear = miscGear;
            }
        }

        public void UnequipMiscGear()
        {
            EquippedMiscGear = null;
        }
    }
}
```