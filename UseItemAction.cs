using System;

namespace DungeonCrawler
{
    public class UseItemAction
    {
        public void UseItem(Character character, Item item)
        {
            // Check if the character has the item in their inventory
            if (character.Inventory.Contains(item))
            {
                // Use the item
                item.Use(character);
                
                // Remove the item from the character's inventory
                character.Inventory.Remove(item);
                
                Console.WriteLine($"{character.Name} used {item.Name}.");
            }
            else
            {
                Console.WriteLine($"{character.Name} does not have {item.Name} in their inventory.");
            }
        }
    }
}