using Doors.Models;
using System.Collections.Generic;
using System.Linq;

namespace Doors.Helpers
{
    public static class Logic
    {
        public static void DoSomeFlipping(int FlipNumber, ref List<Door> Doors)
        {
            int Counter = 2;
            if (FlipNumber > 0)
            {
                Doors.ToList().ForEach(c => c.State = DoorState.Opened);
            }

            while (FlipNumber >= Counter)
            {
                for (int i = 0; i < Doors.Count(); i++)
                {
                    if (Doors[i].Position % Counter == 0)
                    {
                        Doors[i].State = Doors[i].State == DoorState.Closed ? DoorState.Opened : DoorState.Closed;
                    }
                }
                //Doors = Doors.ToList().Where((x, i) => i % FlipNumber == 0).Select(c => { _ = c.State == DoorState.Closed ? DoorState.Opened : DoorState.Closed; return c; }).ToList();
                Counter += 1;
                //var er = Doors.Where((x, i) => i % FlipNumber == 0);//.
                                                                    //All((x => x.State == DoorState.Closed));
            }
        }
    }
}
