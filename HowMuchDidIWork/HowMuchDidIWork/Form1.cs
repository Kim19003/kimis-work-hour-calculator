using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HowMuchDidIWork
{
    public partial class Form1 : Form
    {
        readonly string appName = "Kimin työpäivälaskuri";

        readonly string tasksFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Tehtävät.txt");

        public Form1()
        {
            InitializeComponent();

            MaximizeBox = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Location = new Point(Properties.Settings.Default.Location.X, Properties.Settings.Default.Location.Y);

            UpdateTaskDisplayWithFileData();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = Location;
            Properties.Settings.Default.Save();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                UpdateTaskDisplayWithFileData();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void MakeNewTask(string startTime, string endTime, string description)
        {
            if (!string.IsNullOrEmpty(startTime) && !string.IsNullOrEmpty(endTime))
            {
                double? totalTime = ConvertToTimeAndCalculateTotalTime(startTime, endTime);

                if (totalTime != null && startTime.Contains(":") && endTime.Contains(":"))
                {
                    string taskFormat = $"{startTime} - {endTime} ({totalTime.ToString().Replace(",", ".")} tuntia): {description}";

                    UpdateTasksDisplayWithTask(taskFormat);

                    UpdateTasksFile(ReadTaskDisplayData());
                }
                else
                {
                    DisplayInfo("Aloitus- ja/tai lopetusaika on asetettu väärin", InfoType.Error);
                }
            }
            else
            {
                DisplayInfo("Aloitus- ja/tai lopetusaikaa ei ole asetettu", InfoType.Error);
            }
        }

        private double? ConvertToTimeAndCalculateTotalTime(string startTime, string endTime)
        {
            double startHours, startMinutes, endHours, endMinutes;
            
            try
            {
                startHours = double.Parse(startTime.Substring(0, startTime.IndexOf(':')));
                startMinutes = double.Parse(startTime.Substring(startTime.IndexOf(':') + 1));

                endHours = double.Parse(endTime.Substring(0, endTime.IndexOf(':')));
                endMinutes = double.Parse(endTime.Substring(endTime.IndexOf(':') + 1));

                if (startMinutes < 0 || startMinutes > 59 || endMinutes < 0 || endMinutes > 59)
                {
                    return null;
                }

                string overallTimeString = ((endHours + (endMinutes / 100.0)) - (startHours + (startMinutes / 100.0))).ToString().Replace(',', ':');

                double overallHours = !overallTimeString.Contains(":") ? double.Parse(overallTimeString) :
                    double.Parse(overallTimeString.Substring(0, overallTimeString.IndexOf(':')));

                double _overallMinutes = !overallTimeString.Contains(":") ? 0 : double.Parse(overallTimeString.Substring(overallTimeString.IndexOf(':') + 1)),
                    overallMinutes = (_overallMinutes > 0 && _overallMinutes < 11 || _overallMinutes == 20 || _overallMinutes == 30 ||
                    _overallMinutes == 40 || _overallMinutes == 50) ? _overallMinutes * 10 : _overallMinutes;

                return Math.Round(overallHours + 10.0 / (60.0 / overallMinutes) / 10.0, 2);
            }
            catch
            {
                DisplayInfo("Aloitus- ja/tai lopetusajan muuntaminen epäonnistui", InfoType.Error);
            }

            return null;
        }

        private void UpdateTasksFile(string content)
        {
            ClearDisplayInfoIfShowing();

            File.WriteAllText(tasksFilePath, content);
        }

        private void ClearTasksFileAndTaskDisplay()
        {
            ClearDisplayInfoIfShowing();

            File.WriteAllText(tasksFilePath, "");
            tasksDisplayRichTextBox.Text = "";
        }

        private void UpdateTasksDisplayWithTask(string taskFormat)
        {
            ClearDisplayInfoIfShowing();

            if (!string.IsNullOrEmpty(taskFormat))
            {
                tasksDisplayRichTextBox.Text += taskFormat + "\n";
            }
        }

        private void UpdateTaskDisplayWithFileData()
        {
            ClearDisplayInfoIfShowing();

            if (File.Exists(tasksFilePath))
            {
                tasksDisplayRichTextBox.Text = ReadFromTasksFile();
            }
        }

        private string ReadTaskDisplayData()
        {
            return tasksDisplayRichTextBox.Text;
        }

        private string ReadFromTasksFile()
        {
            if (File.Exists(tasksFilePath))
            {
                return File.ReadAllText(tasksFilePath);
            }

            return null;
        }

        private void taskDescriptionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            ClearDisplayInfoIfShowing();

            if (e.KeyCode == Keys.Enter)
            {
                MakeNewTask(taskStartTimeTextBox.Text, taskEndTimeTextBox.Text, taskDescriptionTextBox.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tasksDisplayRichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            ClearDisplayInfoIfShowing();

            if (e.KeyCode == Keys.Enter)
            {
                UpdateTasksFile(ReadTaskDisplayData()); // Tähän MessageBox tai jokin muu ratkaisu?
                DisplayInfo("Päivitit onnistuneesti tekemäsi muutokset tiedostoon", InfoType.Normal);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            ClearDisplayInfoIfShowing();

            MakeNewTask(taskStartTimeTextBox.Text, taskEndTimeTextBox.Text, taskDescriptionTextBox.Text);
        }

        private void resetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ClearDisplayInfoIfShowing();

            if (resetCheckBox.Checked)
            {
                if (MessageBox.Show("Oletko varma, että haluat pyyhkiä tehtävähistorian?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearTasksFileAndTaskDisplay();

                    DisplayInfo("Pyyhit onnistuneesti tehtävähistoriasi", InfoType.Normal);
                }

                resetCheckBox.Checked = false;
            }
        }

        private void DisplayInfo(string info, InfoType infoType) // Tätä voisi kehittää myöhemmin eteenpäin?
        {
            switch (infoType)
            {
                case InfoType.Normal:
                    infoLabel.Text = info;
                    infoLabel.ForeColor = SystemColors.WindowText;
                    infoLabel.BackColor = Color.NavajoWhite;
                    break;
                case InfoType.Error:
                    infoLabel.Text = info;
                    infoLabel.ForeColor = Color.Red;
                    infoLabel.BackColor = Color.NavajoWhite;
                    break;
            }
        }

        private void ClearDisplayInfoIfShowing()
        {
            if (infoLabel.Text.Length > 0)
            {
                ResetDisplayInfo();
            }
        }

        private void ResetDisplayInfo()
        {
            infoLabel.Text = "";
            infoLabel.ForeColor = SystemColors.WindowText;
            infoLabel.BackColor = Color.Transparent;
        }
    }
}
