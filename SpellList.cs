```csharp
using System.Collections.Generic;

namespace DungeonCrawler
{
    public class SpellList
    {
        private List<string> spells;

        public SpellList()
        {
            spells = new List<string>();
        }

        public void AddSpell(string spell)
        {
            spells.Add(spell);
        }

        public void RemoveSpell(string spell)
        {
            spells.Remove(spell);
        }

        public bool HasSpell(string spell)
        {
            return spells.Contains(spell);
        }

        public List<string> GetSpells()
        {
            return spells;
        }
    }
}
```