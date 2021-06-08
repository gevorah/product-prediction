using Accord.MachineLearning;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Math.Optimization.Losses;
using Accord.Statistics;
using Accord.Statistics.Analysis;
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

        public DecisionTreeLibrary() { }

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
                { "Customer type", cType },
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

        public double Accuracy()
        {
            // Let's say we want to measure the cross-validation performance of
            // a decision tree with a maximum tree height of 6 and where variables
            // are able to join the decision path at most 1 times during evaluation:
            var cv = CrossValidation.Create(

                k: 5, // We will be using 5-fold cross validation

                learner: (p) => new ID3Learning() // here we create the learning algorithm
                {
                    Join = 1,
                    MaxHeight = 0
                },

                // This function can be used to perform any special
                // operations before the actual learning is done, but
                // here we will just leave it as simple as it can be:
                fit: (teacher, x, y, w) => teacher.Learn(x, y, w),

                // Now we have to specify how the tree performance should be measured:
                loss: (actual, expected, p) => new ZeroOneLoss(expected).Loss(actual),

                // Finally, we have to pass the input and output data
                // that will be used in cross-validation. 
                x: inputs, y: outputs
            );

            // After the cross-validation object has been created,
            // we can call its .Learn method with the input and 
            // output data that will be partitioned into the folds:
            var result = cv.Learn(inputs, outputs);

            // We can grab some information about the problem:
            int numberOfSamples = result.NumberOfSamples; // should be 1000
            int numberOfInputs = result.NumberOfInputs;   // should be 4
            int numberOfOutputs = result.NumberOfOutputs; // should be 6

            double trainingError = result.Training.Mean;
            double validationError = result.Validation.Mean;

            // If desired, compute an aggregate confusion matrix for the validation sets:
            GeneralConfusionMatrix gcm = result.ToConfusionMatrix(inputs, outputs);
            return (gcm.Accuracy*100);
        }
    }
}
