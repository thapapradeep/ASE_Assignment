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
using System.Text.RegularExpressions;
using System.Globalization;

namespace ASE_Assignment
{
    public partial class Form1 : Form
    {
        //Necesssary Global Variables Declaration
        List<string> arrays = new List<string>();
        List<int> heart = new List<int>();
        List<double> speed = new List<double>();
        List<double> speed_mile = new List<double>();

        List<int> cadence = new List<int>();
        List<int> altitude = new List<int>();
        List<int> power = new List<int>();
        List<int> powerbalance = new List<int>();
        List<DateTime> dateTime = new List<DateTime>();

        string time = "";
        String smode = "";
        int heartCheck = 0;
        int speedCheck = 0;
        int cadenceCheck = 0;
        int altitudeCheck = 0;
        int powerCheck = 0;
        string timee = "";
        string ntime = "";


        int interval = 0;



        int counter = 0;

        public Form1()
        {

            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();

        }



        // Method to process the file and read the header and data from file
        public void processfile(string filePath)
        {

            try
            {

                ArrayNuller();
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

        //Method that builds array according to the smode
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




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "HRM|*.hrm|Text Document|*.txt";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    ArrayNuller();
                    string filepath = Path.GetFullPath(fd.FileName);
                    processfile(filepath);
                    TableFiller("km/hr");
                    SummaryFiller("km/hr");
                    createWholeGraph();
                    CreateIndividualGraph();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }




        }

        //Method to populate the data grid view according to the unit of speed 
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
            else if (unit.Equals("miles/hr"))
            {
                int counter = 0;
                foreach (int value in heart)
                {
                    dataGridView1.Rows.Add(heart[counter] + " bpm", speed_mile[counter] + " miles/hr", cadence[counter] + " rpm", altitude[counter] + " m/ft", power[counter] + " watt", powerbalance[counter], timeBuilder(ntime));
                    counter++;
                    interval++;
                }


            }
            foreach (string text in arrays)
            {
                add.Text = add.Text + text + Environment.NewLine;
            }

        }

        //method to fetch the calculations from summary class and fill the text area
        public void SummaryFiller(String unit)
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, speed_mile, cadence, altitude, power, timee);
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

            if (unit.Equals("km/hr"))
            {
                List<string> summary = new List<string>();
                summary.Add(totalDistanceKm);
                summary.Add(avgSpeed);
                summary.Add(maxSpeed);
                summary.Add(avgHeartRate);
                summary.Add(maxHeartRate);
                summary.Add(minHeartRate);
                summary.Add(avgPower);
                summary.Add(avgAlt);
                summary.Add(maxPower);
                summary.Add(avgAlt);

                foreach (string val in summary)
                {

                    txtSummary.Text = txtSummary.Text + val + Environment.NewLine;

                    summary2.Text = summary2.Text + val + Environment.NewLine;


                }
                foreach (string val in summary)
                {


                    summary2.Text = summary2.Text + val + Environment.NewLine;

                }


            }
            else if (unit.Equals("miles/hr"))
            {
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
                foreach (string val in summary)
                {



                    summary2.Text = summary2.Text + val + Environment.NewLine;



                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        //Method to re instiantiate all global variables to make them ready for anotherfile
        public void ArrayNuller()
        {
            counter = 0;
            interval = 0;
            add.Text = "";
            smode = "";
            timee = "";
            time = "";
            ntime = "";
            txtSummary.Text = "";
            summary2.Text = "";
            arrays = new List<string>();
            heart = new List<int>();
            speed = new List<double>();
            speed_mile = new List<double>();
            cadence = new List<int>();
            altitude = new List<int>();
            power = new List<int>(); ;
            powerbalance = new List<int>();
            heartCheck = 0;
            speedCheck = 0;
            cadenceCheck = 0;
            altitudeCheck = 0;
            powerCheck = 0;


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

            zedGraphControl1.AxisChange();
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.Invalidate();

            graph1.AxisChange();
            graph1.GraphPane.CurveList.Clear();
            graph1.Invalidate();

            graph6.AxisChange();
            graph6.GraphPane.CurveList.Clear();
            graph6.Invalidate();

            graph3.AxisChange();
            graph3.GraphPane.CurveList.Clear();
            graph3.Invalidate();

            graph4.AxisChange();
            graph4.GraphPane.CurveList.Clear();
            graph4.Invalidate();

            graph5.AxisChange();
            graph5.GraphPane.CurveList.Clear();
            graph5.Invalidate();




        }

        public void NullerSelectableInfo()
        {
            counter = 0;
            interval = 0;
            add.Text = "";

            txtSummary.Text = "";
            summary2.Text = "";

            heart = new List<int>();
            speed = new List<double>();
            speed_mile = new List<double>();
            cadence = new List<int>();
            altitude = new List<int>();
            power = new List<int>(); ;
            powerbalance = new List<int>();
            heartCheck = 0;
            speedCheck = 0;
            cadenceCheck = 0;
            altitudeCheck = 0;
            powerCheck = 0;


        
            zedGraphControl1.AxisChange();
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.Invalidate();

            graph1.AxisChange();
            graph1.GraphPane.CurveList.Clear();
            graph1.Invalidate();

            graph6.AxisChange();
            graph6.GraphPane.CurveList.Clear();
            graph6.Invalidate();

            graph3.AxisChange();
            graph3.GraphPane.CurveList.Clear();
            graph3.Invalidate();

            graph4.AxisChange();
            graph4.GraphPane.CurveList.Clear();
            graph4.Invalidate();

            graph5.AxisChange();
            graph5.GraphPane.CurveList.Clear();
            graph5.Invalidate();




        }


        // Method to build pointpair list according to time interval and data
        private PointPairList buildPointPairList(int[] data)
        {
            PointPairList pt = new ZedGraph.PointPairList();

            for (int counter = 0; counter < data.Length; counter++)
            {
                pt.Add(counter, (data[counter]));
            }
            return pt;

        }
        private PointPairList buildPointPairList(double[] data)
        {
            PointPairList pt = new ZedGraph.PointPairList();

            for (int counter = 0; counter < data.Length; counter++)
            {
                pt.Add(counter, (data[counter]));
            }
            return pt;

        }


        //Method to create combined graph
        private void createWholeGraph()
        {

            GraphPane myPane = new GraphPane();
            myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Overall Graph";
            myPane.XAxis.Title.Text = "Time in second";
            myPane.YAxis.Title.Text = "Heart Rate ";
            zedGraphControl1.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt = new PointPairList();
            PointPairList pt2 = new PointPairList();
            PointPairList pt3 = new PointPairList();
            PointPairList pt1 = new PointPairList();
            PointPairList pt4 = new PointPairList();

            pt = buildPointPairList(heart.ToArray());
            pt1 = buildPointPairList(speed.ToArray());
            pt2 = buildPointPairList(cadence.ToArray());
            pt3 = buildPointPairList(power.ToArray());
            pt4 = buildPointPairList(altitude.ToArray());


            LineItem teamACurve = myPane.AddCurve("Heart Rate", pt, Color.Red, SymbolType.None);
            LineItem teamACurve1 = myPane.AddCurve("Speed", pt1, Color.Blue, SymbolType.None);
            LineItem teamACurve2 = myPane.AddCurve("Cadence", pt2, Color.Yellow, SymbolType.None);
            LineItem teamACurve3 = myPane.AddCurve("Altitude", pt3, Color.Green, SymbolType.None);
            LineItem teamACurve4 = myPane.AddCurve("Power", pt4, Color.Pink, SymbolType.None);

            zedGraphControl1.AxisChange();


        }


        //Method to create individual graphs of all parameters
        public void CreateIndividualGraph()
        {

            GraphPane myPane = new GraphPane();
            myPane = graph1.GraphPane;
            myPane.Title.Text = "Graph of HeartRate";
            myPane.XAxis.Title.Text = "Time in second";
            myPane.YAxis.Title.Text = "Reading ";

            graph1.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt = buildPointPairList(heart.ToArray());


            LineItem teamACurve = myPane.AddCurve("Heart Rate", pt, Color.Red, SymbolType.None);
            graph1.AxisChange();

            GraphPane myPane1 = new GraphPane();
            myPane1 = graph4.GraphPane;
            myPane1.Title.Text = "Graph of Speed";
            myPane1.XAxis.Title.Text = "Time in second";
            myPane1.YAxis.Title.Text = "Reading ";

            graph4.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt1 = buildPointPairList(speed.ToArray());


            LineItem teamACurve1 = myPane1.AddCurve("Speed", pt1, Color.Blue, SymbolType.None);
            graph4.AxisChange();

            GraphPane myPane2 = new GraphPane();
            myPane2 = graph3.GraphPane;
            myPane2.Title.Text = "Graph of Cadence";
            myPane2.XAxis.Title.Text = "Time in second";
            myPane2.YAxis.Title.Text = "Reading ";

            graph3.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt3 = buildPointPairList(cadence.ToArray());


            LineItem teamACurve2 = myPane2.AddCurve("Cadence", pt3, Color.Yellow, SymbolType.None);
            graph3.AxisChange();

            GraphPane myPane3 = new GraphPane();
            myPane3 = graph6.GraphPane;
            myPane3.Title.Text = "Graph of Altitude";
            myPane3.XAxis.Title.Text = "Time in second";
            myPane3.YAxis.Title.Text = "Reading ";

            graph6.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt4 = buildPointPairList(altitude.ToArray());


            LineItem teamACurve4 = myPane3.AddCurve("Altitude", pt4, Color.Green, SymbolType.None);
            graph6.AxisChange();

            GraphPane myPane5 = new GraphPane();
            myPane5 = graph5.GraphPane;
            myPane5.Title.Text = "Graph of Power";
            myPane5.XAxis.Title.Text = "Time in second";
            myPane5.YAxis.Title.Text = "Reading ";

            graph5.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt5 = buildPointPairList(power.ToArray());


            LineItem teamACurve5 = myPane5.AddCurve("Power", pt5, Color.Pink, SymbolType.None);
            graph5.AxisChange();


        }


        //Event when unit if speed is selected
        private void btn_re_Click(object sender, EventArgs e)
        {


            string unit = "";

            if (cmb_unit.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Correct Information");
            }
            else
            {
                unit = cmb_unit.Text;


                if (unit.Equals("km/hr"))
                {
                    txtSummary.Text = "";
                    summary2.Text = "";
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

                    zedGraphControl1.AxisChange();
                    zedGraphControl1.GraphPane.CurveList.Clear();
                    zedGraphControl1.Invalidate();

                    graph1.AxisChange();
                    graph1.GraphPane.CurveList.Clear();
                    graph1.Invalidate();

                    graph6.AxisChange();
                    graph6.GraphPane.CurveList.Clear();
                    graph6.Invalidate();

                    graph3.AxisChange();
                    graph3.GraphPane.CurveList.Clear();
                    graph3.Invalidate();

                    graph4.AxisChange();
                    graph4.GraphPane.CurveList.Clear();
                    graph4.Invalidate();

                    graph5.AxisChange();
                    graph5.GraphPane.CurveList.Clear();
                    graph5.Invalidate();

                    interval = 0;

                    TableFiller("km/hr");
                    SummaryFiller("km/hr");
                    createWholeGraph();
                    CreateIndividualGraph();

                }
                else if (unit.Equals("miles/hr"))
                {
                    txtSummary.Text = "";
                    summary2.Text = "";
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

                    zedGraphControl1.AxisChange();
                    zedGraphControl1.GraphPane.CurveList.Clear();
                    zedGraphControl1.Invalidate();

                    graph1.AxisChange();
                    graph1.GraphPane.CurveList.Clear();
                    graph1.Invalidate();

                    graph6.AxisChange();
                    graph6.GraphPane.CurveList.Clear();
                    graph6.Invalidate();

                    graph3.AxisChange();
                    graph3.GraphPane.CurveList.Clear();
                    graph3.Invalidate();

                    graph4.AxisChange();
                    graph4.GraphPane.CurveList.Clear();
                    graph4.Invalidate();

                    graph5.AxisChange();
                    graph5.GraphPane.CurveList.Clear();
                    graph5.Invalidate();
                    interval = 0;

                    TableFiller("miles/hr");
                    SummaryFiller("miles/hr");
                    createWholeGraph();
                    CreateIndividualGraph();
                }
            }


        }

        //Method to check the smode 
        private void SMODEChecker(String[] words)
        {
            string mode = words[1];
            heartCheck = int.Parse(mode.Substring(0, 1));
            speedCheck = int.Parse(mode.Substring(1, 1));
            cadenceCheck = int.Parse(mode.Substring(2, 1));
            altitudeCheck = int.Parse(mode.Substring(3, 1));
            powerCheck = int.Parse(mode.Substring(4, 1));


        }


        //Method to Create increasing time alongside the parameters
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

        private void View_Click(object sender, EventArgs e)
        {
             Console.WriteLine(dataGridView1.SelectedRows.Count + "  " + dataGridView1.SelectedColumns.Count);
            if (dataGridView1.SelectedRows.Count < 1 && dataGridView1.SelectedColumns.Count < 6)
            {
                MessageBox.Show("Please select at least one row and more than 5 columns");
            }
            else
            {
                NullerSelectableInfo();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    String[] word1 = row.Cells[0].Value.ToString().Split(' ');
                    heart.Add(int.Parse(word1[0]));
                    Console.WriteLine(row.Cells[0].Value.ToString());

                   String[] word2 = row.Cells[1].Value.ToString().Split(' ');

                     speed.Add(double.Parse(word2[0]));
                    speed_mile.Add(double.Parse(word2[0]) * 0.62);

                     String[] word3 = row.Cells[2].Value.ToString().Split(' ');
                     cadence.Add(int.Parse(word3[0]));

                     String[] word4 = row.Cells[3].Value.ToString().Split(' ');
                     altitude.Add(int.Parse(word4[0]));

                     String[] word5 = row.Cells[4].Value.ToString().Split(' ');
                     Console.WriteLine(word5[0]);
                     power.Add(int.Parse(word5[0]));

                    // String word6 = row.Cells[4].Value.ToString(); 
                     powerbalance.Add(0); 


                     Console.WriteLine(word1[0]+"  "+word1[1]);


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
                SummaryFiller("km/hr");
                createWholeGraph();
                CreateIndividualGraph();
                




                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            ComparisionForm cf = new ComparisionForm();
            cf.Show();
        }
    }
    }




