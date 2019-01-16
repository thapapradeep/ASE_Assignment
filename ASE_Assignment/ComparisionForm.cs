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
using ZedGraph;

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

            createWholeGraph();
            CreateIndividualGraph();


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
                int counter1 = 0;
                foreach (int value in heart)
                {
                    dataGridView2.Rows.Add(heart11[counter] + " bpm", speed11[counter] + " km/hr", cadence11[counter] + " rpm", altitude11[counter] + " m/ft", power11[counter] + " watt", powerbalance11[counter], timeBuilder(ntime1));
                   
                    counter1++;
                    interval++;
                }
            }


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
        private PointPairList buildPointPairList(double[] data)
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
            GraphPane myPane1 = new GraphPane();
            myPane = zedGraphControl1.GraphPane;
            myPane1 = zedGraphControl2.GraphPane;
            myPane.Title.Text = "Overall Graph of First File";
            myPane.XAxis.Title.Text = "Time in second";
            myPane.YAxis.Title.Text = "Heart Rate ";

            myPane1.Title.Text = "Overall Graph of Second File";
            myPane1.XAxis.Title.Text = "Time in second";
            myPane1.YAxis.Title.Text = "Parameters ";
            zedGraphControl2.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt = new PointPairList();
            PointPairList pt2 = new PointPairList();
            PointPairList pt3 = new PointPairList();
            PointPairList pt1 = new PointPairList();
            PointPairList pt4 = new PointPairList();

            PointPairList pt5 = new PointPairList();
            PointPairList pt6 = new PointPairList();
            PointPairList pt7 = new PointPairList();
            PointPairList pt8 = new PointPairList();
            PointPairList pt9 = new PointPairList();



            pt = buildPointPairList(heart.ToArray());
            pt1 = buildPointPairList(speed.ToArray());
            pt2 = buildPointPairList(cadence.ToArray());
            pt3 = buildPointPairList(power.ToArray());
            pt4 = buildPointPairList(altitude.ToArray());



            pt5 = buildPointPairList(heart11.ToArray());
            pt6 = buildPointPairList(speed11.ToArray());
            pt7 = buildPointPairList(cadence11.ToArray());
            pt8 = buildPointPairList(power11.ToArray());
            pt9 = buildPointPairList(altitude11.ToArray());


            LineItem teamACurve = myPane.AddCurve("Heart Rate", pt, Color.Red, SymbolType.None);
            LineItem teamACurve1 = myPane.AddCurve("Speed", pt1, Color.Blue, SymbolType.None);
            LineItem teamACurve2 = myPane.AddCurve("Cadence", pt2, Color.Yellow, SymbolType.None);
            LineItem teamACurve3 = myPane.AddCurve("Altitude", pt3, Color.Green, SymbolType.None);
            LineItem teamACurve4 = myPane.AddCurve("Power", pt4, Color.Pink, SymbolType.None);


            LineItem teamACurve5 = myPane1.AddCurve("Heart Rate", pt5, Color.Red, SymbolType.None);
            LineItem teamACurve6 = myPane1.AddCurve("Speed", pt6, Color.Blue, SymbolType.None);
            LineItem teamACurve7 = myPane1.AddCurve("Cadence", pt7, Color.Yellow, SymbolType.None);
            LineItem teamACurve8 = myPane1.AddCurve("Altitude", pt8, Color.Green, SymbolType.None);
            LineItem teamACurve9 = myPane1.AddCurve("Power", pt9, Color.Pink, SymbolType.None);

            zedGraphControl1.AxisChange();
            zedGraphControl2.AxisChange();

        }

        public void CreateIndividualGraph()
        {

            GraphPane myPane = new GraphPane();
            myPane = zedGraphControl3.GraphPane;
            myPane.Title.Text = "Graph of HeartRate";
            myPane.XAxis.Title.Text = "Time in second";
            myPane.YAxis.Title.Text = "Reading ";

           zedGraphControl3.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt = buildPointPairList(heart.ToArray());


            LineItem teamACurve = myPane.AddCurve("Heart Rate", pt, Color.Red, SymbolType.None);
            zedGraphControl3.AxisChange();

            GraphPane myPane1 = new GraphPane();
            myPane1 = zedGraphControl4.GraphPane;
            myPane1.Title.Text = "Graph of Speed";
            myPane1.XAxis.Title.Text = "Time in second";
            myPane1.YAxis.Title.Text = "Reading ";

          zedGraphControl4.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt1 = buildPointPairList(speed.ToArray());


            LineItem teamACurve1 = myPane1.AddCurve("Speed", pt1, Color.Blue, SymbolType.None);
            zedGraphControl4.AxisChange();

            GraphPane myPane2 = new GraphPane();
            myPane2 = zedGraphControl5.GraphPane;
            myPane2.Title.Text = "Graph of Cadence";
            myPane2.XAxis.Title.Text = "Time in second";
            myPane2.YAxis.Title.Text = "Reading ";

         zedGraphControl5.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt3 = buildPointPairList(cadence.ToArray());


            LineItem teamACurve2 = myPane2.AddCurve("Cadence", pt3, Color.Yellow, SymbolType.None);
         zedGraphControl5.AxisChange();

            GraphPane myPane3 = new GraphPane();
            myPane3 = zedGraphControl6.GraphPane;
            myPane3.Title.Text = "Graph of Altitude";
            myPane3.XAxis.Title.Text = "Time in second";
            myPane3.YAxis.Title.Text = "Reading ";

            zedGraphControl6.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt4 = buildPointPairList(altitude.ToArray());


            LineItem teamACurve4 = myPane3.AddCurve("Altitude", pt4, Color.Green, SymbolType.None);
            zedGraphControl6.AxisChange();

            GraphPane myPane5 = new GraphPane();
            myPane5 = zedGraphControl7.GraphPane;
            myPane5.Title.Text = "Graph of Power";
            myPane5.XAxis.Title.Text = "Time in second";
            myPane5.YAxis.Title.Text = "Reading ";

            zedGraphControl7.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt5 = buildPointPairList(power.ToArray());


            LineItem teamACurve5 = myPane5.AddCurve("Power", pt5, Color.Pink, SymbolType.None);
            zedGraphControl7.AxisChange();



            GraphPane myPane6 = new GraphPane();
            myPane5 = zedGraphControl8.GraphPane;
            myPane5.Title.Text = "Graph of Heart Rate";
            myPane5.XAxis.Title.Text = "Time in second";
            myPane5.YAxis.Title.Text = "Reading ";

            zedGraphControl7.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt6 = buildPointPairList(heart11.ToArray());


            LineItem teamACurve6 = myPane5.AddCurve("Heart", pt6, Color.Red, SymbolType.None);
            zedGraphControl8.AxisChange();


            GraphPane myPane7 = new GraphPane();
            myPane1 = zedGraphControl9.GraphPane;
            myPane1.Title.Text = "Graph of Speed";
            myPane1.XAxis.Title.Text = "Time in second";
            myPane1.YAxis.Title.Text = "Reading ";

            zedGraphControl9.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt7 = buildPointPairList(speed11.ToArray());


            LineItem teamACurve7 = myPane1.AddCurve("Speed", pt7, Color.Blue, SymbolType.None);
            zedGraphControl9.AxisChange();


            GraphPane myPane8 = new GraphPane();
            myPane2 = zedGraphControl10.GraphPane;
            myPane2.Title.Text = "Graph of Cadence";
            myPane2.XAxis.Title.Text = "Time in second";
            myPane2.YAxis.Title.Text = "Reading ";

            zedGraphControl5.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt8 = buildPointPairList(cadence11.ToArray());


            LineItem teamACurve8 = myPane2.AddCurve("Cadence", pt8, Color.Yellow, SymbolType.None);
            zedGraphControl10.AxisChange();

            GraphPane myPane9 = new GraphPane();
            myPane2 = zedGraphControl11.GraphPane;
            myPane2.Title.Text = "Graph of Altitude";
            myPane2.XAxis.Title.Text = "Time in second";
            myPane2.YAxis.Title.Text = "Reading ";

            zedGraphControl5.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt9 = buildPointPairList(altitude11.ToArray());


            LineItem teamACurve9 = myPane2.AddCurve("Altitude", pt9, Color.Green, SymbolType.None);
            zedGraphControl11.AxisChange();


            GraphPane myPane10 = new GraphPane();
            myPane5 = zedGraphControl12.GraphPane;
            myPane5.Title.Text = "Graph of Power";
            myPane5.XAxis.Title.Text = "Time in second";
            myPane5.YAxis.Title.Text = "Reading ";

            zedGraphControl7.GraphPane.Chart.Fill.Color = System.Drawing.Color.Black;


            PointPairList pt11 = buildPointPairList(power11.ToArray());


            LineItem teamACurve10 = myPane5.AddCurve("Power", pt5, Color.Pink, SymbolType.None);
            zedGraphControl12.AxisChange();

        }

        private void ComparisionForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
