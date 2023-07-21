```csharp
using System.Collections.Generic;

namespace DungeonCrawler
{
    public class Corridor
    {
        public List<Room> ConnectedRooms { get; set; }

        public Corridor()
        {
            ConnectedRooms = new List<Room>();
        }

        public void AddConnectedRoom(Room room)
        {
            ConnectedRooms.Add(room);
        }
    }
}
```