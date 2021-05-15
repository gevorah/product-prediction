using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_prediction.DecisionTree
{
    class Tree<T>
    {
        public int numOfNodes { get; }
        public int numOfClasses { get; }
        public List<Node<T>> tree;

        public Tree(int numOfNodes, int numOfClasses)
        {

        }

        public void BuildTree(T[][] dataX,T[] dataY)
        { 
        
        }

    }
}
