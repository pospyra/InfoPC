using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InfoPC.Forms
{
    public partial class MemoryUsageChartForm : Form
    {
        private Chart chart;
        private Timer timer;
        private PerformanceCounter memoryCounter;

        public MemoryUsageChartForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            chart = new Chart();
            chart.Dock = DockStyle.Fill;
            Controls.Add(chart);

            ChartArea chartArea = new ChartArea("MainChartArea");
            chart.ChartAreas.Add(chartArea);

            chartArea.AxisY.LabelStyle.Format = "0.0 MB"; // Отображение одного десятичного знака с единицей измерения

            Series memorySeries = new Series("Memory Usage")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.Time,
                YValueType = ChartValueType.Double
            };
            chart.Series.Add(memorySeries);

            timer = new Timer();
            timer.Interval = 1000; // Интервал в миллисекундах (1 секунда)
            timer.Tick += Timer_Tick;
            timer.Start();

            memoryCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            float availableMemory = memoryCounter.NextValue();

            chart.Series["Memory Usage"].Points.AddXY(currentTime, availableMemory);

            chart.Invalidate();
        }
    }
}
