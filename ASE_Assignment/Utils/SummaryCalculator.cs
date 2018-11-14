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
        public SummaryCalculator(List<int> heart, List<double> speed, List<double> speed_mile, List<int> cadence, List<int> altitude, List<int> power)
        {
            this.heart = heart;
            this.speed = speed;
            this.speed_mile = speed_mile;
            this.cadence = cadence;
            this.altitude = altitude;
            this.power = power;


        }
        public string TotalDistance()
        {

            return "Total Distance= ";
        }

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
            return "Average Speed= "+averageSpeed+" km/hr";
        } 

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
            return "Average Speed= " + averageSpeed + " miles/hr";

        }
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
            double averageRate = 0;
            foreach (int val in heart)
            {
                total = total + heart[counter];
                counter++;

            }

            averageRate = total / counter;
            return "Average Speed= " + averageRate +" bpm";

        }


        public string MaxHeartRate()
        {

            int heartRate = heart.Max(); 
            

            return "Maximum Heart Rate=" + heartRate+" bpm";
        }


        public string MinHeartRate()
        {
            
            int heartRate = heart[0];
           
            int minHeartRate = heart.Min();

            return "Minimun Heart Rate=" + minHeartRate +" bpm";
        }

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
            return "Average Power= " + averagePower+"watts";
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

            return "Maximum Altitude=" + total;
            }

            averageAltitude = total / counter;
            return "Average Altitude= " + averageAltitude+" m/ft";
        }

        public string MaxAltitude()
        {
            
            int alt = altitude.Max();

            return "Maximum Altitude= "+alt+" m/ft";

        }
    }
}
