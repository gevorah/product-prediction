
namespace product_prediction.UI

{
    partial class Interface
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea26 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend26 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea27 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend27 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea28 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend28 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend29 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend30 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.data = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.columsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pointChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.Range2 = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.Range1 = new System.Windows.Forms.TextBox();
            this.NoFilter = new System.Windows.Forms.Button();
            this.FilterRange = new System.Windows.Forms.Button();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(11, 45);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(970, 500);
            this.data.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(40, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 2;
            // 
            // columsChart
            // 
            chartArea26.Name = "ChartArea1";
            this.columsChart.ChartAreas.Add(chartArea26);
            legend26.Name = "Legend1";
            this.columsChart.Legends.Add(legend26);
            this.columsChart.Location = new System.Drawing.Point(6, 13);
            this.columsChart.Name = "columsChart";
            series26.ChartArea = "ChartArea1";
            series26.Legend = "Legend1";
            series26.Name = "Series1";
            this.columsChart.Series.Add(series26);
            this.columsChart.Size = new System.Drawing.Size(290, 200);
            this.columsChart.TabIndex = 3;
            this.columsChart.Text = "chart1";
            // 
            // pointChart
            // 
            chartArea27.Name = "ChartArea1";
            this.pointChart.ChartAreas.Add(chartArea27);
            legend27.Name = "Legend1";
            this.pointChart.Legends.Add(legend27);
            this.pointChart.Location = new System.Drawing.Point(302, 13);
            this.pointChart.Name = "pointChart";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series27.Legend = "Legend1";
            series27.Name = "Series1";
            this.pointChart.Series.Add(series27);
            this.pointChart.Size = new System.Drawing.Size(290, 200);
            this.pointChart.TabIndex = 5;
            this.pointChart.Text = "chart3";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Branch",
            "City",
            "Customer type",
            "Gender",
            "Product line",
            "Unit price",
            "Quantity",
            "Tax",
            "Total",
            "DateTime",
            "Payment",
            "COGS",
            "Gross income",
            "Rating"});
            this.cbCategory.Location = new System.Drawing.Point(100, 13);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 6;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(423, 13);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 7;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFilter.Location = new System.Drawing.Point(290, 13);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(127, 20);
            this.labelFilter.TabIndex = 10;
            this.labelFilter.Text = "Filter Category";
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRange.Location = new System.Drawing.Point(290, 13);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(62, 20);
            this.labelRange.TabIndex = 11;
            this.labelRange.Text = "Range";
            // 
            // Range2
            // 
            this.Range2.Location = new System.Drawing.Point(459, 13);
            this.Range2.Name = "Range2";
            this.Range2.Size = new System.Drawing.Size(64, 20);
            this.Range2.TabIndex = 12;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTo.Location = new System.Drawing.Point(428, 13);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 20);
            this.labelTo.TabIndex = 13;
            this.labelTo.Text = "to";
            // 
            // Range1
            // 
            this.Range1.Location = new System.Drawing.Point(358, 13);
            this.Range1.Name = "Range1";
            this.Range1.Size = new System.Drawing.Size(64, 20);
            this.Range1.TabIndex = 14;
            // 
            // NoFilter
            // 
            this.NoFilter.Location = new System.Drawing.Point(906, 11);
            this.NoFilter.Name = "NoFilter";
            this.NoFilter.Size = new System.Drawing.Size(75, 23);
            this.NoFilter.TabIndex = 15;
            this.NoFilter.Text = "No filter";
            this.NoFilter.UseVisualStyleBackColor = true;
            this.NoFilter.Click += new System.EventHandler(this.NoFilter_Click);
            // 
            // FilterRange
            // 
            this.FilterRange.Location = new System.Drawing.Point(550, 11);
            this.FilterRange.Name = "FilterRange";
            this.FilterRange.Size = new System.Drawing.Size(75, 23);
            this.FilterRange.TabIndex = 16;
            this.FilterRange.Text = "Filter";
            this.FilterRange.UseVisualStyleBackColor = true;
            this.FilterRange.Click += new System.EventHandler(this.FilterRange_Click);
            // 
            // pieChart
            // 
            chartArea28.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea28);
            legend28.Name = "Legend1";
            this.pieChart.Legends.Add(legend28);
            this.pieChart.Location = new System.Drawing.Point(600, 130);
            this.pieChart.Name = "pieChart";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series28.Legend = "Legend1";
            series28.Name = "Series1";
            this.pieChart.Series.Add(series28);
            this.pieChart.Size = new System.Drawing.Size(290, 200);
            this.pieChart.TabIndex = 17;
            this.pieChart.Text = "chart1";
            // 
            // lineChart
            // 
            chartArea29.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea29);
            legend29.Name = "Legend1";
            this.lineChart.Legends.Add(legend29);
            this.lineChart.Location = new System.Drawing.Point(6, 250);
            this.lineChart.Name = "lineChart";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Legend = "Legend1";
            series29.Name = "Series1";
            this.lineChart.Series.Add(series29);
            this.lineChart.Size = new System.Drawing.Size(290, 200);
            this.lineChart.TabIndex = 18;
            this.lineChart.Text = "lineChart";
            // 
            // barChart
            // 
            chartArea30.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea30);
            legend30.Name = "Legend1";
            this.barChart.Legends.Add(legend30);
            this.barChart.Location = new System.Drawing.Point(302, 250);
            this.barChart.Name = "barChart";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series30.Legend = "Legend1";
            series30.Name = "Series1";
            this.barChart.Series.Add(series30);
            this.barChart.Size = new System.Drawing.Size(290, 200);
            this.barChart.TabIndex = 19;
            this.barChart.Text = "lineChart";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(2, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1000, 580);
            this.tabs.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.NoFilter);
            this.tabPage1.Controls.Add(this.FilterRange);
            this.tabPage1.Controls.Add(this.data);
            this.tabPage1.Controls.Add(this.cbCategory);
            this.tabPage1.Controls.Add(this.labelTo);
            this.tabPage1.Controls.Add(this.Range1);
            this.tabPage1.Controls.Add(this.Range2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbFilter);
            this.tabPage1.Controls.Add(this.labelFilter);
            this.tabPage1.Controls.Add(this.labelRange);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales Control";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.columsChart);
            this.tabPage2.Controls.Add(this.pieChart);
            this.tabPage2.Controls.Add(this.barChart);
            this.tabPage2.Controls.Add(this.lineChart);
            this.tabPage2.Controls.Add(this.pointChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphics";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1004, 581);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.label2);
            this.Name = "Interface";
            this.Text = "Sales Control";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart columsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.TextBox Range2;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox Range1;
        private System.Windows.Forms.Button NoFilter;
        private System.Windows.Forms.Button FilterRange;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pointChart;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

