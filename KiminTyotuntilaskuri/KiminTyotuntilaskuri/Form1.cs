using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace HowMuchDidIWork
{
    public partial class Form1 : Form
    {
        readonly string appName = "Kimin työtuntilaskuri";

        readonly string tasksFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"\Tehtävät\" + "Tehtävät.txt");

        readonly int resetNotificationHours = 12;

        private int ticks = 0;
        private double overallTime = 0.0;

        private readonly Color infoLabelAlertNormalForeColor = Color.Blue,
            infoLabelAlertNormalBackColor = Color.Transparent;
        private readonly Color infoLabelAlertErrorForeColor = Color.Red,
            infoLabelAlertErrorBackColor = Color.Transparent;

        public Form1()
        {
            InitializeComponent();

            MaximizeBox = false;

            console.Size = new Size(512, 506);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Location = new Point(KiminTyotuntilaskuri.Properties.Settings.Default.Location.X, KiminTyotuntilaskuri.Properties.Settings.Default.Location.Y);
            taskStartTimeTextBox.Text = KiminTyotuntilaskuri.Properties.Settings.Default.StartTimeText;
            taskEndTimeTextBox.Text = KiminTyotuntilaskuri.Properties.Settings.Default.EndTimeText;
            taskDescriptionTextBox.Text = KiminTyotuntilaskuri.Properties.Settings.Default.DescriptionText;
            overallHoursValueLabel.Text = $"{KiminTyotuntilaskuri.Properties.Settings.Default.OverallTime}";

            KiminTyotuntilaskuri.Properties.Settings.Default.ApplicationStartDate = DateTime.Now;

            ResetDisplayInfo();

            UpdateTaskDisplayWithFileData();

            if (KiminTyotuntilaskuri.Properties.Settings.Default.ApplicationStartDate > KiminTyotuntilaskuri.Properties.Settings.Default.ApplicationStopDate.AddHours(resetNotificationHours))
            {
                if (MessageBox.Show($"Käytit sovellusta viimeksi yli {resetNotificationHours} tuntia sitten.\nHaluatko aloittaa suoraan uuden päivän (varmuuskopio luodaan)?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StartNewDay();
                }
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            KiminTyotuntilaskuri.Properties.Settings.Default.Location = Location;
            KiminTyotuntilaskuri.Properties.Settings.Default.StartTimeText = taskStartTimeTextBox.Text;
            KiminTyotuntilaskuri.Properties.Settings.Default.EndTimeText = taskEndTimeTextBox.Text;
            KiminTyotuntilaskuri.Properties.Settings.Default.DescriptionText = taskDescriptionTextBox.Text;
            KiminTyotuntilaskuri.Properties.Settings.Default.OverallTime = Convert.ToDouble(overallHoursValueLabel.Text);

            KiminTyotuntilaskuri.Properties.Settings.Default.ApplicationStopDate = DateTime.Now;

            KiminTyotuntilaskuri.Properties.Settings.Default.Save();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    UpdateTaskDisplayWithFileData();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.F10:
                    if (!console.Visible)
                        console.Visible = true;
                    else
                        console.Visible = false;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
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

                    taskStartTimeTextBox.Text = taskEndTimeTextBox.Text;
                    taskEndTimeTextBox.Text = "";
                    taskDescriptionTextBox.Text = "";

                    overallTime += totalTime ?? 0.0;

                    overallHoursValueLabel.Text = $"{overallTime}";
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
            Time sTime, eTime;
            
            try
            {
                int startHours = int.Parse(startTime.Substring(0, startTime.IndexOf(':'))), startMinutes = int.Parse(startTime.Substring(startTime.IndexOf(':') + 1));
                int endHours = int.Parse(endTime.Substring(0, endTime.IndexOf(':'))), endMinutes = int.Parse(endTime.Substring(endTime.IndexOf(':') + 1));

                if (startHours > 23 || startHours < 1 || endHours > 23 || endHours < 1 ||
                    startMinutes > 59 || startMinutes < 0 || endMinutes > 59 || endMinutes < 0)
                {
                    throw new Exception("Hours can't be over 23 and less than 1, and minutes can't be over than 59 and less than 0");
                }

                sTime = new Time(startHours, startMinutes);
                eTime = new Time(endHours, endMinutes);

                eTime.RemoveTime(sTime);

                return Math.Round((double)eTime.Hour + 10.0 / (60.0 / (double)eTime.Minute) / 10.0, 2);
            }
            catch
            {
                DisplayInfo("Aloitus- ja/tai lopetusajan muuntaminen epäonnistui", InfoType.Error);
            }

            return null;
        }

        private void UpdateTasksFile(string content)
        {
            File.WriteAllText(tasksFilePath, content);
        }

        private void ClearTasksFileAndTaskDisplay()
        {
            File.WriteAllText(tasksFilePath, "");
            tasksDisplayRichTextBox.Text = "";
        }

        private void UpdateTasksDisplayWithTask(string taskFormat)
        {
            if (!string.IsNullOrEmpty(taskFormat))
            {
                tasksDisplayRichTextBox.Text += taskFormat + "\n";
            }
        }

        private void UpdateTaskDisplayWithFileData()
        {
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
            if (e.KeyCode == Keys.Enter)
            {
                MakeNewTask(taskStartTimeTextBox.Text, taskEndTimeTextBox.Text, taskDescriptionTextBox.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tasksDisplayRichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    UpdateTasksFile(ReadTaskDisplayData()); // Tähän MessageBox tai jokin muu ratkaisu?
                    DisplayInfo("Päivitit onnistuneesti tekemäsi muutokset tiedostoon", InfoType.Normal);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.F10:
                    if (!console.Visible)
                        console.Visible = true;
                    else
                        console.Visible = false;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            MakeNewTask(taskStartTimeTextBox.Text, taskEndTimeTextBox.Text, taskDescriptionTextBox.Text);
        }

        private void startNewDayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (startNewDayCheckBox.Checked)
            {
                if (MessageBox.Show("Oletko varma, että haluat aloittaa uuden päivän (varmuuskopio luodaan)?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StartNewDay();
                }
            }

            startNewDayCheckBox.Checked = false;
        }

        private void DisplayInfo(string info, InfoType infoType) // Tätä voisi kehittää myöhemmin eteenpäin?
        {
            switch (infoType)
            {
                case InfoType.Normal:
                    StartTimer();
                    infoLabel.Text = info;
                    infoLabel.ForeColor = infoLabelAlertNormalForeColor;
                    infoLabel.BackColor = infoLabelAlertNormalBackColor;
                    break;
                case InfoType.Error:
                    StartTimer();
                    infoLabel.Text = info;
                    infoLabel.ForeColor = infoLabelAlertErrorForeColor;
                    infoLabel.BackColor = infoLabelAlertErrorBackColor;
                    break;
            }
        }

        private void ResetDisplayInfo()
        {
            infoLabel.Text = "";
            infoLabel.ForeColor = infoLabelAlertNormalForeColor;
            infoLabel.BackColor = Color.Transparent;
        }

        private void console_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    NewConsoleCommandLine(ReadConsoleLine());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.F10:
                    if (!console.Visible)
                        console.Visible = true;
                    else
                        console.Visible = false;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void StartTimer()
        {
            if (ticks > 0)
            {
                timer1.Stop();

                ticks = 0;
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;

            if (ticks == 5) // Seconds
            {
                ResetDisplayInfo();

                timer1.Stop();

                ticks = 0;
            }
        }

        private void startedNowButton_Click(object sender, EventArgs e)
        {
            taskStartTimeTextBox.Text = DateTime.Now.ToString("H:mm").Replace(".", ":");
        }

        private void endedNowButton_Click(object sender, EventArgs e)
        {
            taskEndTimeTextBox.Text = DateTime.Now.ToString("H:mm").Replace(".", ":");
        }

        private void switchTimesButton_Click(object sender, EventArgs e)
        {
            string startTimeText = taskStartTimeTextBox.Text;
            string endTimeText = taskEndTimeTextBox.Text;

            taskStartTimeTextBox.Text = endTimeText;
            taskEndTimeTextBox.Text = startTimeText;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oletko varma, että haluat pyyhkiä syötelaatikot?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                taskStartTimeTextBox.Text = "";
                taskEndTimeTextBox.Text = "";
                taskDescriptionTextBox.Text = "";
            }
        }

        private void resetAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (resetAllCheckBox.Checked)
            {
                if (MessageBox.Show("Oletko varma, että haluat pyyhkiä kaiken?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetAll();
                }
            }

            resetAllCheckBox.Checked = false;
        }

        private void ResetAll()
        {
            taskStartTimeTextBox.Text = "";
            taskEndTimeTextBox.Text = "";
            taskDescriptionTextBox.Text = "";

            ClearTasksFileAndTaskDisplay();

            overallHoursValueLabel.Text = "0";
        }

        private void StartNewDay()
        {
            File.WriteAllText(tasksFilePath.Replace(".txt", " ") + $"{DateTime.Now.ToString("G").Replace('.', '-')}.txt", File.ReadAllText(tasksFilePath));

            ResetAll();
        }

        private void NewConsoleCommandLine(string line)
        {
            switch (line)
            {
                case "quit":
                    Environment.Exit(0);
                    break;
            }
        }

        private string ReadConsoleLine()
        {
            string[] consoleLines = console.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            if (consoleLines.Length > 0)
            {
                return consoleLines[consoleLines.Length - 1];
            }

            return "";
        }
    }
}
