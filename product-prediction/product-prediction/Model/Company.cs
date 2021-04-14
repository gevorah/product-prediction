using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Globalization;

namespace product_prediction.Model
{
    class Company
    {
        private List<Sale> sales;
		private const string file = @"data\information.csv";

        public Company()
        {
			sales = new List<Sale>();
			Read();
		}

		private DataTable dt = new DataTable();
		private void Read()
		{
				try
			{
				string cd = Directory.GetCurrentDirectory();
				string extra = @"bin\Debug";
				string path = cd.Substring(0,cd.Length-extra.Length) + file;
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
							dt.Columns.Add(sl[k]);
						}
						f = false;
					}
					else
					{
						dt.Rows.Add(sl);
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
                sl[0], Convert.ToChar(sl[1]), sl[2], sl[3], sl[4], sl[5], Convert.ToDouble(sl[6]), 
				Convert.ToInt32(sl[7]), Convert.ToDouble(sl[8]), Convert.ToDouble(sl[9]), DateTime.Parse(sl[10]+" "+sl[11], new CultureInfo("en-US", false)), 
				sl[12], Convert.ToDouble(sl[13]), Convert.ToDouble(sl[14]), Convert.ToDouble(sl[15]), Convert.ToDouble(sl[16])
				));
        }

		public DataTable GetDataTable()
		{
			return dt;
		}
	}
}
