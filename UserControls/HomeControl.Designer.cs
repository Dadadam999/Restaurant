
namespace Restaurant
{
    partial class HomeControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ClientChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CentralDock = new System.Windows.Forms.FlowLayoutPanel();
            this.ToolDock = new System.Windows.Forms.Panel();
            this.UseFilter = new System.Windows.Forms.Button();
            this.EndFilterDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.StartFilterDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientChart)).BeginInit();
            this.CentralDock.SuspendLayout();
            this.ToolDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientChart
            // 
            this.ClientChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            chartArea1.Name = "ChartArea1";
            this.ClientChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ClientChart.Legends.Add(legend1);
            this.ClientChart.Location = new System.Drawing.Point(3, 3);
            this.ClientChart.Name = "ClientChart";
            this.ClientChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ClientChart.Series.Add(series1);
            this.ClientChart.Size = new System.Drawing.Size(344, 213);
            this.ClientChart.TabIndex = 3;
            this.ClientChart.Text = "chart1";
            this.ClientChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // CentralDock
            // 
            this.CentralDock.Controls.Add(this.ClientChart);
            this.CentralDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralDock.Location = new System.Drawing.Point(0, 34);
            this.CentralDock.Name = "CentralDock";
            this.CentralDock.Size = new System.Drawing.Size(753, 379);
            this.CentralDock.TabIndex = 4;
            // 
            // ToolDock
            // 
            this.ToolDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.ToolDock.Controls.Add(this.UseFilter);
            this.ToolDock.Controls.Add(this.EndFilterDate);
            this.ToolDock.Controls.Add(this.label2);
            this.ToolDock.Controls.Add(this.StartFilterDate);
            this.ToolDock.Controls.Add(this.label1);
            this.ToolDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolDock.Location = new System.Drawing.Point(0, 0);
            this.ToolDock.Name = "ToolDock";
            this.ToolDock.Size = new System.Drawing.Size(753, 34);
            this.ToolDock.TabIndex = 5;
            // 
            // UseFilter
            // 
            this.UseFilter.AutoSize = true;
            this.UseFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.UseFilter.FlatAppearance.BorderSize = 0;
            this.UseFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseFilter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UseFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.UseFilter.Location = new System.Drawing.Point(494, 0);
            this.UseFilter.Name = "UseFilter";
            this.UseFilter.Size = new System.Drawing.Size(107, 34);
            this.UseFilter.TabIndex = 6;
            this.UseFilter.Text = "Применить";
            this.UseFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseFilter.UseVisualStyleBackColor = true;
            // 
            // EndFilterDate
            // 
            this.EndFilterDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.EndFilterDate.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.EndFilterDate.Location = new System.Drawing.Point(317, 0);
            this.EndFilterDate.Name = "EndFilterDate";
            this.EndFilterDate.Size = new System.Drawing.Size(177, 23);
            this.EndFilterDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(246, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "ПО";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartFilterDate
            // 
            this.StartFilterDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StartFilterDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.StartFilterDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.StartFilterDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.StartFilterDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.StartFilterDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.StartFilterDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartFilterDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartFilterDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartFilterDate.Location = new System.Drawing.Point(68, 0);
            this.StartFilterDate.Name = "StartFilterDate";
            this.StartFilterDate.Size = new System.Drawing.Size(178, 23);
            this.StartFilterDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "С";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.CentralDock);
            this.Controls.Add(this.ToolDock);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(753, 413);
            ((System.ComponentModel.ISupportInitialize)(this.ClientChart)).EndInit();
            this.CentralDock.ResumeLayout(false);
            this.ToolDock.ResumeLayout(false);
            this.ToolDock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ClientChart;
        private System.Windows.Forms.FlowLayoutPanel CentralDock;
        private System.Windows.Forms.Panel ToolDock;
        private System.Windows.Forms.DateTimePicker EndFilterDate;
        private System.Windows.Forms.DateTimePicker StartFilterDate;
        private System.Windows.Forms.Button UseFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
