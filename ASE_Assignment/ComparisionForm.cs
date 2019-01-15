using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_Assignment
{
    public partial class ComparisionForm : Form
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


        List<string> arrays1 = new List<string>();
        List<int> heart11 = new List<int>();
        List<double> speed11 = new List<double>();
        List<double> speed_mile11 = new List<double>();

        List<int> cadence11 = new List<int>();
        List<int> altitude11 = new List<int>();
        List<int> power11 = new List<int>();
        List<int> powerbalance11 = new List<int>();
        List<DateTime> dateTime1 = new List<DateTime>();

        int heartCheck = 0;
        int speedCheck = 0;
        int cadenceCheck = 0;
        int altitudeCheck = 0;
        int powerCheck = 0;
        int counter = 0;

        int interval = 0;

        String smode = "";
        String time = "";
        String ntime = "";
        String timee = "";

        String smode1 = "";
        String time1 = "";
        String ntime1 = "";
        String timee1 = "";

        public ComparisionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "HRM|*.hrm|Text Document|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = Path.GetFullPath(fd.FileName);
            }
            }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "HRM|*.hrm|Text Document|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fileName1.Text = Path.GetFullPath(fd.FileName);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            processfile(fileName.Text);
            TableFiller("km/hr");

            processfile1(fileName1.Text);
            TableFiller1("km/hr");


        }

        public void processfile(string filePath)
        {

            try
            {
                Console.WriteLine(fileName.Text);

                // ArrayNuller();
                StreamReader sr = new StreamReader(filePath);
                string line = "";
                string newLine = "";

                string cut = sr.ReadLine();

                while (!(line = sr.ReadLine()).Contains("[Note]"))

                {

                    counter++;
                    arrays.Add(line);

                }
                smode = arrays[2];
                time = arrays[4];

                SMODEChecker(smode.Split('='));

                string[] words = time.Split('=');
                ntime = words[1];

                String time1 = arrays[5];
                string[] timecheck = time1.Split('=');
                timee = timecheck[1];
                while (!sr.EndOfStream)
                {
                    if ((line = sr.ReadLine()).Contains("[HRData]"))
                    {


                        while ((newLine = sr.ReadLine()) != null)
                        {

                            ArrayBuilder(newLine);


                        }
                    }
                }

            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show(exc.ToString());
            }



            catch (IOException e)
            {
                Console.WriteLine(e);
            }

        }

        public void processfile1(string filePath)
        {

            try
            {
                Console.WriteLine(fileName.Text);

                // ArrayNuller();
                StreamReader sr = new StreamReader(filePath);
                string line = "";
                string newLine = "";

                string cut = sr.ReadLine();

                while (!(line = sr.ReadLine()).Contains("[Note]"))

                {

                    counter++;
                    arrays1.Add(line);

                }
                smode1 = arrays[2];
                time = arrays1[4];

                SMODEChecker(smode1.Split('='));

                string[] words = time.Split('=');
                ntime1 = words[1];

                String time1 = arrays1[5];
                string[] timecheck = time1.Split('=');
                timee1 = timecheck[1];
                while (!sr.EndOfStream)
                {
                    if ((line = sr.ReadLine()).Contains("[HRData]"))
                    {


                        while ((newLine = sr.ReadLine()) != null)
                        {

                            ArrayBuilder1(newLine);


                        }
                    }
                }

            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show(exc.ToString());
            }



            catch (IOException e)
            {
                Console.WriteLine(e);
            }

        }

        public void ArrayBuilder(string line)
        {
            try
            {
                int heart11 = 0;
                int speed1 = 0;
                int cadence1 = 0;
                int altitude1 = 0;
                int power1 = 0;
                int powerbal = 0;

                string newline = string.Join(" ", line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries));

                List<string> parts = newline.Split(' ').ToList();
                if (heartCheck == 1)
                {
                    heart11 = int.Parse(parts[0]);
                }
                if (speedCheck == 1)
                {
                    speed1 = int.Parse(parts[1]);
                }
                if (cadenceCheck == 1)
                {
                    cadence1 = int.Parse(parts[2]);
                }
                if (powerCheck == 1)
                {
                    power1 = int.Parse(parts[4]);
                    powerbal = int.Parse(parts[5]);

                }
                if (altitudeCheck == 1)
                {
                    altitude1 = int.Parse(parts[3]);
                }

                heart.Add(heart11);
                speed.Add(speed1 * 0.1);
                speed_mile.Add(speed1 * 0.1 * 0.62);
                cadence.Add(cadence1);
                altitude.Add(altitude1);
                power.Add(power1);
                powerbalance.Add(powerbal);


                parts = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public void ArrayBuilder1(string line)
        {
            try
            {
                int heart1 = 0;
                int speed1 = 0;
                int cadence1 = 0;
                int altitude1 = 0;
                int power1 = 0;
                int powerbal = 0;

                string newline = string.Join(" ", line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries));

                List<string> parts = newline.Split(' ').ToList();
                if (heartCheck == 1)
                {
                    heart1 = int.Parse(parts[0]);
                }
                if (speedCheck == 1)
                {
                    speed1 = int.Parse(parts[1]);
                }
                if (cadenceCheck == 1)
                {
                    cadence1 = int.Parse(parts[2]);
                }
                if (powerCheck == 1)
                {
                    power1 = int.Parse(parts[4]);
                    powerbal = int.Parse(parts[5]);

                }
                if (altitudeCheck == 1)
                {
                    altitude1 = int.Parse(parts[3]);
                }

                heart11.Add(heart1);
                speed11.Add(speed1 * 0.1);
                speed_mile11.Add(speed1 * 0.1 * 0.62);
                cadence11.Add(cadence1);
                altitude11.Add(altitude1);
                power11.Add(power1);
                powerbalance11.Add(powerbal);


                parts = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void SMODEChecker(String[] words)
        {
            string mode = words[1];
            heartCheck = int.Parse(mode.Substring(0, 1));
            speedCheck = int.Parse(mode.Substring(1, 1));
            cadenceCheck = int.Parse(mode.Substring(2, 1));
            altitudeCheck = int.Parse(mode.Substring(3, 1));
            powerCheck = int.Parse(mode.Substring(4, 1));


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
        public void TableFiller(String unit)
        {
            if (unit.Equals("km/hr"))
            {
                int counter = 0;
                foreach (int value in heart)
                {
                    
                    dataGridView1.Rows.Add(heart[counter] + " bpm", speed[counter] + " km/hr", cadence[counter] + " rpm", altitude[counter] + " m/ft", power[counter] + " watt", powerbalance[counter], timeBuilder(ntime));
                    counter++;
                    interval++;
                }
            }


        }

        public void TableFiller1(String unit)
        {
            if (unit.Equals("km/hr"))
            {
                int counter = 0;
                foreach (int value in heart)
                {
                    dataGridView2.Rows.Add(heart11[counter] + " bpm", speed11[counter] + " km/hr", cadence11[counter] + " rpm", altitude11[counter] + " m/ft", power11[counter] + " watt", powerbalance11[counter], timeBuilder(ntime1));
                   
                    counter++;
                    interval++;
                }
            }


        }

        private void ComparisionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
