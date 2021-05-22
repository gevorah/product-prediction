using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Math.Optimization.Losses;
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
        public void BuildTree(DataTable data)
        {
            data.Columns.Remove("");
            var codebook = new Codification(data);

            
            DataTable symbols = codebook.Apply(data);
            int[][] inputs = symbols.ToArray<int>("Branch", "Customer Type", "Gender", "Payment");
            int[] outputs = symbols.ToArray<int>("Product line");

          
            var id3learning = new ID3Learning()
            {
                new DecisionVariable("Branch",     3), // 3 possible values (A, B, C)
                new DecisionVariable("Customer Type", 2), // 2 possible values (Normal, Member)  
                new DecisionVariable("Gender",    2), // 2 possible values (Female, Male)    
                new DecisionVariable("Payment",        3)  // 3 possible values (Cash, Credit card and Ewallet) 

            };

            // Learn the training instances!
            DecisionTree tree = id3learning.Learn(inputs, outputs);

            // Compute the training error when predicting training instances
            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));

            // The tree can now be queried for new examples through 
            // its decide method. For example, we can create a query

            int[] query = codebook.Transform(new[,]
            {
                { "Branch",     "Sunny"  },
                { "Customer Type", "Hot"    },
                { "Gender",    "High"   },
                { "Payment",        "Strong" }
            });

            // And then predict the label using
            int predicted = tree.Decide(query);  // result will be 0

            // We can translate it back to strings using
            string answer = codebook.Revert("PlayTennis", predicted); // Answer will be: "No"


        }
    }

}
