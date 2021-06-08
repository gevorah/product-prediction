using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using product_prediction.Model;
using product_prediction.Tree;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace product_prediction.Experiment
{
    class TimeExperiment
    {
        Company cp;
        DataTable dt;

        public TimeExperiment(Company c)
        {
            cp = c;
            dt = new DataTable();
            CreateTable();
        }

        public void CreateTable()
        {
            dt.Columns.Add("Implementation");
            dt.Columns.Add("Input size");
            dt.Columns.Add("Time");
            dt.Columns.Add("Treatment");
            
        }

        private void CreateExperiment()
        {
            int repetition = 1;
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = 0;
            int prev = -1;
            int[] count = new int[6];

            while (repetition <= 600)
            {
                prev = value;
                do
                {
                    value = random.Next(1, 7);
                } 
                while (prev == value);

                switch (value)
                {
                    case 1:
                        if (count[0] < 100)
                        {
                            count[0]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 2:
                        if (count[1] < 100)
                        {
                            count[1]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 3:
                        if (count[2] < 100)
                        {
                            count[2]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 4:
                        if (count[3] < 100)
                        {
                            count[3]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 5:
                        if (count[4] < 100)
                        {
                            count[4]++;
                            Cases(value);
                            repetition++;
                        }
                        break;

                    case 6:
                        if (count[5] < 100)
                        {
                            count[5]++;
                            Cases(value);
                            repetition++;
                        }
                        break;
                }

            }
        }

        public void Cases(int value)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            double t;
            switch (value)
            {

                case 1:
                    
                    time.Stop();
                    t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "1", t, "1");
                    break;

                case 2:
                    
                    time.Stop();
                    t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "2", t, "2");
                    break;

                case 3:
                  
                    time.Stop();
                    t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("1", "3", t, "3");
                    break;

                case 4:
                    
                    time.Stop();
                    t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "1", t, "4");
                    break;

                case 5:
                   
                    time.Stop();
                    t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "2", t, "5");
                    break;

                case 6:
                   
                    time.Stop();
                    t = time.Elapsed.TotalMilliseconds;
                    dt.Rows.Add("2", "2", t, "6");
                    break;

               
            }


        }


        public void MakePredictions(int predictions, int type, string[,] inputs)
        {
            string[,] trainInputs = new string[2, 4]
            {
                { "Branch", "Customer type", "Gender", "Payment" },
                { "","","",""}
            };
            Random rd = new Random();
            for (int i = 0; i < predictions; i++)
            {

                int random = rd.Next(1, 999);

                for (int j = 0; j < 4; j++)
                {

                    trainInputs[1, j] = inputs[random, j];

                }
            }
        }

    }


}
}
