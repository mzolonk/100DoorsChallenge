using Doors;
using Doors.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace _100Doors
{
    [TestClass]
    public class FlipDoors
    {
        private const int numDoors = 100;

        [TestMethod]
        public void WhenInialised_CheckTheNumberOfDoors()
        {
            var house = new FlippingDoors();
            var size = house.Doors.Count();

            Assert.AreEqual(size, numDoors);
        }

        [TestMethod]
        public void BeforeAnyRun_CheckStateOfDoors_ShouldBeAllClosed()
        {
            var house = new FlippingDoors();

            var allDoorsClosed = house.Doors.All(x => x.State == DoorState.Closed);

            Assert.IsTrue(allDoorsClosed);
        }

        [DataTestMethod]
        [DataRow(1)]
        public void AfterFirstRun_CheckStateOfEverySecondDoor_ShouldBeClosed(int num)
        {
            var house = new FlippingDoors();
            var door = house.Doors;
            Logic.DoSomeFlipping(num, ref door);

            var allDoorsOpened = door.All(x => x.State == DoorState.Opened);

            Assert.IsTrue(allDoorsOpened);
        }

        [DataTestMethod]
        [DataRow(2)]
        public void CheckStatesAfteSecondRun(int num)
        {
            var house = new FlippingDoors();
            var door = house.Doors;
            Logic.DoSomeFlipping(num, ref door);

            var AllSecondDorrsClosed = door.Where((x, i) => (i +1) % num == 0).
                                    All((x => x.State == DoorState.Closed));

            Assert.IsTrue(AllSecondDorrsClosed);
        }

        [DataTestMethod]
        [DataRow(3)]
        public void CheckStatesAfteThirdRun(int num)
        {
            var house = new FlippingDoors();
            var door = house.Doors;
            Logic.DoSomeFlipping(num, ref door);

            Assert.IsTrue(door[11].State == DoorState.Opened);
            Assert.IsTrue(door[23].State == DoorState.Opened);
            Assert.IsTrue(door[99].State == DoorState.Closed);
            Assert.IsTrue(door[2].State == DoorState.Closed);
        }

        [DataTestMethod]
        [DataRow(4)]
        public void CheckStatesAfte4thRun(int num)
        {
            var house = new FlippingDoors();
            var door = house.Doors;
            Logic.DoSomeFlipping(num, ref door);

            Assert.IsTrue(door[83].State == DoorState.Closed);
            Assert.IsTrue(door[84].State == DoorState.Opened);
            Assert.IsTrue(door[85].State == DoorState.Closed);
        }


        //[DataTestMethod]
        [DataRow(5)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        [DataRow(12)]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(15)]
        [DataRow(16)]
        [DataRow(17)]
        [DataRow(18)]
        [DataRow(19)]
        [DataRow(20)]
        [DataRow(21)]
        [DataRow(22)]
        [DataRow(23)]
        [DataRow(24)]
        [DataRow(25)]
        [DataRow(26)]
        [DataRow(27)]
        [DataRow(28)]
        [DataRow(29)]
        [DataRow(30)]
        public void CheckStatesAfterNthRun(int num)
        {
            var house = new FlippingDoors();
            var door = house.Doors;
            Logic.DoSomeFlipping(num, ref door);

            var allNthDoorsOpened = door.Where((x, i) => i % num == 0).
                                    All((x => x.State == DoorState.Opened));

            Assert.IsTrue(allNthDoorsOpened);
        }

    }
}
