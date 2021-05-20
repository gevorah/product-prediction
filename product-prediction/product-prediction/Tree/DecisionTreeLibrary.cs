using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_prediction.Tree
{
    class DecisionTreeLibrary
    {
        public DecisionTreeLibrary(double[][] inputs,int[] outputs)
        {
            BuildTree(inputs, outputs);
        }

        public void BuildTree(double[][] inputs, int[] outputs)
        {

            DecisionTree tree = new DecisionTree(inputs: new[]
            {
                DecisionVariable.Continuous("X"),
                DecisionVariable.Continuous("Y")
            }, classes: 2);

            C45Learning teacher = new C45Learning(tree);

            outputs = outputs.Apply(x => x < 0 ? 0 : x);

            double error = teacher.Run(inputs, outputs);

            int[] answers = inputs.Apply(tree.Compute);

            

        }
    }
}
