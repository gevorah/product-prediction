﻿using product_prediction.Model;
using product_prediction.Tree;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_prediction.Experiment
{
    class PPExperiment
    {
        Company cp;
        public PPExperiment(Company c)
        {
            cp = c;
        }

        [Obsolete]
        public string MakePrediction(int predictions, string treeType, string[,] inputs, DecisionTreeImplementation tree, DecisionTreeLibrary treeL)
        {
            string pl = "";
            string msj = "";
            Stopwatch time = new Stopwatch();
            time.Start();
            var t = 0.0; 

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
                if (treeType.Equals("Implementation"))
                {
                    pl += cp.EvaluateImplementation(trainInputs[1, 0], trainInputs[1, 1], trainInputs[1, 2], trainInputs[1, 3]) + "\n";

                }
                else
                {
                    pl += cp.EvaluateLibrary(trainInputs[1, 0], trainInputs[1, 1], trainInputs[1, 2], trainInputs[1, 3]) + "\n";
                }

                
                 
            }

            time.Stop();
            t = time.Elapsed.TotalMilliseconds;
            msj = "Time : "+ t + "\n" + "Predictions : " + pl;
            return msj; 
        }
    }
}
