using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_prediction.Tree
{

    //new code
    class DecisionTreeImplementation
    {
        double nodeGainRatio;
        double nodeInformationGain;
        bool isLeaf;
        string majorityClass;
        string bestAttribute;
        int bestAttributeId;
        Dictionary<string, DecisionTreeImplementation> children = new Dictionary<string, DecisionTreeImplementation>();
        DecisionTreeImplementation parent;


        public DecisionTreeImplementation(string[,] attributes, List<string> labels)
        {
            parent = null;
            BuildTree(attributes, labels);
        }

        private List<int> IdentificarOcurrencias(List<string> matrizValores, string valorBuscar)
        {
            List<int> listaIdsOcurrencias = new List<int>();

            for (int i = 1; i < matrizValores.Count; i++)
            {
                if (matrizValores[i] == valorBuscar)
                {
                    listaIdsOcurrencias.Add(i);
                }
            }

            return listaIdsOcurrencias;
        }

        private double CalcularEntropia(List<string> etiquetas)
        {
            double entropia = 0;
            List<string> valoresColumna = ObtenerValoresUnicosLista(etiquetas);
            int cantidadOcurrencias = 0;
            double probabilidad_i = 0;

            for (int i = 0; i < valoresColumna.Count; i++)
            {
                cantidadOcurrencias = IdentificarOcurrencias(etiquetas, valoresColumna[i]).Count;
                probabilidad_i = (double)cantidadOcurrencias / (double)(etiquetas.Count - 1);
                entropia -= probabilidad_i * Math.Log(probabilidad_i);
            }

            return entropia;
        }


        private string ObtenerValorMasFrecuente(List<string> etiquetas)
        {
            int mejorConteo = -1;
            string mejorEtiqueta = "";
            for (int i = 1; i < etiquetas.Count; i++)
            {
                int cantidadOcurrencias_i = IdentificarOcurrencias(etiquetas, etiquetas[i]).Count;
                if (cantidadOcurrencias_i > mejorConteo)
                {
                    mejorConteo = cantidadOcurrencias_i;
                    mejorEtiqueta = etiquetas[i];
                }
            }
            return mejorEtiqueta;
        }

        static int n = 0;

        private string[] ObtenerValoresUnicos(string[,] matrix, int columna)
        {
            List<string> valoresUnicos = new List<string>();
            bool existe;
            string valor;

            for (int fila = 1; fila < (matrix.GetUpperBound(0) + 1); fila++)
            {
                valor = matrix[fila, columna];
                existe = false;

                for (int i = 0; i < valoresUnicos.Count; i++)
                {
                    if (valor == valoresUnicos[i])
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

        private List<String> ObtenerValoresUnicosLista(List<string> listaValores)
        {
            List<string> valoresUnicos = new List<string>();
            string valor;

            for (int i = 1; i < listaValores.Count; i++)
            {
                valor = listaValores[i];

                if (!valoresUnicos.Contains(valor)) valoresUnicos.Add(valor);
            }

            return valoresUnicos;
        }

        private List<string> ObtenerValoresColumna(string[,] matrix, int columna)
        {
            List<string> valores = new List<string>();
            string valor;

            for (int fila = 0; fila < (matrix.GetUpperBound(0) + 1); fila++)
            {
                valor = matrix[fila, columna];
                valores.Add(valor);
            }

            return valores;
        }

        private List<string> ObtenerListaValoresFiltrada(List<string> listaValores, List<int> listaIndices)
        {
            List<string> listaFiltrada = new List<string>();
            int indice;

            listaFiltrada.Add(listaValores[0]);

            for (int i = 0; i < listaIndices.Count; i++)
            {
                indice = listaIndices[i];
                listaFiltrada.Add(listaValores[indice]);
            }

            return listaFiltrada;
        }


        private string[,] ObtenerMatrizValoresFiltrada(string[,] matriz, List<int> listaIndices)
        {
            int cantidadFilas = listaIndices.Count + 1;
            int cantidadColumnas = matriz.GetUpperBound(1) + 1;

            string[,] matrizFiltrada = new string[cantidadFilas, cantidadColumnas];
            int idfilaMatrizFiltrada = 0;

            for (int idFila = 0; idFila < matriz.GetUpperBound(0) + 1; idFila++)
            {
                // La fila cero es los encabezados y si deben estar
                if (idFila == 0 || listaIndices.Contains(idFila))
                {
                    for (int idColumna = 0; idColumna < matriz.GetUpperBound(1) + 1; idColumna++)
                    {
                        matrizFiltrada[idfilaMatrizFiltrada, idColumna] = matriz[idFila, idColumna];
                    }
                    idfilaMatrizFiltrada++;
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
                for (int j = 0; j < matriz.GetUpperBound(1) + 1; j++)
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

        private void BuildTree(string[,] attributes, List<string> labels)
        {

            int numInstances = labels.Count;
            double nodeInformation = numInstances * CalcularEntropia(labels);
            this.majorityClass = ObtenerValorMasFrecuente(labels);

            if (nodeInformation == 0 || attributes.GetUpperBound(0) == -1 || attributes.GetUpperBound(1) == -1)
            {
                isLeaf = true;
                return;
            }

            int bestAttributeId = -1;
            string bestAttribute = "";
            double bestInformationGain = -1;
            double bestGainRatio = -1;

            for (int X = 0; X < attributes.GetUpperBound(1) + 1; X++)
            {
                double conditionalInfo = 0;
                double attributeEntropy = 0;

                string[] valoresColumna = ObtenerValoresUnicos(attributes, X);
                double[] attributeCount = new double[valoresColumna.Length];

                for (int Y = 0; Y < valoresColumna.Length; Y++)
                {
                    List<int> ids = IdentificarOcurrencias(ObtenerValoresColumna(attributes, X), valoresColumna[Y]); // get ids of all instances for which attribute X == Y

                    attributeCount[Y] = ids.Count;
                    double entropiaCalculada = CalcularEntropia(ObtenerListaValoresFiltrada(labels, ids));
                    conditionalInfo += attributeCount[Y] * entropiaCalculada;
                }

                double attributeInformationGain = nodeInformation - conditionalInfo;
                double gainRatio = attributeInformationGain / CalcularEntropia(ObtenerValoresColumna(attributes, X));

                if (gainRatio > bestGainRatio)
                {
                    bestInformationGain = attributeInformationGain;
                    bestGainRatio = gainRatio;
                    bestAttribute = attributes[0, X];
                    bestAttributeId = X;
                }
            }

            // If no attribute provides andy gain, this node cannot be split further
            if (bestGainRatio == 0)
            {
                @isLeaf = true;
                return;
            }

            // Otherwise split by the best attribute
            this.bestAttributeId = bestAttributeId;
            this.bestAttribute = bestAttribute;
            this.nodeGainRatio = bestGainRatio;
            this.nodeInformationGain = bestInformationGain;

            string[] valoresMejorColumna = ObtenerValoresUnicos(attributes, bestAttributeId);

            for (int Y = 0; Y < valoresMejorColumna.Length; Y++)
            {
                List<string> valores = ObtenerValoresColumna(attributes, bestAttributeId);
                string valorEvaluar = valoresMejorColumna[Y];
                List<int> ids = IdentificarOcurrencias(valores, valorEvaluar);

                //this.children.Add(valoresMejorColumna[Y], new DecisionTree(ObtenerMatrizValoresFiltrada(attributes, ids), ObtenerListaValoresFiltrada(labels, ids)));
                //this.children[valoresMejorColumna[Y]].parent = this;

                // NUEVO
                string[,] atributosNuevoArbol = EliminarColumna(attributes, bestAttributeId);
                atributosNuevoArbol = ObtenerMatrizValoresFiltrada(atributosNuevoArbol, ids);

                //List<string> nuevasEtiquetas = ObtenerListaValoresFiltrada(valores, ids);
                List<string> nuevasEtiquetas = ObtenerListaValoresFiltrada(labels, ids);
                this.children.Add(valoresMejorColumna[Y], new DecisionTreeImplementation(atributosNuevoArbol, nuevasEtiquetas));
                this.children[valoresMejorColumna[Y]].parent = this;
            }

            return;
        }

        public String Evaluar(string[,] matrizEvaluar, int i = 0)
        {
            if (this.isLeaf)
                return this.majorityClass;
            else
            {
                string valorEvaluar = "";
                for (int columna = 0; columna < matrizEvaluar.GetUpperBound(1) + 1; columna++)
                {
                    if (this.bestAttribute == matrizEvaluar[0, columna])
                    {
                        valorEvaluar = matrizEvaluar[1, columna];
                        break;
                    }
                }

                return this.children[valorEvaluar].Evaluar(matrizEvaluar, i += 1);
            }
        }

        public static string sTree = "";
        public string getSTree() { return sTree; }

        public void PintarArbol(string identacion, bool ultimo, string valor)
        {
            sTree += "\n" + identacion;
            if (this.isLeaf)
            {
                sTree += "\\--" + valor + "->" + this.majorityClass;
                identacion += "  ";
            }
            else
            {
                string cadenaPrevia = "|--" + valor + "->";
                sTree += cadenaPrevia + this.bestAttribute;
                identacion += "|".PadRight(cadenaPrevia.Length, ' ');
            }

            int cantidadElementosDiccionario = this.children.Count;
            int indice = 1;

            foreach (KeyValuePair<string, DecisionTreeImplementation> subArbol in this.children)
            {
                subArbol.Value.PintarArbol(identacion, indice == cantidadElementosDiccionario, subArbol.Key);
                indice++;
            }

        }

        public float Accuracy(string[,] inputs, string[] outputs)
        {
            int sales = outputs.Length;
            string[] predictions = new string[inputs.Length];
            string[,] trainInputs = new string[2, 4] 
            { 
                { "Branch", "Customer type", "Gender", "Payment" },
                { "","","",""} 
            };

            for (int i = 0; i < sales; i++)
            {
                for(int j = 0; j < 4; j++)
                {

                    trainInputs[1, j] = inputs[i, j];
                }
                string p = Evaluar(trainInputs);
                predictions[i] = p;
            }

            int errors = 0;
            for(int i = 0; i < sales; i++)
            {
                if (predictions[i] != outputs[i])
                {
                    errors++;
                }
            }
            return 100 - ( errors / sales );
        }

    }
}
