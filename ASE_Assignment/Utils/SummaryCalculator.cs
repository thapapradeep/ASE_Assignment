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
        double FTP = 0;
        double NP = 0;
        double PB = 12;
        double IF = 0;
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



            return "Total Distance="+distance1+" km";
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

            


            return "Total Distance="+distance1+" miles";
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
            return "Average Speed="+average1+" km/hr";
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
            return "Average Speed=" + average + " miles/hr";

        }

        //Calculates maximum speed in milees
        public string MaxSpeedMile()
        {

            double speedd = speed_mile.Max();


            return "Maximum Speed=" + speedd+" miles/hr";
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
            return "Average Heart Rate=" + distance1 +" bpm";

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

            return "Minimun Heart Rate=" + minHeartRate+" bpm";
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
            return "Average Power=" + power1+" watts";
        }

        //Calculating  maximum power
        public string maxPower()
        {


            int maxPow = power.Max();

            return "Maximun Power=" + maxPow +" watts";
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
            return "Average Altitude=" + alt+" m/ft";
        }
        
        public String CalculateFTP()
        {
            List<int> power20 = new List<int>();
            int num = 0;
            int[] array_power = power.ToArray();
            for(int counter=0; counter<=1200; counter++)
            {
                num = array_power[counter];
                power20.Add(num);
            }
            double avg_power = power20.Average();
           double  FTP1 = avg_power * 0.95;
            FTP = System.Math.Round(FTP1, 2);
            return "FTP="+FTP+" watts";
        }


        public String CalculateNP()
        {
            List<int> power10 = new List<int>();
            List<int> power20 = new List<int>();
            List<int> power30 = new List<int>();
            int num = 0;
            int[] array_power = power.ToArray();
            for (int counter = 0; counter <= 600; counter++)
            {
                num = array_power[counter];
                power10.Add(num);
            }

            for (int counter = 601; counter <= 1200; counter++)
            {
                num = array_power[counter];
                power20.Add(num);
            }

            for (int counter = 1201; counter <= 1800; counter++)
            {
                num = array_power[counter];
                power30.Add(num);
               
            }
            double avg_power1 = power10.Average();
            double avg_power2 = power20.Average();
            double avg_power3 = power30.Average();

            double index4 = Math.Pow(avg_power1, 4);
            double index5 = Math.Pow(avg_power2, 4);
            double index6= Math.Pow(avg_power3, 4);
            

            double multiply1 = index4 * 10;
            double multiply2 = index5 * 10;
            double multiply3 = index6 * 10;

            double np1 = Math.Sqrt(Math.Sqrt(multiply1));
            double np2 = Math.Sqrt(Math.Sqrt(multiply2));
            double np3 = Math.Sqrt(Math.Sqrt(multiply3));
            

            double  NP1 = (np1 + np2 + np3) / 3;
            NP = System.Math.Round(NP1, 2);

            return "Normalized Power=" + NP+" watts";

        }

        public String CalculateIF()
        {
           double IF1 = NP / FTP;
            IF = System.Math.Round(IF1, 2);
          
            return "Intensity Factor=" + IF+" .";
        }

        public String CalculateTSS()
        {
            int[] heart1 = heart.ToArray();
            int sec = heart1.Length;

            double TSS1 = (sec * NP * IF) / (FTP * 3600) * 100;
            double TSS = System.Math.Round(TSS1, 2);

            return "Training Stress Score=" + TSS+" .";

        }
    }
}
