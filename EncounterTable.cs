```csharp
using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    public class EncounterTable
    {
        private Dictionary<int, List<Monster>> table;

        public EncounterTable()
        {
            table = new Dictionary<int, List<Monster>>();
        }

        public void AddEncounter(int level, List<Monster> monsters)
        {
            if (!table.ContainsKey(level))
            {
                table[level] = new List<Monster>();
            }

            table[level].AddRange(monsters);
        }

        public List<Monster> GetEncounter(int level)
        {
            if (table.ContainsKey(level))
            {
                return table[level];
            }

            return null;
        }
    }
}
```