
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(289, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Control";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(47, 151);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(724, 266);
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
            this.label2.Size = new System.Drawing.Size(298, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Statistical Charts";
            // 
            // columsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.columsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.columsChart.Legends.Add(legend1);
            this.columsChart.Location = new System.Drawing.Point(31, 532);
            this.columsChart.Name = "columsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.columsChart.Series.Add(series1);
            this.columsChart.Size = new System.Drawing.Size(220, 87);
            this.columsChart.TabIndex = 3;
            this.columsChart.Text = "chart1";
            // 
            // pointChart
            // 
            chartArea2.Name = "ChartArea1";
            this.pointChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pointChart.Legends.Add(legend2);
            this.pointChart.Location = new System.Drawing.Point(31, 636);
            this.pointChart.Name = "pointChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pointChart.Series.Add(series2);
            this.pointChart.Size = new System.Drawing.Size(220, 92);
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
            this.cbCategory.Location = new System.Drawing.Point(179, 109);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 6;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(585, 116);
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
            this.label3.Location = new System.Drawing.Point(88, 109);
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
            this.labelFilter.Location = new System.Drawing.Point(390, 117);
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
            this.labelRange.Location = new System.Drawing.Point(466, 114);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(62, 20);
            this.labelRange.TabIndex = 11;
            this.labelRange.Text = "Range";
            // 
            // Range2
            // 
            this.Range2.Location = new System.Drawing.Point(660, 118);
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
            this.labelTo.Location = new System.Drawing.Point(628, 116);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 20);
            this.labelTo.TabIndex = 13;
            this.labelTo.Text = "to";
            // 
            // Range1
            // 
            this.Range1.Location = new System.Drawing.Point(555, 116);
            this.Range1.Name = "Range1";
            this.Range1.Size = new System.Drawing.Size(64, 20);
            this.Range1.TabIndex = 14;
            // 
            // NoFilter
            // 
            this.NoFilter.Location = new System.Drawing.Point(826, 114);
            this.NoFilter.Name = "NoFilter";
            this.NoFilter.Size = new System.Drawing.Size(75, 23);
            this.NoFilter.TabIndex = 15;
            this.NoFilter.Text = "No filter";
            this.NoFilter.UseVisualStyleBackColor = true;
            this.NoFilter.Click += new System.EventHandler(this.NoFilter_Click);
            // 
            // FilterRange
            // 
            this.FilterRange.Location = new System.Drawing.Point(732, 116);
            this.FilterRange.Name = "FilterRange";
            this.FilterRange.Size = new System.Drawing.Size(75, 23);
            this.FilterRange.TabIndex = 16;
            this.FilterRange.Text = "Filter";
            this.FilterRange.UseVisualStyleBackColor = true;
            this.FilterRange.Click += new System.EventHandler(this.FilterRange_Click);
            // 
            // pieChart
            // 
            chartArea3.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pieChart.Legends.Add(legend3);
            this.pieChart.Location = new System.Drawing.Point(673, 532);
            this.pieChart.Name = "pieChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pieChart.Series.Add(series3);
            this.pieChart.Size = new System.Drawing.Size(228, 182);
            this.pieChart.TabIndex = 17;
            this.pieChart.Text = "chart1";
            // 
            // lineChart
            // 
            chartArea4.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.lineChart.Legends.Add(legend4);
            this.lineChart.Location = new System.Drawing.Point(306, 532);
            this.lineChart.Name = "lineChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.lineChart.Series.Add(series4);
            this.lineChart.Size = new System.Drawing.Size(233, 87);
            this.lineChart.TabIndex = 18;
            this.lineChart.Text = "lineChart";
            // 
            // barChart
            // 
            chartArea5.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.barChart.Legends.Add(legend5);
            this.barChart.Location = new System.Drawing.Point(306, 641);
            this.barChart.Name = "barChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.barChart.Series.Add(series5);
            this.barChart.Size = new System.Drawing.Size(233, 87);
            this.barChart.TabIndex = 19;
            this.barChart.Text = "lineChart";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(939, 749);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.FilterRange);
            this.Controls.Add(this.NoFilter);
            this.Controls.Add(this.Range1);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.Range2);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.pointChart);
            this.Controls.Add(this.columsChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label1);
            this.Name = "Interface";
            this.Text = "Sales Control";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}

