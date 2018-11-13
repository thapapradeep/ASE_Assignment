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
        List<int> speed = new List<int>();
        List<int> cadence = new List<int>();
        List<int> altitude = new List<int>();
        List<int> power = new List<int>();
        List<int> powerbalance = new List<int>();
        public SummaryCalculator(List<int> heart, List<int> speed, List<int> cadence, List<int> altitude, List<int> power)
        {
            this.heart = heart;
            this.speed = speed;
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

            int total=0; ;
            int counter=0;
            double averageSpeed = 0;
            foreach(int  val in speed)
            {
                total = total + speed[counter];
                counter++;

            }

            averageSpeed = total / counter;
            return "Average Speed= "+averageSpeed;
        }

        public string MaxSpeed()
        {
           
            int speedd = speed.Max();
            
         
            return "Maximum Speed=" +speedd;
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
            return "Average Speed= " + averageRate;

        }


        public string MaxHeartRate()
        {

            int heartRate = heart.Max(); 
            

            return "Maximum Heart Rate=" + heartRate;
        }


        public string MinHeartRate()
        {
            
            int heartRate = heart[0];
            int counter = 1;
            int minHeartRate = heart.Min();

            return "Minimun Heart Rate=" + minHeartRate;
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
            return "Average Power= " + averagePower;
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
            return "Average Altitude= " + averageAltitude;
        }

        public string MaxAltitude()
        {
            
            int alt = altitude.Max();

            return "Maximum Altitude= "+alt;

        }
    }
}
