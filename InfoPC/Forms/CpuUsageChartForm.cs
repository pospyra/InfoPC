using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InfoPC.Forms
{
    public partial class CpuUsageChartForm : Form
    {
        private Chart chart;
        private Timer timer;
        private PerformanceCounter cpuUsageCounter;

        public CpuUsageChartForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Инициализация графика
            chart = new Chart();
            chart.Dock = DockStyle.Fill;

            var series = new Series("CPU Usage");
            series.ChartType = SeriesChartType.Line;
            chart.Series.Add(series);

            chart.ChartAreas.Add(new ChartArea());
            chart.ChartAreas[0].AxisY.Maximum = 100;
            chart.ChartAreas[0].AxisY.Minimum = 0;

            chart.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.0}%";
            Controls.Add(chart);

            timer = new Timer();
            timer.Interval = 1000; // Интервал обновления в миллисекундах (1 секунда)
            timer.Tick += Timer_Tick;
            timer.Start();

            cpuUsageCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            float cpuUsage = cpuUsageCounter.NextValue();

            var series = chart.Series["CPU Usage"];
            series.Points.AddY(cpuUsage);

            if (series.Points.Count > 60)
            {
                series.Points.RemoveAt(0);
            }

            chart.ChartAreas[0].AxisX.Maximum = series.Points.Count;
            chart.ChartAreas[0].AxisX.Minimum = 0;
        }
    }
}
