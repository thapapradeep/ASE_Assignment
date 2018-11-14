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
        List<string> arrays = new List<string>();
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
                    arrays.Add(line);

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
                CreateIndividualGraph();

            }

            foreach (string text in arrays)
            {
                add.Text = add.Text + text + Environment.NewLine;
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
        public void ArrayNuller()
        {
            counter = 0;
            arrays = new List<string>();
            heart = new List<int>();
            speed = new List<int>(); ;
            cadence = new List<int>(); ;
            altitude = new List<int>(); ;
            power = new List<int>(); ;
            powerbalance = new List<int>();


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

        public void buttonDisabler()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            button14.Enabled = true;
            


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

            GraphPane myPane = new GraphPane();
            myPane= zedGraphControl1.GraphPane;
            myPane.Title.Text = "Overall Graph";
            myPane.XAxis.Title.Text = "Time in second";
            myPane.YAxis.Title.Text = "Heart Rate ";
            zedGraphControl1.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;
            

            PointPairList pt = new PointPairList();
            PointPairList pt2 = new PointPairList();
            PointPairList pt3= new PointPairList();
            PointPairList pt1 = new PointPairList();
            PointPairList pt4 = new PointPairList();

            pt = buildPointPairList(heart.ToArray());
             pt1 = buildPointPairList(speed.ToArray());
             pt2 = buildPointPairList(cadence.ToArray());
             pt3 = buildPointPairList(power.ToArray());
            pt4 = buildPointPairList(altitude.ToArray());

           
            LineItem teamACurve = myPane.AddCurve("Heart Rate", pt, Color.Red, SymbolType.None);
            LineItem teamACurve1 = myPane.AddCurve("Speed", pt1, Color.Blue, SymbolType.None);
            LineItem teamACurve2= myPane.AddCurve("Cadence", pt2, Color.Yellow, SymbolType.None);
            LineItem teamACurve3= myPane.AddCurve("Altitude", pt3, Color.Green, SymbolType.None);
            LineItem teamACurve4= myPane.AddCurve("Power", pt4, Color.Pink, SymbolType.None);
            

            


        }

        public void CreateIndividualGraph()
        {

            GraphPane myPane = new GraphPane();
            myPane= graph1.GraphPane;
            myPane.Title.Text = "Graph of HeartRate";
            myPane.XAxis.Title.Text = "Time in second";
            myPane.YAxis.Title.Text = "Reading ";
         
            graph1.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;

            
               PointPairList pt = buildPointPairList(heart.ToArray());
          

            LineItem teamACurve = myPane.AddCurve("Heart Rate", pt, Color.Red, SymbolType.None);
            graph1.AxisChange();

            GraphPane myPane1 = new GraphPane();
             myPane1 = graph2.GraphPane;
            myPane1.Title.Text = "Graph of Speed";
            myPane1.XAxis.Title.Text = "Time in second";
            myPane1.YAxis.Title.Text = "Reading ";
           
            graph6.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt1 = buildPointPairList(speed.ToArray());


            LineItem teamACurve1 = myPane1.AddCurve("Speed", pt1, Color.Red, SymbolType.None);
            graph6.AxisChange();

            GraphPane myPane2 = new GraphPane();
            myPane2 = graph3.GraphPane;
            myPane2.Title.Text = "Graph of Cadence";
            myPane2.XAxis.Title.Text = "Time in second";
            myPane2.YAxis.Title.Text = "Reading ";

            graph3.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt3 = buildPointPairList(cadence.ToArray());


            LineItem teamACurve2 = myPane2.AddCurve("Cadence", pt3, Color.Red, SymbolType.None);
            graph3.AxisChange();

            


            GraphPane myPane3 = new GraphPane();
             myPane3= graph4.GraphPane;
            myPane3.Title.Text = "Graph of Altitude";
            myPane3.XAxis.Title.Text = "Time in second";
            myPane3.YAxis.Title.Text = "Reading ";

            graph4.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt4 = buildPointPairList(altitude.ToArray());


            LineItem teamACurve4 = myPane3.AddCurve("Altitude", pt4, Color.Red, SymbolType.None);
            graph4.AxisChange();

            GraphPane myPane5 = new GraphPane();
             myPane5 = graph5.GraphPane;
            myPane5.Title.Text = "Graph of Powwer";
            myPane5.XAxis.Title.Text = "Time in second";
            myPane5.YAxis.Title.Text = "Reading ";

            graph5.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt5 = buildPointPairList(power.ToArray());


            LineItem teamACurve5 = myPane5.AddCurve("Power", pt5, Color.Red, SymbolType.None);
            graph5.AxisChange();

            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn2.Enabled = false;
            string filepath = "AssignmentData/12072205.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
            

            
         
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn2.Enabled = false;
            string filepath = "AssignmentData/12072301.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
        
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn3.Enabled = false;
            string filepath = "AssignmentData/12072503.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn4.Enabled = false;
            string filepath = "AssignmentData/12080101.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
          ;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn5.Enabled = false;
            string filepath = "AssignmentData/12080301.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
        ;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn6.Enabled = false;
            string filepath = "AssignmentData/12080401.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
         ;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn7.Enabled = false;
            string filepath = "AssignmentData/12080405.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
           
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn8.Enabled = false;
            string filepath = "AssignmentData/12080601.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
           
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn9.Enabled = false;
            string filepath = "AssignmentData/12080701.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filepath = "AssignmentData/12080801.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
            ArrayNuller();
            buttonDisabler();
            button6.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            button1.Enabled = false;
            string filepath = "AssignmentData/12080805.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
           
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn10.Enabled = false;
            string filepath = "AssignmentData/12081001.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
          
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn11.Enabled = false;
            string filepath = "AssignmentData/12081101.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            button14.Enabled = false;
            string filepath = "AssignmentData/12081201.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
            
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            ArrayNuller();
            buttonDisabler();
            btn12.Enabled = false;
            string filepath = "12072205.hrm";
            processfile(filepath);
            TableFiller();
            SummaryFiller();
            createWholeGraph();
            CreateIndividualGraph();
            
        }
    }
    }


