```csharp
using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    public class CombatSystem
    {
        private List<Character> characters;
        private int currentCharacterIndex;

        public CombatSystem(List<Character> characters)
        {
            this.characters = characters;
            this.currentCharacterIndex = 0;
        }

        public void StartCombat()
        {
            Console.WriteLine("Combat started!");

            while (!IsCombatOver())
            {
                Character currentCharacter = characters[currentCharacterIndex];

                if (currentCharacter.IsAlive())
                {
                    Console.WriteLine($"It's {currentCharacter.Name}'s turn.");

                    // Perform actions for the current character
                    // TODO: Implement logic for choosing and executing actions

                    // Move to the next character
                    currentCharacterIndex = (currentCharacterIndex + 1) % characters.Count;
                }
                else
                {
                    Console.WriteLine($"{currentCharacter.Name} is dead and cannot take a turn.");
                    currentCharacterIndex = (currentCharacterIndex + 1) % characters.Count;
                }
            }

            Console.WriteLine("Combat ended!");
        }

        private bool IsCombatOver()
        {
            int aliveCharactersCount = 0;

            foreach (Character character in characters)
            {
                if (character.IsAlive())
                {
                    aliveCharactersCount++;
                }
            }

            return aliveCharactersCount <= 1;
        }
    }
}
```