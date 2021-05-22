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
        DecisionTree tree;
        Codification codebook;
        int[][] inputs;
        int[] outputs;

        public DecisionTreeLibrary(){}

        [Obsolete]
        private void Codificate(DataTable data)
        {
            data.Columns.Remove("Invoice ID");
            data.Columns.Remove("City");
            data.Columns.Remove("Unit price");
            data.Columns.Remove("Quantity");
            data.Columns.Remove("Tax 5%");
            data.Columns.Remove("Total");
            data.Columns.Remove("DateTime");
            data.Columns.Remove("Payment");
            data.Columns.Remove("cogs");
            data.Columns.Remove("gross margin percentage");
            data.Columns.Remove("gross income");
            data.Columns.Remove("Rating");

            codebook = new Codification(data);
            DataTable symbols = codebook.Apply(data);
            inputs = symbols.ToArray<int>("Branch", "Customer Type", "Gender", "Payment");
            outputs = symbols.ToArray<int>("Product line");
        }

        [Obsolete]
        public void BuildTree(DataTable data)
        {
            Codificate(data);
            var id3learning = new ID3Learning()
            {
                new DecisionVariable("Branch", 3), // 3 possible values (A, B, C)
                new DecisionVariable("Customer Type", 2), // 2 possible values (Normal, Member)  
                new DecisionVariable("Gender", 2), // 2 possible values (Female, Male)    
                new DecisionVariable("Payment", 3)  // 3 possible values (Cash, Credit card and Ewallet) 

            };

            // Learn the training instances!
            tree = id3learning.Learn(inputs, outputs);
        }

        public string Evaluate(string branch, string cType, string gender, string payment)
        {

            // The tree can now be queried for new examples through 
            // its decide method. For example, we can create a query
            int[] query = codebook.Transform(new[,]
            {
                { "Branch", branch },
                { "Customer Type", cType },
                { "Gender", gender },
                { "Payment", payment }
            });

            // And then predict the label using
            int predicted = tree.Decide(query);  // result will be 0

            // We can translate it back to strings using
            return codebook.Revert("Product line", predicted); // Answer will be: "No"
        }

        public double Error()
        {
            // Compute the training error when predicting training instances
            return new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));
        }
    }

}
