using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_prediction.DecisionTree
{
    class DecisionTree
    {

        double nodeGainRatio;
        double nodeInformationGain;
        bool isLeaf;
        string majorityClass;
        string bestAttribute;
        List<DecisionTree>  children;
        DecisionTree parent;


        public DecisionTree(string[,]attributes, List<string> labels) {
            parent = null;
            buildTree(attributes, labels);
        }

        private List<int> segregate(List<string> attributearray, string value) {
            List<int> outlist = new List<int>();

            for (int i = 1; i < attributearray.Count; i++) {
                if (attributearray[i] == value) {
                    outlist.Add(i);
                }
            }

            return outlist;
        }

        private double computeEntropy(List<string> labels) {
            double entropy = 0;
            for (int i = 1; i < labels.Count; i++) {
                double probability_i = segregate(labels, labels[i]).Count / labels.Count;
                entropy -= probability_i * Math.Log(probability_i);
            }

            return entropy;
        }

        private string mostFrequentlyOccurringValue( List<string>labels) {
            int bestCount = -1;
            string bestId = "";
            for (int i = 1; i < labels.Count; i++) {
                int count_i = segregate(labels, labels[i]).Count;
                if (count_i > bestCount) {
                    bestCount = count_i;
                    bestId = labels[i];
                }
            }
            return bestId;
        }


        private string[] ObtenerValoresUnicos(string[,] matrix, int columna)
        {
            List<string> valoresUnicos = new List<string>();
            bool existe;
            string valor;

            for (int fila = 1; fila < (matrix.GetUpperBound(0)+1); fila++)
            {
                valor = matrix[fila, columna];
                existe = false;

                for(int i = 0; i < valoresUnicos.Count; i++)
                {
                    if(valor == valoresUnicos[i])
                    {
                        existe = true;
                        break;
                    }
                }

                if (!existe)
                {
                    valoresUnicos.Add(valor);
                }
            }

            return valoresUnicos.ToArray();
        }


        private List<string> ObtenerValoresColumna(string[,] matrix, int columna)
        {
            List<string> valores = new List<string>();
            string valor;

            for (int fila = 1; fila < (matrix.GetUpperBound(0) + 1); fila++)
            {
                valor = matrix[fila, columna];
                valores.Add(valor);
            }

            return valores;
        }

        private List<string> obtenerListaValores(List<string> listaValores, List<int> listaIndices)
        {
            List<string> listaFiltrada = new List<string>();
            int indice;

            for(int i = 0; i < listaIndices.Count; i++)
            {
                indice = listaIndices[i];
                listaFiltrada.Add(listaValores[indice]);
            }

            return listaFiltrada;
        }


        private string[,] ObtenerListaValores(string[,] matriz, List<int> listaIndices)
        {
            int cantidadFilas = listaIndices.Count;
            int cantidadColumnas = matriz.GetUpperBound(1) + 1;

            string[,] matrizFiltrada = new string[cantidadFilas, cantidadColumnas];
            
            for (int i = 0; i < matriz.GetUpperBound(0) + 1; i++)
            {
                if (listaIndices.Contains(i))
                {
                    for(int j=0; j < matriz.GetUpperBound(1) + 1; j++)
                    {
                        matrizFiltrada[i, j] = matriz[i, j];
                    }
                }
            }

            return matrizFiltrada;
        }

        private string[,] EliminarColumna(string[,] matriz, int columnaEliminar)
        {
            // Se define la nueva matriz sin una solumna
            string[,] matrizDepurada = new string[matriz.GetUpperBound(0) + 1, matriz.GetUpperBound(1)];
            int fila, columna;
            // Recorre las filas
            for (int i = 0; i < matriz.GetUpperBound(0) + 1; i++)
            { 
                // Recorre las Columnas
                for(int j = 0; j < matriz.GetUpperBound(1) + 1; j++)
                {
                    fila = i;
                    columna = j;
                    if (columna == columnaEliminar) continue;
                    else if (columna > columnaEliminar) columna -= 1;

                    matrizDepurada[fila, columna] = matriz[fila, j];
                }
            }

            return matrizDepurada;
        }

        private void buildTree(string[,] attributes, List<string> labels) {

            int numInstances = labels.Count;
            double nodeInformation = numInstances * computeEntropy(labels);
            this.majorityClass = mostFrequentlyOccurringValue(labels);

            if (nodeInformation == 0) {
                isLeaf = true;
                return;
            }

            int bestAttributeId = -1;
            string bestAttribute = "";
            double bestInformationGain = -1;
            double bestGainRatio = -1;

            for(int X=0; X < attributes.Length; X++) {
                double conditionalInfo = 0;
                double attributeEntropy = 0;

                string[] valoresColumna = ObtenerValoresUnicos(attributes, X);
                double[] attributeCount = new double[valoresColumna.Length];

                for (int Y = 0; Y< valoresColumna.Length; Y++) 
                {
                    List<int> ids = segregate(ObtenerValoresColumna(attributes, X), valoresColumna[Y]); // get ids of all instances for which attribute X == Y

                    attributeCount[Y] = ids.Count;
                    conditionalInfo += attributeCount[Y] * computeEntropy(obtenerListaValores(labels,ids));
                }

                double attributeInformationGain = nodeInformation - conditionalInfo;
                double gainRatio = attributeInformationGain / computeEntropy(attributeCount);
                
                if (gainRatio > bestGainRatio) {
                    bestInformationGain = attributeInformationGain;
                    bestGainRatio = gainRatio;
                    bestAttribute = attributes[0,X];
                    bestAttributeId = X;
                }
            }

            // If no attribute provides andy gain, this node cannot be split further
            if (bestGainRatio == 0) {
                @isLeaf = true;
                return;
            }

            // Otherwise split by the best attribute
            this.bestAttribute = bestAttribute;
            this.nodeGainRatio = bestGainRatio;
            this.nodeInformationGain = bestInformationGain;

            string[] valoresMejorColumna = ObtenerValoresUnicos(attributes, bestAttributeId);

            for (int Y = 0; Y < valoresMejorColumna.Length; Y++) {
                List<int> ids = segregate(ObtenerValoresColumna(attributes, bestAttributeId), valoresMejorColumna[Y]);
                this.children[Y] = new DecisionTree(ObtenerListaValores(attributes, ids), obtenerListaValores(labels, ids));
                this.children[Y].parent = this;
            }

            return;
        }
    }
}
