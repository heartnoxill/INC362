using System.Diagnostics;

namespace DataGenerationProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //GenerateRandomBooleanData(20);
            //GenerateRandomIntegerData(-1, 1, 20);
            //GenerateRandomRealNumberData(4, 120, 50);
        }

        //** Instance of Random Class
        Random random = new Random();

        //**********************************************************
        //** 1) Boolean Data Generation
        //**********************************************************

        //** Returns a boolean data
        private bool GetRandomBooleanData()
        {
            return random.Next() % 2 > 0;
        }


        //** Returns an array of boolean data
        private bool[] GenerateRandomBooleanData(int items)
        {
            bool[] data = new bool[items];
            for(int i = 0; i < items; i++)
            {
                data[i] = GetRandomBooleanData();
                Debug.WriteLine($"data[{i}]: {data[i]}");
            }
            return data;
        }



        //**********************************************************
        //** 2) Integer Data Generation
        //**********************************************************

        //** Returns an integer between min and max
        private int GetRandomIntegerData(int min, int max)
        {
            return min + random.Next() % (max - min + 1);
        }

        //** Returns an array of integers between min and max
        private int[] GenerateRandomIntegerData(int min, int max, int items)
        {
            int[] data = new int[items];
            for (int i = 0; i < items; i++)
            {
                data[i] = GetRandomIntegerData(min, max);
                Debug.WriteLine($"data[{i}]: {data[i]}");
            }
            return data;
        }


        //**********************************************************
        //** 3) Real Number Data Generation
        //**********************************************************

        //** Returns real number between min and max
        private double GetRealNumberData(double min, double max)
        {
            return min + random.NextDouble() * (max - min);
        }

        //** Returns an array of real numbers between min and max
        private double[] GenerateRandomRealNumberData(double min, double max, int items)
        {
            double[] data = new double[items];
            for (int i = 0; i < items; i++)
            {
                data[i] = GetRealNumberData(min, max);
                Debug.WriteLine(data[i].ToString("0.000"));
            }
            return data;
        }



        //**********************************************************
        //** Example: 
        //**  - Generate sensing data
        //**  - Process sensing data
        //**  - Save data to text file
        //**  - Check/Read data from text file
        //**********************************************************

        //**
        //** Next time, you will be asked to write some functions/methods like this
        //**

        private void Example_GenerateProcessSaveCheck()
        {
            //** Sensor properties
            double min = 4.0;   // Minimum value
            double max = 20.0;  // Maximum value

            //** Desired samples
            int samples = 30;  // Number of samples

            //** Generate sensor data
            double[] data = GenerateRandomRealNumberData(min, max, samples);

            //** Process data and convert to lines of string
            double threshold = 10.0;        // Threshold value
            string lines = string.Empty;    // lines of data to be saved
            foreach (var d in data)
            {
                if(d < threshold)
                {
                    lines += string.Format("{0:0.000}\r\n", d);
                }
            }

            //** Save the string data (all lines) to the text file
            string filePath = "./data.txt";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(lines);
            }


            //** Check the result (read the text file and write to the richTextBox.
            using (StreamReader sr = new StreamReader(filePath))
            {
                richTextBox1.Clear();

                string ? line;
                while ((line = sr.ReadLine()) != null)
                {
                    if(line == string.Empty) break;
                    richTextBox1.AppendText($"{line}\r\n");
                }
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
        }


        //** Button1 is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            //** Execute the Example_GenerateProcessSave
            Example_GenerateProcessSaveCheck();

            //** Open application directory
            // Process.Start("explorer.exe", $"/select, {Directory.GetCurrentDirectory()}");
        }
    }
}