namespace DisabilityServiceDatabase
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.FirstNameField = new System.Windows.Forms.TabPage();
            this.ReportsTab = new System.Windows.Forms.TabPage();
            this.NotificationsTab = new System.Windows.Forms.TabPage();
            this.EmployeeNumberField = new System.Windows.Forms.TextBox();
            this.EmployeeNumberLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityField = new System.Windows.Forms.TextBox();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.ProvinceField = new System.Windows.Forms.ComboBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.PostalCodeField = new System.Windows.Forms.TextBox();
            this.HomeNumberLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.WorkNumberField = new System.Windows.Forms.TextBox();
            this.WorkNumberLabel = new System.Windows.Forms.Label();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PersonalInformationLabel = new System.Windows.Forms.Label();
            this.RTWInformationLabel = new System.Windows.Forms.Label();
            this.StatusField = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LTDEligibleLabel = new System.Windows.Forms.Label();
            this.LTDEligibleField = new System.Windows.Forms.CheckBox();
            this.ReferralRecievedLabel = new System.Windows.Forms.Label();
            this.ReferralRecievedField = new System.Windows.Forms.DateTimePicker();
            this.StartDateField = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.HourlySalaryLabel = new System.Windows.Forms.Label();
            this.HourlySalaryField = new System.Windows.Forms.TextBox();
            this.DailyHoursWorkedField = new System.Windows.Forms.TextBox();
            this.DailyHoursWorkedLabel = new System.Windows.Forms.Label();
            this.SubmitEntryButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.FirstNameField.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.FirstNameField);
            this.MainTab.Controls.Add(this.ReportsTab);
            this.MainTab.Controls.Add(this.NotificationsTab);
            this.MainTab.Location = new System.Drawing.Point(12, 27);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1160, 722);
            this.MainTab.TabIndex = 1;
            // 
            // FirstNameField
            // 
            this.FirstNameField.Controls.Add(this.SubmitEntryButton);
            this.FirstNameField.Controls.Add(this.DailyHoursWorkedField);
            this.FirstNameField.Controls.Add(this.DailyHoursWorkedLabel);
            this.FirstNameField.Controls.Add(this.HourlySalaryField);
            this.FirstNameField.Controls.Add(this.HourlySalaryLabel);
            this.FirstNameField.Controls.Add(this.StartDateField);
            this.FirstNameField.Controls.Add(this.StartDateLabel);
            this.FirstNameField.Controls.Add(this.ReferralRecievedField);
            this.FirstNameField.Controls.Add(this.ReferralRecievedLabel);
            this.FirstNameField.Controls.Add(this.LTDEligibleField);
            this.FirstNameField.Controls.Add(this.LTDEligibleLabel);
            this.FirstNameField.Controls.Add(this.StatusField);
            this.FirstNameField.Controls.Add(this.StatusLabel);
            this.FirstNameField.Controls.Add(this.RTWInformationLabel);
            this.FirstNameField.Controls.Add(this.PersonalInformationLabel);
            this.FirstNameField.Controls.Add(this.EmailField);
            this.FirstNameField.Controls.Add(this.EmailLabel);
            this.FirstNameField.Controls.Add(this.WorkNumberField);
            this.FirstNameField.Controls.Add(this.WorkNumberLabel);
            this.FirstNameField.Controls.Add(this.textBox2);
            this.FirstNameField.Controls.Add(this.HomeNumberLabel);
            this.FirstNameField.Controls.Add(this.PostalCodeField);
            this.FirstNameField.Controls.Add(this.PostalCodeLabel);
            this.FirstNameField.Controls.Add(this.ProvinceField);
            this.FirstNameField.Controls.Add(this.ProvinceLabel);
            this.FirstNameField.Controls.Add(this.CityField);
            this.FirstNameField.Controls.Add(this.CityLabel);
            this.FirstNameField.Controls.Add(this.LastNameField);
            this.FirstNameField.Controls.Add(this.LastNameLabel);
            this.FirstNameField.Controls.Add(this.textBox1);
            this.FirstNameField.Controls.Add(this.FirstNameLabel);
            this.FirstNameField.Controls.Add(this.EmployeeNumberLabel);
            this.FirstNameField.Controls.Add(this.EmployeeNumberField);
            this.FirstNameField.Location = new System.Drawing.Point(4, 22);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Padding = new System.Windows.Forms.Padding(3);
            this.FirstNameField.Size = new System.Drawing.Size(1152, 696);
            this.FirstNameField.TabIndex = 0;
            this.FirstNameField.Text = "Data Entry";
            this.FirstNameField.UseVisualStyleBackColor = true;
            // 
            // ReportsTab
            // 
            this.ReportsTab.Location = new System.Drawing.Point(4, 22);
            this.ReportsTab.Name = "ReportsTab";
            this.ReportsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReportsTab.Size = new System.Drawing.Size(1152, 696);
            this.ReportsTab.TabIndex = 1;
            this.ReportsTab.Text = "Reports";
            this.ReportsTab.UseVisualStyleBackColor = true;
            // 
            // NotificationsTab
            // 
            this.NotificationsTab.Location = new System.Drawing.Point(4, 22);
            this.NotificationsTab.Name = "NotificationsTab";
            this.NotificationsTab.Size = new System.Drawing.Size(1152, 696);
            this.NotificationsTab.TabIndex = 2;
            this.NotificationsTab.Text = "Notifications";
            this.NotificationsTab.UseVisualStyleBackColor = true;
            // 
            // EmployeeNumberField
            // 
            this.EmployeeNumberField.Location = new System.Drawing.Point(175, 59);
            this.EmployeeNumberField.Name = "EmployeeNumberField";
            this.EmployeeNumberField.Size = new System.Drawing.Size(200, 20);
            this.EmployeeNumberField.TabIndex = 0;
            // 
            // EmployeeNumberLabel
            // 
            this.EmployeeNumberLabel.AutoSize = true;
            this.EmployeeNumberLabel.Location = new System.Drawing.Point(62, 62);
            this.EmployeeNumberLabel.Name = "EmployeeNumberLabel";
            this.EmployeeNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.EmployeeNumberLabel.TabIndex = 1;
            this.EmployeeNumberLabel.Text = "Employee Number";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(62, 100);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(62, 136);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameField
            // 
            this.LastNameField.Location = new System.Drawing.Point(175, 133);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(200, 20);
            this.LastNameField.TabIndex = 5;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(62, 173);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 6;
            this.CityLabel.Text = "City";
            // 
            // CityField
            // 
            this.CityField.Location = new System.Drawing.Point(175, 170);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(200, 20);
            this.CityField.TabIndex = 7;
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(62, 212);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(49, 13);
            this.ProvinceLabel.TabIndex = 8;
            this.ProvinceLabel.Text = "Province";
            // 
            // ProvinceField
            // 
            this.ProvinceField.FormattingEnabled = true;
            this.ProvinceField.Items.AddRange(new object[] {
            "Alberta",
            "British Colombia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland and Labrador",
            "Northwest Territories",
            "Nova Scotia",
            "Nunavut",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Yukon"});
            this.ProvinceField.Location = new System.Drawing.Point(175, 209);
            this.ProvinceField.Name = "ProvinceField";
            this.ProvinceField.Size = new System.Drawing.Size(200, 21);
            this.ProvinceField.TabIndex = 9;
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(62, 253);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.PostalCodeLabel.TabIndex = 10;
            this.PostalCodeLabel.Text = "Postal Code";
            // 
            // PostalCodeField
            // 
            this.PostalCodeField.Location = new System.Drawing.Point(175, 246);
            this.PostalCodeField.Name = "PostalCodeField";
            this.PostalCodeField.Size = new System.Drawing.Size(200, 20);
            this.PostalCodeField.TabIndex = 11;
            // 
            // HomeNumberLabel
            // 
            this.HomeNumberLabel.AutoSize = true;
            this.HomeNumberLabel.Location = new System.Drawing.Point(62, 287);
            this.HomeNumberLabel.Name = "HomeNumberLabel";
            this.HomeNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.HomeNumberLabel.TabIndex = 12;
            this.HomeNumberLabel.Text = "Home Number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 13;
            // 
            // WorkNumberField
            // 
            this.WorkNumberField.Location = new System.Drawing.Point(175, 322);
            this.WorkNumberField.Name = "WorkNumberField";
            this.WorkNumberField.Size = new System.Drawing.Size(200, 20);
            this.WorkNumberField.TabIndex = 15;
            // 
            // WorkNumberLabel
            // 
            this.WorkNumberLabel.AutoSize = true;
            this.WorkNumberLabel.Location = new System.Drawing.Point(62, 325);
            this.WorkNumberLabel.Name = "WorkNumberLabel";
            this.WorkNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.WorkNumberLabel.TabIndex = 14;
            this.WorkNumberLabel.Text = "Work Number";
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(177, 361);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(198, 20);
            this.EmailField.TabIndex = 17;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(64, 364);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email";
            // 
            // PersonalInformationLabel
            // 
            this.PersonalInformationLabel.AutoSize = true;
            this.PersonalInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PersonalInformationLabel.Location = new System.Drawing.Point(114, 19);
            this.PersonalInformationLabel.Name = "PersonalInformationLabel";
            this.PersonalInformationLabel.Size = new System.Drawing.Size(156, 20);
            this.PersonalInformationLabel.TabIndex = 18;
            this.PersonalInformationLabel.Text = "Personal Information";
            // 
            // RTWInformationLabel
            // 
            this.RTWInformationLabel.AutoSize = true;
            this.RTWInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RTWInformationLabel.Location = new System.Drawing.Point(562, 19);
            this.RTWInformationLabel.Name = "RTWInformationLabel";
            this.RTWInformationLabel.Size = new System.Drawing.Size(130, 20);
            this.RTWInformationLabel.TabIndex = 19;
            this.RTWInformationLabel.Text = "RTW Information";
            // 
            // StatusField
            // 
            this.StatusField.FormattingEnabled = true;
            this.StatusField.Items.AddRange(new object[] {
            "Add Statuses Here"});
            this.StatusField.Location = new System.Drawing.Point(626, 59);
            this.StatusField.Name = "StatusField";
            this.StatusField.Size = new System.Drawing.Size(200, 21);
            this.StatusField.TabIndex = 21;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(513, 62);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 20;
            this.StatusLabel.Text = "Status";
            // 
            // LTDEligibleLabel
            // 
            this.LTDEligibleLabel.AutoSize = true;
            this.LTDEligibleLabel.Location = new System.Drawing.Point(513, 100);
            this.LTDEligibleLabel.Name = "LTDEligibleLabel";
            this.LTDEligibleLabel.Size = new System.Drawing.Size(64, 13);
            this.LTDEligibleLabel.TabIndex = 22;
            this.LTDEligibleLabel.Text = "LTD Eligible";
            // 
            // LTDEligibleField
            // 
            this.LTDEligibleField.AutoSize = true;
            this.LTDEligibleField.Location = new System.Drawing.Point(626, 99);
            this.LTDEligibleField.Name = "LTDEligibleField";
            this.LTDEligibleField.Size = new System.Drawing.Size(15, 14);
            this.LTDEligibleField.TabIndex = 23;
            this.LTDEligibleField.UseVisualStyleBackColor = true;
            // 
            // ReferralRecievedLabel
            // 
            this.ReferralRecievedLabel.AutoSize = true;
            this.ReferralRecievedLabel.Location = new System.Drawing.Point(513, 136);
            this.ReferralRecievedLabel.Name = "ReferralRecievedLabel";
            this.ReferralRecievedLabel.Size = new System.Drawing.Size(93, 13);
            this.ReferralRecievedLabel.TabIndex = 24;
            this.ReferralRecievedLabel.Text = "Referral Recieved";
            this.ReferralRecievedLabel.Click += new System.EventHandler(this.ReferralRecievedLabel_Click);
            // 
            // ReferralRecievedField
            // 
            this.ReferralRecievedField.Location = new System.Drawing.Point(626, 133);
            this.ReferralRecievedField.Name = "ReferralRecievedField";
            this.ReferralRecievedField.Size = new System.Drawing.Size(200, 20);
            this.ReferralRecievedField.TabIndex = 25;
            // 
            // StartDateField
            // 
            this.StartDateField.Location = new System.Drawing.Point(626, 170);
            this.StartDateField.Name = "StartDateField";
            this.StartDateField.Size = new System.Drawing.Size(200, 20);
            this.StartDateField.TabIndex = 27;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(513, 173);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(55, 13);
            this.StartDateLabel.TabIndex = 26;
            this.StartDateLabel.Text = "Start Date";
            // 
            // HourlySalaryLabel
            // 
            this.HourlySalaryLabel.AutoSize = true;
            this.HourlySalaryLabel.Location = new System.Drawing.Point(513, 212);
            this.HourlySalaryLabel.Name = "HourlySalaryLabel";
            this.HourlySalaryLabel.Size = new System.Drawing.Size(69, 13);
            this.HourlySalaryLabel.TabIndex = 28;
            this.HourlySalaryLabel.Text = "Hourly Salary";
            // 
            // HourlySalaryField
            // 
            this.HourlySalaryField.Location = new System.Drawing.Point(626, 209);
            this.HourlySalaryField.Name = "HourlySalaryField";
            this.HourlySalaryField.Size = new System.Drawing.Size(200, 20);
            this.HourlySalaryField.TabIndex = 29;
            // 
            // DailyHoursWorkedField
            // 
            this.DailyHoursWorkedField.Location = new System.Drawing.Point(626, 246);
            this.DailyHoursWorkedField.Name = "DailyHoursWorkedField";
            this.DailyHoursWorkedField.Size = new System.Drawing.Size(200, 20);
            this.DailyHoursWorkedField.TabIndex = 31;
            // 
            // DailyHoursWorkedLabel
            // 
            this.DailyHoursWorkedLabel.AutoSize = true;
            this.DailyHoursWorkedLabel.Location = new System.Drawing.Point(513, 249);
            this.DailyHoursWorkedLabel.Name = "DailyHoursWorkedLabel";
            this.DailyHoursWorkedLabel.Size = new System.Drawing.Size(102, 13);
            this.DailyHoursWorkedLabel.TabIndex = 30;
            this.DailyHoursWorkedLabel.Text = "Daily Hours Worked";
            // 
            // SubmitEntryButton
            // 
            this.SubmitEntryButton.Location = new System.Drawing.Point(516, 287);
            this.SubmitEntryButton.Name = "SubmitEntryButton";
            this.SubmitEntryButton.Size = new System.Drawing.Size(310, 23);
            this.SubmitEntryButton.TabIndex = 32;
            this.SubmitEntryButton.Text = "Submit Entry";
            this.SubmitEntryButton.UseVisualStyleBackColor = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrame";
            this.Text = "Disability Services Database";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainTab.ResumeLayout(false);
            this.FirstNameField.ResumeLayout(false);
            this.FirstNameField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage FirstNameField;
        private System.Windows.Forms.TabPage ReportsTab;
        private System.Windows.Forms.TabPage NotificationsTab;
        private System.Windows.Forms.TextBox EmployeeNumberField;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label EmployeeNumberLabel;
        private System.Windows.Forms.ComboBox ProvinceField;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.TextBox CityField;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox LastNameField;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PersonalInformationLabel;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox WorkNumberField;
        private System.Windows.Forms.Label WorkNumberLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label HomeNumberLabel;
        private System.Windows.Forms.TextBox PostalCodeField;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.ComboBox StatusField;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label RTWInformationLabel;
        private System.Windows.Forms.Label ReferralRecievedLabel;
        private System.Windows.Forms.CheckBox LTDEligibleField;
        private System.Windows.Forms.Label LTDEligibleLabel;
        private System.Windows.Forms.DateTimePicker ReferralRecievedField;
        private System.Windows.Forms.Button SubmitEntryButton;
        private System.Windows.Forms.TextBox DailyHoursWorkedField;
        private System.Windows.Forms.Label DailyHoursWorkedLabel;
        private System.Windows.Forms.TextBox HourlySalaryField;
        private System.Windows.Forms.Label HourlySalaryLabel;
        private System.Windows.Forms.DateTimePicker StartDateField;
        private System.Windows.Forms.Label StartDateLabel;
    }
}

