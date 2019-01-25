using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_Assignment.Utils;



namespace ASE_AssignmentTest
{

    [TestClass]
    public class SummaryTester
    {
        /// <summary>
        /// Variable declaration for testing
        /// </summary>
        List<int> heart = new List<int>()
            {
             20, 30, 40
            };

        List<double> speed = new List<double>()
            {
             20, 30, 40
            };
        List<double> speed_mile = new List<double>()
            {
             20, 30, 40
            };
        List<int> cadence = new List<int>()
            {
             20, 30, 40
            };
        List<int> altitude = new List<int>()
            {
             20, 30, 40
            };

        List<int> power = new List<int>()
            {
             20, 30, 40
            };
        String time = "12:00";


        /// <summary>
        /// To test the total distance calculated
        /// </summary>
        [TestMethod]
        public void TestTotalDistance()
        {
            double hour = 1;
            double minute = 60;
            double second = 0;
            List<double> speed = new List<double>()
            {
             20, 30, 40
            };

            double totalTime = hour + (minute / 60) + (second / 3600);

            double averageSpeed = speed.Average();

            double distance = averageSpeed * totalTime;
            double distance1 = System.Math.Round(distance, 2);
            Console.WriteLine(averageSpeed);
            Assert.AreEqual(60, distance1);

        }

        /// <summary>
        /// To check the total distaance calculated in miles
        /// </summary>
        [TestMethod()]
        public void TotalDistanceMileTest()
        {
            double hour = 1;
            double minute = 60;
            double second = 0;
            List<double> speed = new List<double>()
            {
             20, 30, 40
            };

            double totalTime = hour + (minute / 60) + (second / 3600);

            double averageSpeed = speed.Average();

            double distance = averageSpeed * totalTime;
            double distance1 = System.Math.Round(distance, 2);
            Console.WriteLine(averageSpeed);
            Assert.AreEqual(60, distance1);
        }

        /// <summary>
        /// This test case tests the calculated average Speed
        /// </summary>
        [TestMethod()]
        public void AverageSpeedTest()
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, speed_mile, cadence, altitude, power, time);
            String result = sv.AverageSpeed();
            Assert.AreEqual(result, "Average Speed=30 km/hr");
        }

        /// <summary>
        /// This test case ckecks the calculated average speed in miles
        /// </summary>
        [TestMethod()]
        public void AverageSpeedMileTest()
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, speed_mile, cadence, altitude, power, time);
            String result = sv.AverageSpeedMile();
            Assert.AreEqual(result, "Average Speed=30 miles/hr");
        }

        /// <summary>
        /// This test case ckecks the calculated maximum speed calculated in miles
        /// </summary>
        [TestMethod()]
        public void MaxSpeedMileTest()
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, speed_mile, cadence, altitude, power, time);
            String result = sv.MaxSpeedMile();
            Assert.AreEqual(result, "Maximum Speed=40 miles/hr");
        }


        /// <summary>
        /// This test tests the calculated maximum speed in kilometers
        /// </summary>
        [TestMethod()]
        public void MaxSpeedTest()
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, speed_mile, cadence, altitude, power, time);
            String result = sv.MaxSpeed();
            Assert.AreEqual(result, "Maximum Speed=40 km/hr");
        }

        [TestMethod()]
        public void MaxPowerTest()
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, speed_mile, cadence, altitude, power, time);
            String result = sv.maxPower();
            Assert.AreEqual(result, "Maximum Power=40 watts");
        }


        [TestMethod()]
        public void AverageAltitudeTest()
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, speed_mile, cadence, altitude, power, time);
            String result = sv.AverageAltitude();
            Assert.AreEqual(result, "Average Altitude=30 m/ft");
        }



        [TestMethod()]
        public void MaxHeartRateTest()
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, speed_mile, cadence, altitude, power, time);
            String result = sv.MaxHeartRate();
            Assert.AreEqual(result, "Maximum Heart Rate=40 bpm");
        }
    }
}

