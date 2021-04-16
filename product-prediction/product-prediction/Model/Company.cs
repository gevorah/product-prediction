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

		public DataTable GetDataTable()
		{
			return dt;
		}
	}
}
