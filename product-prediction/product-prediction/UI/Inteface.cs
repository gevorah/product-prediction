using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using product_prediction.Model;
using System.IO;

namespace product_prediction.UI
{
    public partial class Interface : Form
    {

		private Company cp;
		private DataTable dt;

		public Interface()
        {
            InitializeComponent();
			Init();
        }

		public void Init()
        {
			cp = new Company();
			dt = cp.GetDataTable();
			data.DataSource = dt;
			cbFilter.Visible = false;
			labelFilter.Visible = false;
			labelRange.Visible = false;
			labelTo.Visible = false;
			Range1.Visible = false;
			Range2.Visible = false;
		}

		private void Categories(string s)
		{
			if (s.Equals("Branch"))
			{
				cbFilter.Items.Clear();
				cbFilter.Items.Add("A");
				cbFilter.Items.Add("B");
				cbFilter.Items.Add("C");
			}
			else if (s.Equals("Customer Type"))
			{
				cbFilter.Items.Clear();
				cbFilter.Items.Add("Member");
				cbFilter.Items.Add("Normal");

			}

			else if (s.Equals("Product Line"))
			{
				cbFilter.Items.Clear();
				cbFilter.Items.Add("Electronic accessories");
				cbFilter.Items.Add("Fashion accessories");
				cbFilter.Items.Add("Food and beverages");
				cbFilter.Items.Add("Health and beauty");
				cbFilter.Items.Add("Home and lifestyle");
				cbFilter.Items.Add("Sports and travel");


			}

			else if (s.Equals("Payment"))
			{
				cbFilter.Items.Clear();
				cbFilter.Items.Add("Cash");
				cbFilter.Items.Add("Ewallet");
				cbFilter.Items.Add("Credit Card");

			}

			else if (s.Equals("Gender"))
			{
				cbFilter.Items.Clear();
				cbFilter.Items.Add("Male");
				cbFilter.Items.Add("Female");

			}
		}
		private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selected = cbCategory.Text;
			if (selected.Equals("Gender") || selected.Equals("Payment") || selected.Equals("Product Line") || selected.Equals("Customer Type") || selected.Equals("Branch"))
			{
				Categories(selected);
				cbFilter.Visible = true;
				labelFilter.Visible = true;
				labelRange.Visible = false;
				labelTo.Visible = false;
				Range1.Visible = false;
				Range2.Visible = false;
			}
            else
            {
				cbFilter.Visible = false;
				labelFilter.Visible = false;
				labelRange.Visible = true;
				labelTo.Visible = true;
				Range1.Visible = true;
				Range2.Visible = true;
			}
		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			string s = cbFilter.Text;
			if (s.Equals("Male"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Gender", cbFilter.Text); ;
			}
			else if (s.Equals("Female"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Gender", cbFilter.Text); ;
			}
		}
	}

       
    }
