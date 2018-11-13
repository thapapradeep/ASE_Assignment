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
using ZedGraph;

namespace ASE_Assignment
{
    public partial class Form1 : Form
    {
        string[] arrays = new string[25];
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

        public void processfile(string filePath)
        {

            try
            {


                StreamReader sr = new StreamReader(filePath);
                string line = "";
                string newLine = "";

                string cut = sr.ReadLine();

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
                            //ArrayBuilder("100    5732   77213  62763  67323   57233");
                            ArrayBuilder(newLine);
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


        public void ArrayBuilder(string line)
        {


            string newline = string.Join(" ", line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries));

            //string[] parts = newline.Split(' ');

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
                string filepath = Path.GetFullPath(fd.FileName);
                processfile(filepath);
                TableFiller();
                SummaryFiller();
                createWholeGraph();

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
            string totalDistance = sv.TotalDistance();
            string avgSpeed = sv.AverageSpeed();
            string maxSpeed = sv.MaxSpeed();
            string avgHeartRate = sv.AverageHeartRate();
            string minHeartRate = sv.MinHeartRate();
            string maxHeartRate = sv.MaxHeartRate();
            string avgPower = sv.AveragePower();
            string avgAlt = sv.AverageAltitude();
            string maxAlt = sv.MaxAltitude();

            List<string> summary = new List<string>();
            summary.Add(totalDistance);
            summary.Add(avgSpeed);
            summary.Add(maxSpeed);
            summary.Add(avgHeartRate);
            summary.Add(maxHeartRate);
            summary.Add(minHeartRate);
            summary.Add(avgPower);
            summary.Add(avgAlt);
            summary.Add(maxAlt);

            foreach (string val in summary)
            {

                txtSummary.Text = txtSummary.Text + val + Environment.NewLine;


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private PointPairList buildPointPairList(int[] data)
        {
            PointPairList pt = new ZedGraph.PointPairList();

            for (int counter = 0; counter < data.Length; counter++)
            {
                pt.Add(counter, (data[counter]));
            }
            return pt;

        }

        private void createWholeGraph()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Overall Graph";
            myPane.XAxis.Title.Text = "Time in second";
            myPane.YAxis.Title.Text = "Heart Rate ";
            zedGraphControl1.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;
            

            PointPairList pt = buildPointPairList(heart.ToArray());
            PointPairList pt1 = buildPointPairList(speed.ToArray());
            PointPairList pt2 = buildPointPairList(cadence.ToArray());
            PointPairList pt3 = buildPointPairList(power.ToArray());
            PointPairList pt4 = buildPointPairList(altitude.ToArray());


            LineItem teamACurve = myPane.AddCurve("Heart Rate", pt, Color.Red, SymbolType.None);
            LineItem teamACurve1 = myPane.AddCurve("Speed", pt1, Color.Blue, SymbolType.None);
            LineItem teamACurve2= myPane.AddCurve("Cadence", pt2, Color.Yellow, SymbolType.None);
            LineItem teamACurve3= myPane.AddCurve("Altitude", pt3, Color.Green, SymbolType.None);
            LineItem teamACurve4= myPane.AddCurve("Power", pt4, Color.Pink, SymbolType.None);
            

            zedGraphControl1.AxisChange();


        }
    }
}

