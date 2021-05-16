using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_prediction.DecisionTree
{
    class DecisionTree
    {

        float nodeGainRatio;
        float nodeInformationGain;
        bool isLeaf;
        int majorityClass;
        int bestAttribute;
        List<DecisionTree>  children;
        DecisionTree parent;


        public DecisionTree(string[,]attributes, List<string> labels) {
            parent = null;
            buildTree(attributes, labels, self);
        }

        private List<int> segregate(List<string> attributearray, string value) {
            List<int> outlist = new List<int>();

            for (int i = 0; i < attributearray.Count; i++) {
                if (attributearray[i] == value) {
                    outlist.Add(i);
                }
            }

            return outlist;
        }

        private double computeEntropy(List<string> labels) {
            double entropy = 0;
            for (int i = 0; i < labels.Count; i++) {
                double probability_i = segregate(labels, labels[i]).Count / labels.Count;
                entropy -= probability_i * Math.Log(probability_i);
            }

            return entropy;
        }

        private string mostFrequentlyOccurringValue( List<string>labels) {
            int bestCount = -1;
            string bestId = "";
            for (int i = 0; i < labels.Count; i++) {
                int count_i = segregate(labels, labels[i]).Count;
                if (count_i > bestCount) {
                    bestCount = count_i;
                    bestId = labels[i];
                }
            }
            return bestId;
        }


    }
}
