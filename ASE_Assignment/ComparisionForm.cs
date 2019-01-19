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
using ASE_Assignment.Utils;
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

            SummaryFiller();

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

        public void SummaryFiller()
        {
            SummaryCalculator sv = new SummaryCalculator(heart, speed, speed_mile, cadence, altitude, power, timee);
            string[] stotalDistanceKm = sv.TotalDistance().Split('=');
            String totalDistanceKm = stotalDistanceKm[1];

            string[] stotalMile = sv.TotalDistanceMile().Split('=');
            String totalMile = stotalMile[1];
            string[] savgSpeed = sv.AverageSpeed().Split('=');
            String avgSpeed = savgSpeed[1];
            string[] smaxSpeed = sv.MaxSpeed().Split('=');
            string maxSpeed = smaxSpeed[1];
            string[] savgSpeedMile = sv.AverageSpeedMile().Split('=');
            string avgSpeedMile = savgSpeedMile[1];
            string[] smaxSpeedMile = sv.MaxSpeedMile().Split('=');
            string maxSpeedMile = smaxSpeedMile[1];
            string[] savgHeartRate = sv.AverageHeartRate().Split('=');
            string avgHeartRate = savgHeartRate[1];
            string[] sminHeartRate = sv.MinHeartRate().Split('=');
            string minHeartRate = sminHeartRate[1];
            string[] smaxHeartRate = sv.MaxHeartRate().Split('=');
            string maxHeartRate = smaxHeartRate[1];
            string[] savgPower = sv.AveragePower().Split('=');
            string avgPower = savgPower[1];
            string[] savgAlt = sv.AverageAltitude().Split('=');
            string avgAlt = savgAlt[1];
            string[] smaxPower = sv.maxPower().Split('=');
            string maxPower = smaxPower[1];
            string ftp = sv.CalculateFTP();
            string[] norm1 = sv.CalculateNP().Split('=');
            string Np1 = norm1[1];
            string[] sIF1 = sv.CalculateIF().Split('=');
            string IF1 = sIF1[1];
            string[] sTss1 = sv.CalculateTSS().Split('=');
            string Tss1 = sTss1[1];
           
            dataGridView3.Rows.Add(totalDistanceKm, avgSpeed, maxSpeed, avgHeartRate, maxHeartRate, minHeartRate, avgPower, maxPower, avgAlt, IF1, Tss1, Np1);



            SummaryCalculator sv1 = new SummaryCalculator(heart11, speed11, speed_mile11, cadence11, altitude11, power11, timee1);
            string[] stotalDistanceKm1 = sv1.TotalDistance().Split('=');
            String totalDistanceKm1 = stotalDistanceKm[1];

            string[] stotalMile1 = sv1.TotalDistanceMile().Split('=');
            String totalMile1 = stotalMile1[1];
            string[] savgSpeed1 = sv1.AverageSpeed().Split('=');
            String avgSpeed1 = savgSpeed1[1];
            string[] smaxSpeed1 = sv1.MaxSpeed().Split('=');
            string maxSpeed1 = smaxSpeed1[1];
            string[] savgSpeedMile1 = sv1.AverageSpeedMile().Split('=');
            string avgSpeedMile1 = savgSpeedMile1[1];
            string[] smaxSpeedMile1 = sv1.MaxSpeedMile().Split('=');
            string maxSpeedMile1 = smaxSpeedMile1[1];
            string[] savgHeartRate1 = sv1.AverageHeartRate().Split('=');
            string avgHeartRate1 = savgHeartRate1[1];
            string[] sminHeartRate1 = sv1.MinHeartRate().Split('=');
            string minHeartRate1 = sminHeartRate1[1];
            string[] smaxHeartRate1 = sv1.MaxHeartRate().Split('=');
            string maxHeartRate1 = smaxHeartRate1[1];
            string[] savgPower1 = sv1.AveragePower().Split('=');
            string avgPower1 = savgPower1[1];
            string[] savgAlt1 = sv1.AverageAltitude().Split('=');
            string avgAlt1 = savgAlt1[1];
            string[] smaxPower1 = sv1.maxPower().Split('=');
            string maxPower1 = smaxPower1[1];
                string ftp1 = sv1.CalculateFTP();
            string[] norm = sv1.CalculateNP().Split('=');
            Console.WriteLine(sv1.CalculateTSS());
            string Np = norm[1];
            string[] sIF= sv1.CalculateIF().Split('=');
            string IF = sIF[1];

            string[] sTss = sv1.CalculateTSS().Split('=');
            string Tss = sTss[1];
            





            dataGridView4.Rows.Add(totalDistanceKm1, avgSpeed1, maxSpeed1, avgHeartRate1, maxHeartRate1, minHeartRate1, avgPower1, maxPower1, avgAlt1, IF, Tss, Np);
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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4.Rows[e.RowIndex].Selected = false;
            dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            String value = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            string newline = string.Join(" ", value.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine(value);

            String[] values = newline.Split(' ');
            Console.WriteLine(values[0]);
            double parameter = double.Parse(values[0]);


            String value1 = dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Console.WriteLine(value + "  " + value1);

            String[] values1 = value1.Split(' ');

            Console.WriteLine(values1[0]);
            double parameter1 = double.Parse(values1[0]);
            double result = parameter - parameter1;
            String status = "";
            if (result < 0)
            {
                status = "The result is - 'Negative' ";
            }
            else
            {
                status = "The result is + 'Positive'";
            }

            String header = dataGridView3.Columns[e.ColumnIndex].HeaderText;

            txt_summaryLog.Text = header + "Of First File=" + parameter + Environment.NewLine + header + "Of Second File=" + parameter1 + Environment.NewLine + "Difference is: " + parameter + "-" + parameter1 + "=" + result + Environment.NewLine + status;



        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Single row at a time");
            }
            else
            {
                String[] heartRate = null;
                String[] speed = null;
                String[] cadence = null;
                String[] altitude = null;
                String[] power = null;
                String[] powerBalance = null;

                String[] heartRate1 = null;
                String[] speed1 = null;
                String[] cadence1 = null;
                String[] altitude1 = null;
                String[] power1 = null;
                String[] powerBalance1 = null;

                dataGridView2.ClearSelection();
                dataGridView2.Rows[e.RowIndex].Selected = true;




                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    heartRate = row.Cells[0].Value.ToString().Split(' ');
                    speed = row.Cells[1].Value.ToString().Split(' ');
                    cadence = row.Cells[2].Value.ToString().Split(' ');
                    altitude = row.Cells[3].Value.ToString().Split(' ');
                    power = row.Cells[4].Value.ToString().Split(' ');
                    powerBalance = row.Cells[5].Value.ToString().Split(' ');

                 
                }

                foreach(DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    heartRate1 = row.Cells[0].Value.ToString().Split(' ');
                    speed1 = row.Cells[1].Value.ToString().Split(' ');
                    cadence1 = row.Cells[2].Value.ToString().Split(' ');
                    altitude1 = row.Cells[3].Value.ToString().Split(' ');
                    power1 = row.Cells[4].Value.ToString().Split(' ');
                    powerBalance1 = row.Cells[5].Value.ToString().Split(' ');

                    

                }
                

                double h_num = double.Parse(heartRate[0]);
                double s_num = double.Parse(speed[0]);
                double c_num = double.Parse(cadence[0]);
                double a_num = double.Parse(altitude[0]);
                double p_num = double.Parse(power[0]);
                double po_num = double.Parse(powerBalance[0]);

                double h_num1 = double.Parse(heartRate1[0]);
                double s_num1 = double.Parse(speed1[0]);
                double c_num1 = double.Parse(cadence1[0]);
                double a_num1 = double.Parse(altitude1[0]);
                double p_num1 = double.Parse(power1[0]);
                double po_num1 = double.Parse(powerBalance1[0]);

                //String header=dataGridView2=
                textBox1.Text = "Difference in Heart Rate:" + h_num + "-" + h_num1+"=" + DifferenceCalculator(h_num, h_num1)+
                    Environment.NewLine+ "Difference in Speed:" + s_num + "-" + s_num1 + "=" + DifferenceCalculator(s_num, s_num1)+
                    Environment.NewLine + "Difference in Cadence:" + c_num + "-" + c_num1 + "=" + DifferenceCalculator(c_num, c_num1) +
                    Environment.NewLine + "Difference in Altitude:" + a_num + "-" + a_num1 + "=" + DifferenceCalculator(a_num, a_num1) +
                    Environment.NewLine + "Difference in Power:" + p_num + "-" + p_num1 + "=" + DifferenceCalculator(p_num, p_num1)+
                    Environment.NewLine + "Difference in Power Balance:" + po_num + "-" + po_num1 + "=" + DifferenceCalculator(po_num, po_num1)+
                    Environment.NewLine;


            }
        }
        private String DifferenceCalculator(double num1, double num2)
        {
            String status="";
            double result = num1 - num2;
            if (result<0)
            {
                status = "negative";
            }
            else
            {
                status = "positive";
            }
            return result +  "  (" + status + ")";
        }
    }
}
