using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace ASE_Assignment.Utils
{
    class SummaryCalculator
    {
        
        List<int> heart = new List<int>();
        List<double> speed = new List<double>();
        List<double> speed_mile = new List<double>();
        List<int> cadence = new List<int>();
        List<int> altitude = new List<int>();
        List<int> power = new List<int>();
        List<int> powerbalance = new List<int>();
        string time="";
        public SummaryCalculator(List<int> heart, List<double> speed, List<double> speed_mile, List<int> cadence, List<int> altitude, List<int> power, string time)
        {
            this.heart = heart;
            this.speed = speed;
            this.speed_mile = speed_mile;
            this.cadence = cadence;
            this.altitude = altitude;
            this.power = power;
            this.time = time;


        }

        //Calculates the total distance covered in kilometers
        public string TotalDistance()
        {
            string[] timee = time.Split(':');
            double hour = double.Parse(timee[0]);
            double minute = double.Parse(timee[1]);
            double second = double.Parse(timee[2]);
           
            double totalTime = hour + (minute / 60) + (second / 3600);

            double averageSpeed = speed.Average();

            double distance = averageSpeed * totalTime;
            double distance1 =System.Math.Round(distance, 2);



            return "Total Distance= "+distance1+"km";
        }

        //Calculates total distance covered in miles
        public string TotalDistanceMile()
        {
            string[] timee = time.Split(':');
            double hour = double.Parse(timee[0]);
            double minute = double.Parse(timee[1]);
            double second = double.Parse(timee[2]);

            double totalTime = hour + (minute / 60) + (second / 3600);

            double averageSpeed = speed_mile.Average();

            double distance = averageSpeed * totalTime;
            double distance1 = System.Math.Round(distance, 2);

            


            return "Total Distance= " + distance1 + "miles";
        }

        //Calculates average speed
        public string AverageSpeed()
        {

            double total=0; ;
            int counter=0;
            double averageSpeed = 0;
            foreach(int  val in speed)
            {
                total = total + speed[counter];
                counter++;

            }

            averageSpeed = total / counter;
            double average1 = System.Math.Round(averageSpeed, 2);
            return "Average Speed= "+average1+" km/hr";
        } 


        //calculates average speed in miles
        public String AverageSpeedMile()
        {
            double total = 0; ;
            int counter = 0;
            double averageSpeed = 0;
            foreach (int val in speed)
            {
                total = total + speed_mile[counter];
                counter++;

            }
            averageSpeed = total / counter;
            double average = System.Math.Round(averageSpeed, 2);
            return "Average Speed= " + average + " miles/hr";

        }

        //Calculates maximum speed in milees
        public string MaxSpeedMile()
        {

            double speedd = speed_mile.Max();


            return "Maximum Speed=" + speedd+ " miles/hr";
        }

        public string MaxSpeed()
        {
           
            double speedd = speed.Max();
            
         
            return "Maximum Speed=" +speedd+" km/hr";
        }

        public string AverageHeartRate()
        {

            int total = 0; ;
            int counter = 0;
            double averageRate = 0.00; 
            foreach (int val in heart)
            {
                total = total + heart[counter];
                counter++;

            }

            averageRate = total / counter;
            double distance1 = System.Math.Round(averageRate, 2);
            return "Average Heart Rate= " + distance1 +" bpm";

        }

        //Calculates and returns maximum heart rate
        public string MaxHeartRate()
        {

            int heartRate = heart.Max(); 
            

            return "Maximum Heart Rate=" + heartRate+" bpm";
        }

        //Calculates and returns minimum heart rate
        public string MinHeartRate()
        {
            
            int heartRate = heart[0];
           
            int minHeartRate = heart.Min();

            return "Minimun Heart Rate=" + minHeartRate +" bpm";
        }

        //Calculates Average power
        public string AveragePower()
        {

            int total = 0; ;
            int counter = 0;
            double averagePower = 0;
            foreach (int val in power)
            {
                total = total + power[counter];
                counter++;

            }

            averagePower = total / counter;
            double power1 = System.Math.Round(averagePower, 2);
            return "Average Power= " + power1+"watts";
        }

        //Calculating  maximum power
        public string maxPower()
        {


            int maxPow = power.Max();

            return "Maximun Power=" + maxPow + " watts";
        }


        public string AverageAltitude()
        {

            int total = 0; 
            int counter = 0;
            double averageAltitude = 0;
            foreach (int val in altitude)
            {
                total = total + altitude[counter];
                counter++;

            }

            averageAltitude = total / counter;
            double alt = System.Math.Round(averageAltitude, 2);
            return "Average Altitude= " + alt+" m/ft";
        }
        
    }
}
