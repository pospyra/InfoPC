using InfoPC.Forms;
using System;
using System.IO;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace InfoPC
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
            InitializeForm();

        }

        private void InitializeForm()
        {
            saveButton.Click += new EventHandler(SaveButton_Click);
            saveButton.Enabled = false;

            Text = "Информация о системе";
        }


        private string CollectSystemInfo()
        {
            var systemInfo = new StringBuilder();

            AppendPcName(systemInfo);
            AppendSeparator(systemInfo);

            AppendProcessorInfo(systemInfo);
            AppendSeparator(systemInfo);

            AppendMemoryInfo(systemInfo);
            AppendSeparator(systemInfo);

            AppendRamInfo(systemInfo);
            AppendSeparator(systemInfo);

            AppendGpuInfo(systemInfo);
            AppendSeparator(systemInfo);

            AppendMotherboardInfo(systemInfo);
            AppendSeparator(systemInfo);

            AppendDiskInfo(systemInfo);
            AppendSeparator(systemInfo);

            AppendOsInfo(systemInfo);

            return systemInfo.ToString();
        }

        private void AppendSeparator(StringBuilder sb)
        {
            sb.AppendLine("-------------------------------------------------------------------------------------------------------------------------------");
        }

        private void AppendPcName(StringBuilder sb)
        {
            sb.AppendLine($"Название ПК: {Environment.MachineName}");
        }

        private void AppendProcessorInfo(StringBuilder sb)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                sb.AppendLine($"Процессор: {obj["Name"]?.ToString()}");
            }
        }

        private void AppendMemoryInfo(StringBuilder sb)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                long totalMemoryBytes = Convert.ToInt64(obj["TotalVisibleMemorySize"]) * 1024;
                sb.AppendLine($"Общая память: {totalMemoryBytes / (1024 * 1024)} МБ");
            }
        }

        private void AppendRamInfo(StringBuilder sb)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            int ramModuleCount = 0;
            long totalRamCapacity = 0;

            foreach (ManagementObject obj in searcher.Get())
            {
                ramModuleCount++;
                string manufacturer = obj["Manufacturer"]?.ToString() ?? "Неизвестно";
                string partNumber = obj["PartNumber"]?.ToString()?.Trim() ?? "Неизвестно";
                long capacityBytes = Convert.ToInt64(obj["Capacity"]);
                long capacityGB = capacityBytes / (1024 * 1024 * 1024);
                totalRamCapacity += capacityBytes;
                string speedMHz = obj["Speed"]?.ToString() ?? "Неизвестно";

                sb.AppendLine($"Оперативная память {ramModuleCount}: {manufacturer} {partNumber} {capacityGB}ГБ {speedMHz}МГц");
            }

            if (ramModuleCount > 0)
            {
                sb.AppendLine($"Оперативная память (Всего): {totalRamCapacity / (1024 * 1024 * 1024)}ГБ");
            }
        }

        private void AppendGpuInfo(StringBuilder sb)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject obj in searcher.Get())
            {
                sb.AppendLine($"Видеокарта: {obj["Name"]?.ToString()}");
            }
        }

        private void AppendMotherboardInfo(StringBuilder sb)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject obj in searcher.Get())
            {
                sb.AppendLine($"Материнская плата: {obj["Manufacturer"]?.ToString()} {obj["Product"]?.ToString()}");
                sb.AppendLine($"Серийный номер: {obj["SerialNumber"]?.ToString()}");
            }
        }

        private void AppendDiskInfo(StringBuilder sb)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            int diskNumber = 1;

            foreach (ManagementObject obj in searcher.Get())
            {
                string model = obj["Model"]?.ToString()?.Trim() ?? "Неизвестная модель";
                ulong sizeBytes = obj["Size"] != null ? Convert.ToUInt64(obj["Size"]) : 0;
                double sizeGB = sizeBytes / (1024.0 * 1024 * 1024);

                sb.AppendLine($"Накопитель {diskNumber}: {model} - {sizeGB:F2} ГБ");
                diskNumber++;
            }
        }

        private void AppendOsInfo(StringBuilder sb)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                sb.AppendLine($"Операционная система: {obj["Caption"]?.ToString()} ({obj["Version"]?.ToString()})");
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files|*.txt",
                Title = "Сохранить информацию"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, InfoTextBox.Text);
            }
        }


        private void collectButton_Click_1(object sender, EventArgs e)
        {
            string systemInfo = CollectSystemInfo();
            InfoTextBox.Text = systemInfo;

            if (!string.IsNullOrEmpty(InfoTextBox.Text))
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MemoryUsageChartForm().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CpuUsageChartForm().ShowDialog();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
