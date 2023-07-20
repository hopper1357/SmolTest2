```csharp
using System;

namespace DungeonCrawler
{
    public class MiscGear
    {
        // Properties
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        // Constructor
        public MiscGear(string name, int value, string description)
        {
            Name = name;
            Value = value;
            Description = description;
        }

        // Method to use the misc gear
        public void Use()
        {
            Console.WriteLine($"Using {Name}...");
            // Add logic for using the misc gear
        }
    }
}
```