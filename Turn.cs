```csharp
using System;

namespace DungeonCrawler
{
    public class Turn
    {
        private int turnNumber;
        private Character currentPlayer;
        private bool isPlayerTurn;

        public Turn(int turnNumber, Character currentPlayer, bool isPlayerTurn)
        {
            this.turnNumber = turnNumber;
            this.currentPlayer = currentPlayer;
            this.isPlayerTurn = isPlayerTurn;
        }

        public void StartTurn()
        {
            Console.WriteLine($"Turn {turnNumber} started.");
            Console.WriteLine($"It is {(isPlayerTurn ? "player" : "enemy")} turn.");
            Console.WriteLine($"Current player: {currentPlayer.Name}");
        }

        public void EndTurn()
        {
            Console.WriteLine($"Turn {turnNumber} ended.");
        }
    }
}
```