namespace HowMuchDidIWork
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.taskStartTimeTextBox = new System.Windows.Forms.TextBox();
            this.taskEndTimeTextBox = new System.Windows.Forms.TextBox();
            this.isolatorLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.overallHoursValueLabel = new System.Windows.Forms.Label();
            this.overallHoursTextLabel = new System.Windows.Forms.Label();
            this.resetAllCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.switchTimesButton = new System.Windows.Forms.Button();
            this.endedNowButton = new System.Windows.Forms.Button();
            this.startedNowButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.startNewDayCheckBox = new System.Windows.Forms.CheckBox();
            this.tasksDisplayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.console = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // taskStartTimeTextBox
            // 
            this.taskStartTimeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskStartTimeTextBox.Location = new System.Drawing.Point(149, 50);
            this.taskStartTimeTextBox.MaxLength = 5;
            this.taskStartTimeTextBox.Name = "taskStartTimeTextBox";
            this.taskStartTimeTextBox.Size = new System.Drawing.Size(66, 26);
            this.taskStartTimeTextBox.TabIndex = 0;
            this.taskStartTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // taskEndTimeTextBox
            // 
            this.taskEndTimeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskEndTimeTextBox.Location = new System.Drawing.Point(242, 50);
            this.taskEndTimeTextBox.MaxLength = 5;
            this.taskEndTimeTextBox.Name = "taskEndTimeTextBox";
            this.taskEndTimeTextBox.Size = new System.Drawing.Size(66, 26);
            this.taskEndTimeTextBox.TabIndex = 2;
            this.taskEndTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // isolatorLabel
            // 
            this.isolatorLabel.AutoSize = true;
            this.isolatorLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isolatorLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.isolatorLabel.Location = new System.Drawing.Point(222, 52);
            this.isolatorLabel.Name = "isolatorLabel";
            this.isolatorLabel.Size = new System.Drawing.Size(16, 22);
            this.isolatorLabel.TabIndex = 2;
            this.isolatorLabel.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.overallHoursValueLabel);
            this.panel1.Controls.Add(this.overallHoursTextLabel);
            this.panel1.Controls.Add(this.resetAllCheckBox);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.switchTimesButton);
            this.panel1.Controls.Add(this.endedNowButton);
            this.panel1.Controls.Add(this.startedNowButton);
            this.panel1.Controls.Add(this.infoLabel);
            this.panel1.Controls.Add(this.startNewDayCheckBox);
            this.panel1.Controls.Add(this.tasksDisplayRichTextBox);
            this.panel1.Controls.Add(this.addTaskButton);
            this.panel1.Controls.Add(this.taskDescriptionTextBox);
            this.panel1.Controls.Add(this.taskEndTimeTextBox);
            this.panel1.Controls.Add(this.isolatorLabel);
            this.panel1.Controls.Add(this.taskStartTimeTextBox);
            this.panel1.Location = new System.Drawing.Point(38, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 437);
            this.panel1.TabIndex = 3;
            // 
            // overallHoursValueLabel
            // 
            this.overallHoursValueLabel.AutoSize = true;
            this.overallHoursValueLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallHoursValueLabel.Location = new System.Drawing.Point(413, 400);
            this.overallHoursValueLabel.Name = "overallHoursValueLabel";
            this.overallHoursValueLabel.Size = new System.Drawing.Size(16, 17);
            this.overallHoursValueLabel.TabIndex = 12;
            this.overallHoursValueLabel.Text = "0";
            // 
            // overallHoursTextLabel
            // 
            this.overallHoursTextLabel.AutoSize = true;
            this.overallHoursTextLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallHoursTextLabel.Location = new System.Drawing.Point(294, 400);
            this.overallHoursTextLabel.Name = "overallHoursTextLabel";
            this.overallHoursTextLabel.Size = new System.Drawing.Size(122, 17);
            this.overallHoursTextLabel.TabIndex = 11;
            this.overallHoursTextLabel.Text = "Tunteja yhteensä:";
            // 
            // resetAllCheckBox
            // 
            this.resetAllCheckBox.AutoSize = true;
            this.resetAllCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetAllCheckBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAllCheckBox.Location = new System.Drawing.Point(318, 196);
            this.resetAllCheckBox.Name = "resetAllCheckBox";
            this.resetAllCheckBox.Size = new System.Drawing.Size(137, 21);
            this.resetAllCheckBox.TabIndex = 10;
            this.resetAllCheckBox.Text = "Pyyhi kaikki arvot";
            this.resetAllCheckBox.UseVisualStyleBackColor = true;
            this.resetAllCheckBox.CheckedChanged += new System.EventHandler(this.resetAllCheckBox_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Window;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(314, 142);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(39, 26);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Del";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // switchTimesButton
            // 
            this.switchTimesButton.BackColor = System.Drawing.SystemColors.Window;
            this.switchTimesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchTimesButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchTimesButton.Location = new System.Drawing.Point(269, 142);
            this.switchTimesButton.Name = "switchTimesButton";
            this.switchTimesButton.Size = new System.Drawing.Size(39, 26);
            this.switchTimesButton.TabIndex = 8;
            this.switchTimesButton.Text = "<->";
            this.switchTimesButton.UseVisualStyleBackColor = false;
            this.switchTimesButton.Click += new System.EventHandler(this.switchTimesButton_Click);
            // 
            // endedNowButton
            // 
            this.endedNowButton.BackColor = System.Drawing.SystemColors.Window;
            this.endedNowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endedNowButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endedNowButton.Location = new System.Drawing.Point(314, 50);
            this.endedNowButton.Name = "endedNowButton";
            this.endedNowButton.Size = new System.Drawing.Size(45, 26);
            this.endedNowButton.TabIndex = 3;
            this.endedNowButton.Text = "Nyt?";
            this.endedNowButton.UseVisualStyleBackColor = false;
            this.endedNowButton.Click += new System.EventHandler(this.endedNowButton_Click);
            // 
            // startedNowButton
            // 
            this.startedNowButton.BackColor = System.Drawing.SystemColors.Window;
            this.startedNowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startedNowButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedNowButton.Location = new System.Drawing.Point(98, 50);
            this.startedNowButton.Name = "startedNowButton";
            this.startedNowButton.Size = new System.Drawing.Size(45, 26);
            this.startedNowButton.TabIndex = 1;
            this.startedNowButton.Text = "Nyt?";
            this.startedNowButton.UseVisualStyleBackColor = false;
            this.startedNowButton.Click += new System.EventHandler(this.startedNowButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(3, 194);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(452, 23);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoLabel.Visible = false;
            // 
            // startNewDayCheckBox
            // 
            this.startNewDayCheckBox.AutoSize = true;
            this.startNewDayCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startNewDayCheckBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNewDayCheckBox.Location = new System.Drawing.Point(3, 399);
            this.startNewDayCheckBox.Name = "startNewDayCheckBox";
            this.startNewDayCheckBox.Size = new System.Drawing.Size(142, 22);
            this.startNewDayCheckBox.TabIndex = 7;
            this.startNewDayCheckBox.Text = "Aloita uusi päivä";
            this.startNewDayCheckBox.UseVisualStyleBackColor = true;
            this.startNewDayCheckBox.CheckedChanged += new System.EventHandler(this.startNewDayCheckBox_CheckedChanged);
            // 
            // tasksDisplayRichTextBox
            // 
            this.tasksDisplayRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tasksDisplayRichTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksDisplayRichTextBox.Location = new System.Drawing.Point(0, 220);
            this.tasksDisplayRichTextBox.Name = "tasksDisplayRichTextBox";
            this.tasksDisplayRichTextBox.Size = new System.Drawing.Size(458, 173);
            this.tasksDisplayRichTextBox.TabIndex = 6;
            this.tasksDisplayRichTextBox.Text = "";
            this.tasksDisplayRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tasksDisplayRichTextBox_KeyDown);
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.SystemColors.Window;
            this.addTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTaskButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.Location = new System.Drawing.Point(104, 142);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(159, 26);
            this.addTaskButton.TabIndex = 5;
            this.addTaskButton.Text = "Lisää tehtävä";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(59, 94);
            this.taskDescriptionTextBox.MaxLength = 180;
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(338, 26);
            this.taskDescriptionTextBox.TabIndex = 4;
            this.taskDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.taskDescriptionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskDescriptionTextBox_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.MenuText;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.console.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.SystemColors.Info;
            this.console.Location = new System.Drawing.Point(12, 12);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(0, 0);
            this.console.TabIndex = 6;
            this.console.TabStop = false;
            this.console.Text = "";
            this.console.Visible = false;
            this.console.WordWrap = false;
            this.console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.console_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KiminTyotuntilaskuri.Properties.Resources.kimin_työtuntilaskuri;
            this.pictureBox1.Location = new System.Drawing.Point(38, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(536, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.console);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kimin työtuntilaskuri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox taskStartTimeTextBox;
        private System.Windows.Forms.TextBox taskEndTimeTextBox;
        private System.Windows.Forms.Label isolatorLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox taskDescriptionTextBox;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.RichTextBox tasksDisplayRichTextBox;
        private System.Windows.Forms.CheckBox startNewDayCheckBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button endedNowButton;
        private System.Windows.Forms.Button startedNowButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button switchTimesButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox resetAllCheckBox;
        private System.Windows.Forms.Label overallHoursTextLabel;
        private System.Windows.Forms.Label overallHoursValueLabel;
    }
}

