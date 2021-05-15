using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_prediction.DecisionTree
{
    class Node<T>
    {
        public bool isLeaf { get; set; }
        public bool isRoot { get; set; }
        public T value { get; set; }

    }
}
