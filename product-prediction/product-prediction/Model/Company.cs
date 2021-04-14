using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace product_prediction.Model
{
    class Company
    {
        private List<Sale> sales;
		private const string file = "data/information.csv";

        public Company()
        {
            sales = new List<Sale>();
        }

		private DataTable dt = new DataTable();
		private void Read()
		{
			try
			{
				StreamReader sr = new StreamReader(file);
				string line;
				bool f = true;
				while ((line = sr.ReadLine()) != null)
				{
					string[] sl = line.Split(',');
					if (f == true)
					{
						for (int k = 0; k < sl.Length - 1; k++)
						{
							dt.Columns.Add(sl[k].ToString().Replace('"', ' ').Trim());
						}
						f = false;
					}
					else
					{
						dt.Rows.Add(sl);
					}
				}
			}
			catch (IOException)
			{

			}
		}

		
	}
}
