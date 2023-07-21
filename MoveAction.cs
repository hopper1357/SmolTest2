```csharp
using System;

namespace DungeonCrawler
{
    public class MoveAction
    {
        public void Execute(Character character, Position newPosition)
        {
            // Check if the new position is valid
            if (IsValidPosition(newPosition))
            {
                // Update the character's position
                character.Position = newPosition;

                // Perform any additional logic related to moving
                // ...

                Console.WriteLine($"{character.Name} moved to position ({newPosition.X}, {newPosition.Y}).");
            }
            else
            {
                Console.WriteLine("Invalid position. Unable to move.");
            }
        }

        private bool IsValidPosition(Position position)
        {
            // Check if the position is within the bounds of the dungeon
            // ...

            return true; // Placeholder logic, replace with actual implementation
        }
    }
}
```