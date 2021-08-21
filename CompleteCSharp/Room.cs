using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteCSharp
{
    class Room
    {
        public int windows;
        public string wallColour;
        public string floorColour;
        public string furniture;

        public Room(int aWindows, string aWallColour, string aFloorColour, string aFurniture)
        {
            
            windows = aWindows;
            wallColour = aWallColour;
            floorColour = aFloorColour;
            furniture = aFurniture;

        }
    }
}
