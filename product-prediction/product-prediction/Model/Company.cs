using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Globalization;
using product_prediction.Tree;
using product_prediction.Experiment;

namespace product_prediction.Model
{
    class Company
    {
        private List<Sale> sales;
		private const string File = @"data\information.csv";
		private DecisionTreeImplementation tree;
		private DecisionTreeLibrary treeL; 
		private DataTable dt;

		public Company()
        {
			sales = new List<Sale>();
			dt = new DataTable();
		}

		
		public void Read()
		{
				try
			{
				string cd = Directory.GetCurrentDirectory();
				string extra = @"bin\Debug";
				string path = cd.Substring(0,cd.Length-extra.Length) + File; 
				Console.WriteLine(path);
				StreamReader sr = new StreamReader(path);
				string line;
				bool f = true;
				while ((line = sr.ReadLine()) != null)
				{
					string[] sl = line.Split(',');
					if (f == true)
					{
						for (int k = 0; k < sl.Length; k++)
						{
							if (sl[k].Equals("Date")) dt.Columns.Add(sl[k] + sl[k + 1], typeof(DateTime));
                            else if (!sl[k].Equals("Time"))
                            {
								if (sl[k].Equals("Invoice ID") || sl[k].Equals("Gender") || sl[k].Equals("Payment") || sl[k].Equals("Product line") 
								|| sl[k].Equals("Customer type") || sl[k].Equals("Branch") || sl[k].Equals("City")) dt.Columns.Add(sl[k]);
                           		else dt.Columns.Add(sl[k], typeof(double));
                            }
							
						}
						f = false;
					}
					else
					{
						dt.Rows.Add(sl[0], sl[1], sl[2], sl[3], sl[4], sl[5], Convert.ToDouble(sl[6], CultureInfo.InvariantCulture),
							Convert.ToInt32(sl[7]), Convert.ToDouble(sl[8], CultureInfo.InvariantCulture), Convert.ToDouble(sl[9], CultureInfo.InvariantCulture),
							DateTime.Parse(sl[10] + " " + sl[11], new CultureInfo("en-US", false)), sl[12], Convert.ToDouble(sl[13], CultureInfo.InvariantCulture),
							Convert.ToDouble(sl[14], CultureInfo.InvariantCulture), Convert.ToDouble(sl[15], CultureInfo.InvariantCulture), Convert.ToDouble(sl[16], CultureInfo.InvariantCulture)
							);
						createSale(sl);
					}
				}
			}
			catch (IOException)
			{

			}
		}

		private void createSale(string[] sl)
        {
			sales.Add(new Sale(
                sl[0], Convert.ToChar(sl[1]), sl[2], sl[3], sl[4], sl[5], Convert.ToDouble(sl[6], CultureInfo.InvariantCulture), 
				Convert.ToInt32(sl[7]), Convert.ToDouble(sl[8], CultureInfo.InvariantCulture), Convert.ToDouble(sl[9], CultureInfo.InvariantCulture), 
				DateTime.Parse(sl[10]+" "+sl[11], new CultureInfo("en-US", false)), sl[12], Convert.ToDouble(sl[13], CultureInfo.InvariantCulture), 
				Convert.ToDouble(sl[14], CultureInfo.InvariantCulture), Convert.ToDouble(sl[15], CultureInfo.InvariantCulture), Convert.ToDouble(sl[16], CultureInfo.InvariantCulture)
				));
		}


		public int[,] count()
        {
			DataRow[] dr = dt.Select();
			int[,] c = new int[6, 6];
			for (int i = 0; i < dr.Length; i++)
            {
				string pl = dr[i]["Product line"].ToString();
				string g = dr[i]["Gender"].ToString();
				string ct = dr[i]["Customer type"].ToString();
				string b = dr[i]["Branch"].ToString();
				string p = dr[i]["Payment"].ToString();

				//Product line
				if (pl.Equals("Electronic accessories"))
				{
					c[0, 0]++;
				}
				else if (pl.Equals("Fashion accessories"))
				{
					c[0, 1]++;
				}
				else if(pl.Equals("Food and beverages"))
                {
					c[0, 2]++;
				}
				else if (pl.Equals("Health and beauty"))
                {
					c[0, 3]++;
				}
				else if (pl.Equals("Home and lifestyle"))
                {
					c[0, 4]++;
				}
				else if (pl.Equals("Sports and travel"))
                {
					c[0, 5]++;
				}

				//Gender
				if (g.Equals("Male"))
				{
					c[1, 0]++;
				}
				else if (g.Equals("Female"))
				{
					c[1, 1]++;
				}

				//Customer type
				if (ct.Equals("Normal"))
				{
					c[2, 0]++;
				}
				else if (ct.Equals("Member"))
				{
					c[2, 1]++;
				}

				//Branch
				if (b.Equals("A"))
				{
					c[3, 0]++;
				}
				else if (b.Equals("B"))
				{
					c[3, 1]++;
				}
				else if (b.Equals("C"))
				{
					c[3, 2]++;
				}

				//Payment
				if (p.Equals("Cash"))
				{
					c[4, 0]++;
				}
				else if (p.Equals("Ewallet"))
				{
					c[4, 1]++;
				}
				else if (p.Equals("Credit card"))
				{
					c[4, 2]++;
				}
			}
			return c;
		}

		public DataTable GetDataTable()
		{
			return dt;
		}

		public DecisionTreeImplementation GetTreeImplementation()
		{
			return tree;
		}
		public DecisionTreeLibrary GetTreeLibrary()
		{
			return treeL;
		}

		string[,] predictions;
		List<string> labels;

		public string Training() 
		{
			//Predictions Matrix: Branch	Customer type	Gender	 Payment
			//Labels List: Product line
			predictions = new string[700, 4];
			labels = new List<string>();
			DataRow[] dr = dt.Select();
			predictions[0, 0] = "Branch";
			predictions[0, 1] = "Customer type";
			predictions[0, 2] = "Gender";
			predictions[0, 3] = "Payment";
			labels.Add("Product line");
			for (int i = 1; i < 700; i++)
			{
				predictions[i, 0] = dr[i - 1]["Branch"].ToString();
				predictions[i, 1] = dr[i - 1]["Customer type"].ToString();
				predictions[i, 2] = dr[i - 1]["Gender"].ToString();
				predictions[i, 3] = dr[i - 1]["Payment"].ToString();
				labels.Add(dr[i]["Product line"].ToString());
			}
			tree = new DecisionTreeImplementation(predictions, labels);
			tree.PintarArbol("", true, "");
			return tree.getSTree();
		}

		public void Analysis()
		{
			DataRow[] dr = dt.Select();
			//Data for analysis. 2 Rows Matrix.
			for (int i=700;i<1000;i++)
            {
				string[,] data = { { "Branch", "Customer type", "Gender", "Payment" }, 
									{ dr[i]["Branch"].ToString(), dr[i]["Customer type"].ToString(), dr[i]["Gender"].ToString(), dr[i]["Payment"].ToString() } };
				tree.Evaluar(data);
			}
			
		}

		public string[] EvaluateImplementation(string branch, string ct, string gender, string payment)
		{
			string str = Training();
			String[,] data = { { "Branch", "Customer type", "Gender", "Payment" }, { branch, ct, gender,payment },};
			return new string[] { tree.Evaluar(data) + "\nAccuracy: " + AccuracyOfImplementationTree() , str };
		
		}

        [Obsolete]
        public void CreateDecisionTreeLibrary()
        {
			treeL = new DecisionTreeLibrary();
			DataTable training = dt.Copy();
			for (int i=999;i>699;i--)
			{
				training.Rows.RemoveAt(i);
			}
			treeL.BuildTree(training);
		}

		[Obsolete]
		public string EvaluateLibrary(string branch, string ct, string gender, string payment)
		{
			if (treeL == null)
			{
				CreateDecisionTreeLibrary();
            }
            
			return treeL.Evaluate(branch,ct,gender,payment) + "\nAccuracy: " + treeL.Accuracy() + "%";

		}

		public string AccuracyOfImplementationTree()
		{
			DataTable data = dt;
			string[] outputs = data.AsEnumerable().Select(x => x.Field<string>("Product line")).ToArray();
			string[,] inputs = MakeInputs();
			return tree.Accuracy(inputs,outputs) + "%";
        }

        public string[,] MakeInputs()
        {
			string[,] inputs = new string[dt.Rows.Count, 4];
			DataRow[] dr = dt.Select();
			for (int i = 0; i < dr.Count(); i++)
			{
				inputs[i, 0] = dr[i]["Branch"].ToString();
				inputs[i, 1] = dr[i]["Customer type"].ToString();
				inputs[i, 2] = dr[i]["Gender"].ToString();
				inputs[i, 3] = dr[i]["Payment"].ToString();
			}
			return inputs;
		}
	}
}
