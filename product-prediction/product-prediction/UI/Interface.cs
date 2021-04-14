using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_prediction.UI
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

		private void Categories(string s)
		{
			if (s.Equals("Branch"))
			{
				cbFilter.Items.Clear();
				cbFilter.Items.Add("Valid");
				cbFilter.Items.Add("Relict");
			}
			else if (s.Equals("Customer Type"))
			{
				cbFilter.Items.Clear();
				cbFilter.Items.Add("Fell");
				cbFilter.Items.Add("Found");

			}

			else if (s.Equals("Product Line"))
			{
				cbFilter.Items.Clear();
				cbFilter.Items.Add("Fell");
				cbFilter.Items.Add("Found");

			}

			else if (s.Equals("Payment"))
			{
				cbFilter.Items.Clear();
				cbFilter.Items.Add("Fell");
				cbFilter.Items.Add("Found");

			}

		}
	}
}
