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
using System.Windows.Forms.DataVisualization.Charting;

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
			Graphics();
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

            try { 

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
					}
					else
					{
						dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "Quantity", int.Parse(Range1.Text), int.Parse(Range2.Text)); ;
					}
				}
				else if (category.Equals("Tax"))
				{

					dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.Double') >= '{1}' AND Convert([{0}], 'System.Double') <= '{2}'", "Tax 5%", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;


				}
				else if (category.Equals("Total"))
				{
					dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.Double') >= '{1}' AND Convert([{0}], 'System.Double') <= '{2}'", "Total", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;
				}
				else if (category.Equals("COGS"))
				{
					dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.Double') >= '{1}' AND Convert([{0}], 'System.Double') <= '{2}'", "cogs", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;
				}
				else if (category.Equals("Gross income"))
				{
					dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.Double') >= '{1}' AND Convert([{0}], 'System.Double') <= '{2}'", "gross income", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;
				}
				else if (category.Equals("Rating"))
				{
					dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.Double') >= '{1}' AND Convert([{0}], 'System.Double') <= '{2}'", "Rating", double.Parse(Range1.Text, CultureInfo.InvariantCulture), double.Parse(Range2.Text, CultureInfo.InvariantCulture)); ;
				}
				else if (category.Equals("DateTime"))
				{
					String d1 = "#" + Range1.Text + "#";
					String d2 = "#" + Range2.Text + "#";
					dt.DefaultView.RowFilter = string.Format("Convert([{0}],'System.DateTime') >= '{1}' AND Convert([{0}], 'System.DateTime') <= '{2}'", "DateTime", DateTime.Parse(d1), DateTime.Parse(d2)); ;
				}
            }catch(Exception exp)
            {
				String msj = "Error";
				String rec = "Please enter numeric values in the filter range";
				MessageBox.Show(rec,msj);
            }
           

		}


		private void Graphics()
		{
			int[,] stat = cp.count();
			pieChartInitialize(stat);//Product line
			BarChartInitialize(stat);// Gender
			PointsChartInitialize(stat); //Customer type
			LineChartInitialize(stat);// Branch
			ColumnChartInitialize(stat); //Payment
			
		}

		private void pieChartInitialize(int[,] stat)
		{
			pieChart.Series.Clear();
			pieChart.Legends.Clear();

			//Add a new Legend(if needed) and do some formating
			pieChart.Legends.Add("Product line");
			pieChart.Legends[0].Alignment = StringAlignment.Center;
			pieChart.Legends[0].Title = "Product Line";
			pieChart.Legends[0].BorderColor = Color.Black;

			//Add a new chart-series
			string seriesname = "Product line";
			pieChart.Series.Add(seriesname);
			//set the chart-type
			pieChart.Series[seriesname].ChartType = SeriesChartType.Pie;
			pieChart.Series[seriesname]["PieLabelStyle"] = "Disabled";
			pieChart.Series[seriesname].Points.AddXY("Electronic accessories", stat[0, 0]);
			pieChart.Series[seriesname].Points.AddXY("Fashion accessories", stat[0, 1]);
			pieChart.Series[seriesname].Points.AddXY("Food and beverages", stat[0, 2]);
			pieChart.Series[seriesname].Points.AddXY("Health and beauty", stat[0, 3]);
			pieChart.Series[seriesname].Points.AddXY("Home and lifestyle", stat[0, 4]);
			pieChart.Series[seriesname].Points.AddXY("Sports and travel", stat[0, 5]);



		}

		private void BarChartInitialize(int[,] stat)
		{
			barChart.Series.Clear();
			barChart.Legends.Clear();

			//Add a new Legend(if needed) and do some formating
			barChart.Legends.Add("Gender");
			barChart.Legends[0].LegendStyle = LegendStyle.Table;
			barChart.Legends[0].Docking = Docking.Bottom;
			barChart.Legends[0].Alignment = StringAlignment.Center;
			barChart.Legends[0].Title = "Gender";
			barChart.Legends[0].BorderColor = Color.Black;

			//Add a new chart-series
			string seriesname = "Gender";
			barChart.Series.Add(seriesname);
			//set the chart-type
			barChart.Series[seriesname].ChartType = SeriesChartType.Bar;
			barChart.Series[seriesname]["BarLabelStyle"] = "Disabled";

			//Add some datapoints so the series. in this case you can pass the values to this method
			barChart.Series[seriesname].Points.AddXY("Male", stat[1, 0]);
			barChart.Series[seriesname].Points.AddXY("Female", stat[1, 1]);



		}
		public void PointsChartInitialize(int[,] stat)
		{
			pointChart.Series.Clear();
			pointChart.Legends.Clear();

			//Add a new Legend(if needed) and do some formating
			pointChart.Legends.Add("Customer type");
			pointChart.Legends[0].LegendStyle = LegendStyle.Table;
			pointChart.Legends[0].Docking = Docking.Bottom;
			pointChart.Legends[0].Alignment = StringAlignment.Center;
			pointChart.Legends[0].Title = "Customer Type";
			pointChart.Legends[0].BorderColor = Color.Black;

			//Add a new chart-series
			string seriesname = "Customer Type";
			pointChart.Series.Add(seriesname);
			//set the chart-type
			pointChart.Series[seriesname].ChartType = SeriesChartType.Point;
			pointChart.Series[seriesname]["PointLabelStyle"] = "Disabled";

			//Add some datapoints so the series. in this case you can pass the values to this method
			pointChart.Series[seriesname].Points.AddXY("Normal", stat[2, 0]);
			pointChart.Series[seriesname].Points.AddXY("Member", stat[2, 1]);

		}
		private void LineChartInitialize(int[,] stat)
		{
			lineChart.Series.Clear();
			lineChart.Legends.Clear();

			//Add a new Legend(if needed) and do some formating
			lineChart.Legends.Add("Branch");
			lineChart.Legends[0].LegendStyle = LegendStyle.Table;
			lineChart.Legends[0].Docking = Docking.Bottom;
			lineChart.Legends[0].Alignment = StringAlignment.Center;
			lineChart.Legends[0].Title = "Branch";
			lineChart.Legends[0].BorderColor = Color.Black;

			//Add a new chart-series
			string seriesname = "Branch";
			lineChart.Series.Add(seriesname);
			//set the chart-type
			lineChart.Series[seriesname].ChartType = SeriesChartType.Line;
			lineChart.Series[seriesname]["LineLabelStyle"] = "Disabled";

			//Add some datapoints so the series. in this case you can pass the values to this method
			lineChart.Series[seriesname].Points.AddXY("A", stat[3, 0]);
			lineChart.Series[seriesname].Points.AddXY("B", stat[3, 1]);
			lineChart.Series[seriesname].Points.AddXY("C", stat[3, 2]);

		}

		private void ColumnChartInitialize(int[,] stat)
		{
			columsChart.Series.Clear();
			columsChart.Legends.Clear();

			//Add a new Legend(if needed) and do some formating
			columsChart.Legends.Add("Payment");
			columsChart.Legends[0].LegendStyle = LegendStyle.Table;
			columsChart.Legends[0].Docking = Docking.Bottom;
			columsChart.Legends[0].Alignment = StringAlignment.Center;
			columsChart.Legends[0].Title = "Payment";
			columsChart.Legends[0].BorderColor = Color.Black;

			//Add a new chart-series
			string seriesname = "Payment";
			columsChart.Series.Add(seriesname);
			//set the chart-type to "Point"
			columsChart.Series[seriesname].ChartType = SeriesChartType.Column;
			columsChart.Series[seriesname]["ColumnLabelStyle"] = "Disabled";

			//Add some datapoints so the series. in this case you can pass the values to this method
			columsChart.Series[seriesname].Points.AddXY("Cash", stat[4, 0]);
			columsChart.Series[seriesname].Points.AddXY("EWallet", stat[4, 1]);
			columsChart.Series[seriesname].Points.AddXY("Credit Card", stat[4, 2]);

		}
	}

}


