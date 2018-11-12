using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ASE_Assignment.Utils;

namespace ASE_Assignment
{
    public partial class Form1 : Form
    {
        String[] arrays = new String[25];
        List<int> heart = new List<int>();
        List<int> speed = new List<int>();
        List<int> cadence = new List<int>();
        List<int> altitude = new List<int>();
        List<int> power = new List<int>();
        List<int> powerbalance = new List<int>();


        int counter = 0;
        public Form1()
        {
            InitializeComponent();

        }

        public void processfile(String filePath)
        {

            try
            {


                StreamReader sr = new StreamReader(filePath);
                String line = "";
                String newLine = "";

                String cut = sr.ReadLine();

                while (!(line = sr.ReadLine()).Contains("[Note]"))

                {

                    counter++;
                    arrays[counter - 1] = line;
                    
                }

                while (!sr.EndOfStream)
                {
                    if ((line = sr.ReadLine()).Contains("[HRData]"))
                    {


                        while ((newLine = sr.ReadLine()) != null)
                        {
                            ArrayBuilder("    28193  6318  87313  731973 723 5326");
                            //break;
                        }
                    }
                }

            }



            catch (IOException e)
            {
                Console.WriteLine(e);
            }

        }


        public void ArrayBuilder(String line)
        {


            String newline = string.Join(" ", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            

            List<string> parts = newline.Split(' ').ToList();

            heart.Add(int.Parse(parts[0]));
            speed.Add(int.Parse(parts[1]));

            cadence.Add(int.Parse(parts[2]));
            altitude.Add(int.Parse(parts[3]));
            power.Add(int.Parse(parts[4]));
            powerbalance.Add(int.Parse(parts[5]));

            


            parts = null;


        }




        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "HRM|*.hrm|Text Document|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                String filepath = Path.GetFullPath(fd.FileName);
                processfile(filepath);
                TableFiller();
                SummaryFiller();
                
            }

            for (int i = 0; i < arrays.Length; i++)
            {
                add.Text = add.Text + arrays[i] + Environment.NewLine;
            }

        }

        public void TableFiller()
        {
            int counter = 0;
            foreach (int value in heart)
            {
                dataGridView1.Rows.Add(heart[counter], speed[counter], cadence[counter], altitude[counter], power[counter], powerbalance[counter]);
                counter++;
            }

        }
        public void SummaryFiller()
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, cadence, altitude, power);
            String totalDistance = sv.TotalDistance();
            String avgSpeed = sv.AverageSpeed();
            String maxSpeed = sv.MaxSpeed();
            String avgHeartRate = sv.AverageHeartRate();
            String minHeartRate = sv.MinHeartRate();
            String maxHeartRate = sv.MaxHeartRate();
            String avgPower = sv.AveragePower();
            String avgAlt = sv.AverageAltitude();
            String maxAlt = sv.MaxAltitude();

            List<String> summary = new List<String>();
            summary.Add(totalDistance);
            summary.Add(avgSpeed);
            summary.Add(maxSpeed);
            summary.Add(avgHeartRate);
            summary.Add(maxHeartRate);
            summary.Add(minHeartRate);
            summary.Add(avgPower);
            summary.Add(avgAlt);
            summary.Add(maxAlt);

            foreach (String val in summary)
            {

                txtSummary.Text = txtSummary.Text + val + Environment.NewLine;


            }

        }

    }
}
