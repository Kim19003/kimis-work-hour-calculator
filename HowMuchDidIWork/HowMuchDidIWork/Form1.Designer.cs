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
            this.taskStartTimeTextBox = new System.Windows.Forms.TextBox();
            this.taskEndTimeTextBox = new System.Windows.Forms.TextBox();
            this.isolatorLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.tasksDisplayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.resetCheckBox = new System.Windows.Forms.CheckBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskStartTimeTextBox
            // 
            this.taskStartTimeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskStartTimeTextBox.Location = new System.Drawing.Point(149, 56);
            this.taskStartTimeTextBox.MaxLength = 5;
            this.taskStartTimeTextBox.Name = "taskStartTimeTextBox";
            this.taskStartTimeTextBox.Size = new System.Drawing.Size(66, 26);
            this.taskStartTimeTextBox.TabIndex = 0;
            this.taskStartTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // taskEndTimeTextBox
            // 
            this.taskEndTimeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskEndTimeTextBox.Location = new System.Drawing.Point(242, 56);
            this.taskEndTimeTextBox.MaxLength = 5;
            this.taskEndTimeTextBox.Name = "taskEndTimeTextBox";
            this.taskEndTimeTextBox.Size = new System.Drawing.Size(66, 26);
            this.taskEndTimeTextBox.TabIndex = 1;
            this.taskEndTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // isolatorLabel
            // 
            this.isolatorLabel.AutoSize = true;
            this.isolatorLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isolatorLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.isolatorLabel.Location = new System.Drawing.Point(222, 58);
            this.isolatorLabel.Name = "isolatorLabel";
            this.isolatorLabel.Size = new System.Drawing.Size(16, 22);
            this.isolatorLabel.TabIndex = 2;
            this.isolatorLabel.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infoLabel);
            this.panel1.Controls.Add(this.resetCheckBox);
            this.panel1.Controls.Add(this.tasksDisplayRichTextBox);
            this.panel1.Controls.Add(this.addTaskButton);
            this.panel1.Controls.Add(this.taskDescriptionTextBox);
            this.panel1.Controls.Add(this.taskEndTimeTextBox);
            this.panel1.Controls.Add(this.isolatorLabel);
            this.panel1.Controls.Add(this.taskStartTimeTextBox);
            this.panel1.Location = new System.Drawing.Point(38, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 437);
            this.panel1.TabIndex = 3;
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(52, 100);
            this.taskDescriptionTextBox.MaxLength = 60;
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(347, 26);
            this.taskDescriptionTextBox.TabIndex = 3;
            this.taskDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.taskDescriptionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskDescriptionTextBox_KeyDown);
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.SystemColors.Window;
            this.addTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTaskButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.Location = new System.Drawing.Point(149, 149);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(159, 26);
            this.addTaskButton.TabIndex = 4;
            this.addTaskButton.Text = "Lisää tehtävä";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // tasksDisplayRichTextBox
            // 
            this.tasksDisplayRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tasksDisplayRichTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksDisplayRichTextBox.Location = new System.Drawing.Point(0, 220);
            this.tasksDisplayRichTextBox.Name = "tasksDisplayRichTextBox";
            this.tasksDisplayRichTextBox.Size = new System.Drawing.Size(458, 173);
            this.tasksDisplayRichTextBox.TabIndex = 5;
            this.tasksDisplayRichTextBox.Text = "";
            this.tasksDisplayRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tasksDisplayRichTextBox_KeyDown);
            // 
            // resetCheckBox
            // 
            this.resetCheckBox.AutoSize = true;
            this.resetCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetCheckBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetCheckBox.Location = new System.Drawing.Point(3, 399);
            this.resetCheckBox.Name = "resetCheckBox";
            this.resetCheckBox.Size = new System.Drawing.Size(160, 21);
            this.resetCheckBox.TabIndex = 6;
            this.resetCheckBox.Text = "Pyyhi tehtävähistoria";
            this.resetCheckBox.UseVisualStyleBackColor = true;
            this.resetCheckBox.CheckedChanged += new System.EventHandler(this.resetCheckBox_CheckedChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.infoLabel.Location = new System.Drawing.Point(52, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(347, 23);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = "asdasdasdasdasdsfdfsd";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(538, 507);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Kimin työpäivälaskuri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.CheckBox resetCheckBox;
        private System.Windows.Forms.Label infoLabel;
    }
}

