```csharp
using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    public class LootTable
    {
        private Dictionary<string, List<string>> lootTable;

        public LootTable()
        {
            lootTable = new Dictionary<string, List<string>>();
        }

        public void AddLoot(string enemyType, string loot)
        {
            if (!lootTable.ContainsKey(enemyType))
            {
                lootTable[enemyType] = new List<string>();
            }

            lootTable[enemyType].Add(loot);
        }

        public string GetRandomLoot(string enemyType)
        {
            if (lootTable.ContainsKey(enemyType))
            {
                List<string> lootList = lootTable[enemyType];
                Random random = new Random();
                int index = random.Next(lootList.Count);
                return lootList[index];
            }

            return null;
        }
    }
}
```