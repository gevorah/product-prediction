
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
            System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.columsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pointChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.Range2 = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.Range1 = new System.Windows.Forms.TextBox();
            pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            pieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            pieChart.Legends.Add(legend1);
            pieChart.Location = new System.Drawing.Point(296, 532);
            pieChart.Name = "pieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            pieChart.Series.Add(series1);
            pieChart.Size = new System.Drawing.Size(232, 182);
            pieChart.TabIndex = 4;
            pieChart.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(289, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 41);
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
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(40, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Statistical Charts";
            // 
            // columsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.columsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.columsChart.Legends.Add(legend2);
            this.columsChart.Location = new System.Drawing.Point(31, 532);
            this.columsChart.Name = "columsChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.columsChart.Series.Add(series2);
            this.columsChart.Size = new System.Drawing.Size(232, 182);
            this.columsChart.TabIndex = 3;
            this.columsChart.Text = "chart1";
            // 
            // pointChart
            // 
            chartArea3.Name = "ChartArea1";
            this.pointChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pointChart.Legends.Add(legend3);
            this.pointChart.Location = new System.Drawing.Point(575, 532);
            this.pointChart.Name = "pointChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pointChart.Series.Add(series3);
            this.pointChart.Size = new System.Drawing.Size(232, 182);
            this.pointChart.TabIndex = 5;
            this.pointChart.Text = "chart3";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Invoice id",
            "Branch",
            "City",
            "Customer Type",
            "Gender ",
            "Product Line",
            "Unit Price",
            "Quantity",
            "Tax",
            "Total",
            "Date",
            "Time",
            "Payment",
            "COGS",
            "Gross margin percentage",
            "Gross income",
            "Rating"});
            this.cbCategory.Location = new System.Drawing.Point(179, 109);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 6;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(585, 116);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(88, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(368, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filter Category";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFilter.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFilter.Location = new System.Drawing.Point(368, 111);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(138, 19);
            this.labelFilter.TabIndex = 10;
            this.labelFilter.Text = "Filter Category";
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRange.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRange.Location = new System.Drawing.Point(466, 114);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(62, 19);
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
            this.labelTo.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTo.Location = new System.Drawing.Point(628, 116);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(26, 19);
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
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(946, 749);
            this.Controls.Add(this.Range1);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.Range2);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.pointChart);
            this.Controls.Add(pieChart);
            this.Controls.Add(this.columsChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label1);
            this.Name = "Interface";
            this.Text = "Sales Control";
            ((System.ComponentModel.ISupportInitialize)(pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart columsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pointChart;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.TextBox Range2;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox Range1;
    }
}

