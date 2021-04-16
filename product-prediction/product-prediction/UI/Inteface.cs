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
using System.Globalization;
using System.Collections;

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
			FilterRange.Visible = false;
			
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
			else if (s.Equals("Customer type"))
			{
				cbFilter.Items.Clear();
				cbFilter.Items.Add("Member");
				cbFilter.Items.Add("Normal");

			}

			else if (s.Equals("Product line"))
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
			else if (s.Equals("City"))
            {
				cbFilter.Items.Clear();
				cbFilter.Items.Add("Yangon");
				cbFilter.Items.Add("Mandalay");
				cbFilter.Items.Add("Naypyitaw");
			}
		}

		private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selected = cbCategory.Text;
			if (selected.Equals("Gender") || selected.Equals("Payment") || selected.Equals("Product line") || selected.Equals("Customer type") || selected.Equals("Branch") || selected.Equals("City"))
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
				FilterRange.Visible = true;
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
			else if (s.Equals("Member"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Customer type", cbFilter.Text); ;
			}
			else if (s.Equals("Normal"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Customer type", cbFilter.Text); ;
			}
			else if (s.Equals("A"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Branch", cbFilter.Text); ;
			}
			else if (s.Equals("B"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Branch", cbFilter.Text); ;
			}
			else if (s.Equals("C"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Branch", cbFilter.Text); ;
			}
			else if (s.Equals("Cash"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Payment", cbFilter.Text); ;
			}
			else if (s.Equals("Ewallet"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Payment", cbFilter.Text); ;
			}
			else if (s.Equals("Credit Card"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Payment", cbFilter.Text); ;
			}
			
			else if (s.Equals("Fashion accessories"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Product line", cbFilter.Text); ;
			}
			else if (s.Equals("Electronic accessories"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Product line", cbFilter.Text); ;
			}
			else if (s.Equals("Food and beverages"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Product line", cbFilter.Text); ;
			}
			else if (s.Equals("Health and beauty"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Product line", cbFilter.Text); ;
			}
			else if (s.Equals("Home and lifestyle"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Product line", cbFilter.Text); ;
			}
			else if (s.Equals("Sports and travel"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "Product line", cbFilter.Text); ;
			}
			else if (s.Equals("Yangon"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "City", cbFilter.Text); ;
			}
			else if (s.Equals("Mandalay"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "City", cbFilter.Text); ;
			}
			else if (s.Equals("Naypyitaw"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "City", cbFilter.Text); ;
			}

			
		}

        private void NoFilter_Click(object sender, EventArgs e)
        {
			dt.DefaultView.RowFilter = string.Empty;
			dt = cp.GetDataTable();
			data.DataSource = dt;
			cbFilter.Visible = false;
			labelFilter.Visible = false;
			labelRange.Visible = false;
			labelTo.Visible = false;
			Range1.Visible = false;
			Range2.Visible = false;
			FilterRange.Visible = false;
			cbCategory.ResetText();
			Range1.Clear();
			Range2.Clear();
		}

        private void FilterRange_Click(object sender, EventArgs e)
        {
			string category = cbCategory.Text;
			if (category.Equals("Unit price"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "Unit price", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;
			}
			else if (category.Equals("Quantity"))
			{
				int r1 = int.Parse(Range1.Text);
				if (r1 == 0)
				{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "Quantity", 1, int.Parse(Range2.Text)); ;
				}else
				{
					dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "Quantity", int.Parse(Range1.Text), int.Parse(Range2.Text)); ;
				}
			}
			else if (category.Equals("Tax"))
			{

				dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "Tax 5%", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;


			}
			else if (category.Equals("Total"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "Total", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;
			}
			else if (category.Equals("COGS"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "cogs", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;
			}
			else if (category.Equals("Gross income"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "gross income", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;
			}
			else if (category.Equals("Rating"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "Rating", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;
			}else if (category.Equals("DateTime"))
            {
				dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "DateTime", DateTime.Parse(Range1.Text), DateTime.Parse(Range2.Text)); ;
			}
		}

		/*
		  foreach(DataRow datarow in dt.Rows)
                {
					foreach(var item in datarow.ItemArray)
                    {
						Console.WriteLine(item);
                    }
                }
		*/
    }

       
    }
