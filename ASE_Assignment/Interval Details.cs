using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASE_Assignment.Utils;

namespace ASE_Assignment
{
    public partial class Interval_Details : Form
    {


        List<string> arrays = new List<string>();
        List<int> heart = new List<int>();
        List<double> speed = new List<double>();
        List<double> speed_mile = new List<double>();
        List<int> cadence = new List<int>();
        List<int> altitude = new List<int>();
        List<int> power = new List<int>();
        List<int> powerbalance = new List<int>();
        List<DateTime> dateTime = new List<DateTime>();
        List<String> summary = new List<String>();


        List<string> arrays1 = new List<string>();
        List<int> heart11 = new List<int>();
        List<double> speed11 = new List<double>();
        List<double> speed_mile11 = new List<double>();
        List<int> cadence11 = new List<int>();
        List<int> altitude11 = new List<int>();
        List<int> power11 = new List<int>();
        List<int> powerbalance11 = new List<int>();
        List<DateTime> dateTime1 = new List<DateTime>();
        List<String> summary1 = new List<String>();
        List<int> intervals = new List<int>();

        String time = "";
        int interval = 1;
        public Interval_Details(List<int> heart, List<double> speed, List<double> speed_mile, List<int> cadence, List<int> altitude, List<int> power, List<int> powerbalance, List<int>intervals, string time)
        {
            InitializeComponent();

            int_1.Enabled = false;
            int_2.Enabled = false;
            int_3.Enabled = false;
            int_4.Enabled = false;
            int_5.Enabled = false;

            this.heart = heart;
            this.speed = speed;
            this.speed_mile = speed_mile;
            this.cadence = cadence;
            this.altitude = altitude;
            this.power = power;
            this.time = time;
            this.powerbalance = powerbalance;
            this.intervals = intervals;


            Interval_Ckeck();


        }
        public void Interval_Ckeck() {
            int count = intervals.ToArray().Length;
            txt_info.Text = "Detecetd " + count + " intervals" + Environment.NewLine + "Click The buttons below to view the info";
            if (count == 1)
            {
                int_1.Enabled = true;
            }
            else if (count == 2)
            {
                int_1.Enabled = true;
                int_2.Enabled = true;
            }
            else if (count == 3)
            {
                int_1.Enabled = true;
                int_2.Enabled = true;
                int_3.Enabled = true;
            }
            else if (count == 4)
            {
                int_1.Enabled = true;
                int_2.Enabled = true;
                int_3.Enabled = true;
                int_4.Enabled = true;
            }
            else
            {
                int_1.Enabled = true;
                int_2.Enabled = true;
                int_3.Enabled = true;
                int_4.Enabled = true;
                int_5.Enabled = true;

            }

            foreach (int var in heart)
            {
                heart11.Add(var);
            }
            foreach (int var in speed)
            {
                speed11.Add(var);
            }
            foreach (int var in speed_mile)
            {
                speed_mile11.Add(var);
            }
            foreach (int var in cadence)
            {
                cadence11.Add(var);
            }
            foreach (int var in altitude)
            {
                altitude11.Add(var);
            }
            foreach (int var in power)
            {
                power11.Add(var);
            }
            foreach (int var in powerbalance)
            {
                powerbalance11.Add(var);
            }


        }





        public void TableFiller(String unit)
        {
            if (unit.Equals("km/hr"))
            {
                int counter = 0;
                foreach (int value in heart)
                {
                    dataGridView1.Rows.Add(heart[counter] + " bpm", speed[counter] + " km/hr", cadence[counter] + " rpm", altitude[counter] + " m/ft", power[counter] + " watt", powerbalance[counter], timeBuilder(time));
                    counter++;
                    interval++;
                }
            }
        }

        private String timeBuilder(string time)
        {

            string[] hms = time.Split(':');
            int hour = int.Parse(hms[0]);
            int minute = int.Parse(hms[1]);
            double second1 = double.Parse(hms[2]);
            int second = Convert.ToInt32(second1);
            DateTime ts = new DateTime(2018, 11, 26, hour, minute, second);
            string result = ts.AddSeconds(interval).ToString("HH:mm:ss.f");
            return result;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       public void InfoNuller()
        {
            txtSummary.Text = "";
            heart = new List<int>();
            speed = new List<double>();
            speed_mile = new List<double>();
            cadence = new List<int>();
            altitude = new List<int>();
            power = new List<int>(); ;
            powerbalance = new List<int>();
        }

        private void int_1_Click(object sender, EventArgs e)
        {
            int[] heart_array = heart11.ToArray();
            double[] speed_array = speed11.ToArray();
            double[] speed_mile_array = speed_mile11.ToArray();
            int[] cadence_array = cadence11.ToArray();
            int[] altitude_array = altitude11.ToArray();
            int[] power_array = power11.ToArray();
            int[] pow_bal_array = powerbalance11.ToArray();

            int[] interval = intervals.ToArray();



            Console.WriteLine(heart_array[0]);
            for (int counter1 = 0; counter1 <intervals[0]; counter1++)
            {
                heart.Add(heart_array[counter1]);
                speed.Add(speed_array[counter1]);
                speed_mile.Add(speed_mile_array[counter1]);
                cadence.Add(cadence_array[counter1]);
                altitude.Add(altitude_array[counter1]);
                power.Add(power_array[counter1]);
                powerbalance.Add(pow_bal_array[counter1]);


            }
            do
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView1.Rows.Count > 1);


            TableFiller("km/hr");
            SummaryFiller();
        }

        private void int_2_Click(object sender, EventArgs e)
        {
            int[] heart_array = heart11.ToArray();
            double[] speed_array = speed11.ToArray();
            double[] speed_mile_array = speed_mile11.ToArray();
            int[] cadence_array = cadence11.ToArray();
            int[] altitude_array = altitude11.ToArray();
            int[] power_array = power11.ToArray();
            int[] pow_bal_array = powerbalance11.ToArray();

            int[] interval = intervals.ToArray();



            Console.WriteLine(heart_array[0]);
            for (int counter1 = intervals[0]; counter1 < intervals[1]; counter1++)
            {
                heart.Add(heart_array[counter1]);
                speed.Add(speed_array[counter1]);
                speed_mile.Add(speed_mile_array[counter1]);
                cadence.Add(cadence_array[counter1]);
                altitude.Add(altitude_array[counter1]);
                power.Add(power_array[counter1]);
                powerbalance.Add(pow_bal_array[counter1]);


            }
            do
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView1.Rows.Count > 1);


            TableFiller("km/hr");
            SummaryFiller();
        }

        private void int_3_Click(object sender, EventArgs e)
        {
            int[] heart_array = heart11.ToArray();
            double[] speed_array = speed11.ToArray();
            double[] speed_mile_array = speed_mile11.ToArray();
            int[] cadence_array = cadence11.ToArray();
            int[] altitude_array = altitude11.ToArray();
            int[] power_array = power11.ToArray();
            int[] pow_bal_array = powerbalance11.ToArray();

            int[] interval = intervals.ToArray();
            SummaryFiller();



            Console.WriteLine(heart_array[0]);
            for (int counter1 = intervals[1]; counter1 < intervals[2]; counter1++)
            {
                heart.Add(heart_array[counter1]);
                speed.Add(speed_array[counter1]);
                speed_mile.Add(speed_mile_array[counter1]);
                cadence.Add(cadence_array[counter1]);
                altitude.Add(altitude_array[counter1]);
                power.Add(power_array[counter1]);
                powerbalance.Add(pow_bal_array[counter1]);


            }
            do
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView1.Rows.Count > 1);


            TableFiller("km/hr");
            SummaryFiller();
        }

        private void int_4_Click(object sender, EventArgs e)
        {
            int[] heart_array = heart11.ToArray();
            double[] speed_array = speed11.ToArray();
            double[] speed_mile_array = speed_mile11.ToArray();
            int[] cadence_array = cadence11.ToArray();
            int[] altitude_array = altitude11.ToArray();
            int[] power_array = power11.ToArray();
            int[] pow_bal_array = powerbalance11.ToArray();

            int[] interval = intervals.ToArray();



            Console.WriteLine(heart_array[0]);
            for (int counter1 = intervals[2]; counter1 < intervals[3]; counter1++)
            {
                heart.Add(heart_array[counter1]);
                speed.Add(speed_array[counter1]);
                speed_mile.Add(speed_mile_array[counter1]);
                cadence.Add(cadence_array[counter1]);
                altitude.Add(altitude_array[counter1]);
                power.Add(power_array[counter1]);
                powerbalance.Add(pow_bal_array[counter1]);


            }
            do
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView1.Rows.Count > 1);


            TableFiller("km/hr");
            SummaryFiller();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int[] heart_array = heart11.ToArray();
            double[] speed_array = speed11.ToArray();
            double[] speed_mile_array = speed_mile11.ToArray();
            int[] cadence_array = cadence11.ToArray();
            int[] altitude_array = altitude11.ToArray();
            int[] power_array = power11.ToArray();
            int[] pow_bal_array = powerbalance11.ToArray();

            int[] interval = intervals.ToArray();



            Console.WriteLine(heart_array[0]);
            for (int counter1 = intervals[3]; counter1 < intervals[4]; counter1++)
            {
                heart.Add(heart_array[counter1]);
                speed.Add(speed_array[counter1]);
                speed_mile.Add(speed_mile_array[counter1]);
                cadence.Add(cadence_array[counter1]);
                altitude.Add(altitude_array[counter1]);
                power.Add(power_array[counter1]);
                powerbalance.Add(pow_bal_array[counter1]);


            }
            do
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView1.Rows.Count > 1);


            TableFiller("km/hr");
            SummaryFiller();
        }


        public void SummaryFiller()
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, speed_mile, cadence, altitude, power, time);
            string totalDistanceKm = sv.TotalDistance();
            string totalMile = sv.TotalDistanceMile();
            string avgSpeed = sv.AverageSpeed();
            string maxSpeed = sv.MaxSpeed();
            string avgSpeedMile = sv.AverageSpeedMile();
            string maxSpeedMile = sv.MaxSpeedMile();
            string avgHeartRate = sv.AverageHeartRate();
            string minHeartRate = sv.MinHeartRate();
            string maxHeartRate = sv.MaxHeartRate();
            string avgPower = sv.AveragePower();
            string avgAlt = sv.AverageAltitude();
            string maxPower = sv.maxPower();

            List<string> summary = new List<string>();
            summary.Add(totalMile);
            summary.Add(avgSpeedMile);
            summary.Add(maxSpeedMile);
            summary.Add(avgHeartRate);
            summary.Add(maxHeartRate);
            summary.Add(minHeartRate);
            summary.Add(avgPower);
            summary.Add(maxPower);
            summary.Add(avgAlt);


            foreach (string val in summary)
            {

                txtSummary.Text = txtSummary.Text + val + Environment.NewLine;

                summary2.Text = summary2.Text + val + Environment.NewLine;


            }


        }
    }
}
