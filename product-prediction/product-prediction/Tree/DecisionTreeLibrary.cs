using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics;
using Accord.Statistics.Filters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_prediction.Tree
{
    class DecisionTreeLibrary
    {
        [Obsolete]
        public DecisionTreeLibrary(DataTable dt)
        {
            BuildTree(dt);
        }
        
        [Obsolete]
        //
        public void BuildTree(DataTable data)
        {

            var codebook = new Codification(data);

            DataTable symbols = codebook.Apply(data);
            int[][] inputs = symbols.ToArray<int>("Outlook", "Temperature", "Humidity", "Wind");
            int[] outputs = symbols.ToArray<int>("PlayTennis");

            var id3learning = new ID3Learning()
             {

    new DecisionVariable("Outlook",     3), // 3 possible values (Sunny, overcast, rain)
    new DecisionVariable("Temperature", 3), // 3 possible values (Hot, mild, cool)  
    new DecisionVariable("Humidity",    2), // 2 possible values (High, normal)    
    new DecisionVariable("Wind",        2)  // 2 possible values (Weak, strong) 

  
            };

            DecisionTree tree = new DecisionTree(inputs: new[]
            {
                DecisionVariable.Continuous("X"),
                DecisionVariable.Continuous("Y")
            }, classes: 2);

            C45Learning teacher = new C45Learning(tree);

            outputs = outputs.Apply(x => x < 0 ? 0 : x);

            double error = teacher.Run(inputs, outputs);

            int[] answers = inputs.Apply(tree.Decide);



            

            

        }
    }

}
