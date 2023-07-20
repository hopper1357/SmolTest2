using System;

namespace DungeonCrawler
{
    public class Equipment
    {
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
        public Shield EquippedShield { get; set; }
        public MiscGear EquippedMiscGear { get; set; }
        
        public Equipment()
        {
            EquippedWeapon = null;
            EquippedArmor = null;
            EquippedShield = null;
            EquippedMiscGear = null;
        }
    }
}