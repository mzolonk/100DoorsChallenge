using Doors.Models;
using System.Collections.Generic;
using System.Linq;

namespace Doors
{
    public class FlippingDoors
    {
        public FlippingDoors()
        {
            InitialiseDoors();
        }
        public List<Door> Doors { get; set; }

        private void InitialiseDoors()
        {
            Doors = new List<Door>();
 
            for (int i = 0; i<100; i++)
            {
                Doors.Add(new Door
                {
                    State = DoorState.Closed,
                    Position = i + 1
                });
            }
            
        }

        public void DoSomeFlipping(int FlipNumber)
        {
            int Counter = 1; 

            Doors.ToList().ForEach(c => c.State = DoorState.Opened);
        
            while(FlipNumber > Counter)
            {
                for (int i = 0; i < Doors.Count(); i++)
                {
                    if(Doors[i].Position % FlipNumber == 0)
                    {
                        Doors[i].State = Doors[i].State == DoorState.Closed ? DoorState.Opened : DoorState.Closed;
                    }
                }

                Counter += 1;

            }
        }
    }
}
