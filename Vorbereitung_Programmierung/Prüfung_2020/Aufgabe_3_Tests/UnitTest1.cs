using System;
using Aufgabe_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aufgabe_3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Base6Coordinate base6Coordinate = new Base6Coordinate(49, NorthSouth.North, 12, 23.4828, 7, EastWest.East, 2, 46.266);

            DecimalCoordinate real = Aufgabe_3.Convert.ConvertToDecimal(base6Coordinate);
            DecimalCoordinate expected = new DecimalCoordinate(49.206523, 7.046185);

            Assert.AreEqual(expected.Latitude,real.Latitude,0.00000001);
            Assert.AreEqual(expected.Longitude, real.Longitude, 0.00000001);
        }

        [TestMethod]
        public void test()
        {
            Assert.AreEqual(2 + 2, 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Base6Coordinate base6Coordinate = new Base6Coordinate(51, NorthSouth.North, 30, 2.0448, 0, EastWest.West, 8, 34.4688);

            DecimalCoordinate real = Aufgabe_3.Convert.ConvertToDecimal(base6Coordinate);
            DecimalCoordinate expected = new DecimalCoordinate(51.500568, -0.142908);

            Assert.AreEqual(expected.Latitude, real.Latitude, 0.000001);
            Assert.AreEqual(expected.Longitude, real.Longitude, 0.000001);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Base6Coordinate base6Coordinate = new Base6Coordinate(33, NorthSouth.South, 53, 51.9972, 151, EastWest.East, 15, 35.1576);

            DecimalCoordinate real = Aufgabe_3.Convert.ConvertToDecimal(base6Coordinate);
            DecimalCoordinate expected = new DecimalCoordinate(-33.897777, 151.259766);

            Assert.AreEqual(expected.Latitude, real.Latitude, 0.000001);
            Assert.AreEqual(expected.Longitude, real.Longitude, 0.000001);
        }
    }
}
