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
            
            /*
            Doors = Enumerable.Range(0, 100).Select(_
                => new Door
                {
                   State = DoorState.Closed,
                   Position = Doors.Count()
                }
                ).ToList();
            */
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
                        /*
                        if (Doors[i].State == DoorState.Closed)
                        {
                            Doors[i].State = DoorState.Opened;
                        }
                        else
                        {
                            Doors[i].State = DoorState.Closed;
                        }
                        */
                    }
                }
                //Doors = Doors.ToList().Where((x, i) => i % FlipNumber == 0).Select(c => { _ = c.State == DoorState.Closed ? DoorState.Opened : DoorState.Closed; return c; }).ToList();
                Counter += 1;
                                    //All((x => x.State == DoorState.Closed));
            }
        }
    }
}
