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
            this.RTWInformationTable = new System.Windows.Forms.TableLayoutPanel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusField = new System.Windows.Forms.ComboBox();
            this.LTDEligibleLabel = new System.Windows.Forms.Label();
            this.DailyHoursWorkedField = new System.Windows.Forms.TextBox();
            this.LTDEligibleField = new System.Windows.Forms.CheckBox();
            this.DailyHoursWorkedLabel = new System.Windows.Forms.Label();
            this.ReferralReceivedLabel = new System.Windows.Forms.Label();
            this.HourlySalaryField = new System.Windows.Forms.TextBox();
            this.ReferralReceivedField = new System.Windows.Forms.DateTimePicker();
            this.HourlySalaryLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDateField = new System.Windows.Forms.DateTimePicker();
            this.PersonalInformationTable = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeNumberLabel = new System.Windows.Forms.Label();
            this.EmployeeNumberField = new System.Windows.Forms.TextBox();
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
            this.WorkNumberLabel = new System.Windows.Forms.Label();
            this.WorkNumberField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SubmitEntryButton = new System.Windows.Forms.Button();
            this.RTWInformationLabel = new System.Windows.Forms.Label();
            this.PersonalInformationLabel = new System.Windows.Forms.Label();
            this.ReportsTab = new System.Windows.Forms.TabPage();
            this.NotificationsTab = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.FirstNameField.SuspendLayout();
            this.RTWInformationTable.SuspendLayout();
            this.PersonalInformationTable.SuspendLayout();
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
            this.FirstNameField.Controls.Add(this.RTWInformationTable);
            this.FirstNameField.Controls.Add(this.PersonalInformationTable);
            this.FirstNameField.Controls.Add(this.SubmitEntryButton);
            this.FirstNameField.Controls.Add(this.RTWInformationLabel);
            this.FirstNameField.Controls.Add(this.PersonalInformationLabel);
            this.FirstNameField.Location = new System.Drawing.Point(4, 22);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Padding = new System.Windows.Forms.Padding(3);
            this.FirstNameField.Size = new System.Drawing.Size(1152, 696);
            this.FirstNameField.TabIndex = 0;
            this.FirstNameField.Text = "Data Entry";
            this.FirstNameField.UseVisualStyleBackColor = true;
            // 
            // RTWInformationTable
            // 
            this.RTWInformationTable.ColumnCount = 2;
            this.RTWInformationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RTWInformationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RTWInformationTable.Controls.Add(this.StatusLabel, 0, 0);
            this.RTWInformationTable.Controls.Add(this.StatusField, 1, 0);
            this.RTWInformationTable.Controls.Add(this.LTDEligibleLabel, 0, 1);
            this.RTWInformationTable.Controls.Add(this.DailyHoursWorkedField, 1, 5);
            this.RTWInformationTable.Controls.Add(this.LTDEligibleField, 1, 1);
            this.RTWInformationTable.Controls.Add(this.DailyHoursWorkedLabel, 0, 5);
            this.RTWInformationTable.Controls.Add(this.ReferralReceivedLabel, 0, 2);
            this.RTWInformationTable.Controls.Add(this.HourlySalaryField, 1, 4);
            this.RTWInformationTable.Controls.Add(this.ReferralReceivedField, 1, 2);
            this.RTWInformationTable.Controls.Add(this.HourlySalaryLabel, 0, 4);
            this.RTWInformationTable.Controls.Add(this.StartDateLabel, 0, 3);
            this.RTWInformationTable.Controls.Add(this.StartDateField, 1, 3);
            this.RTWInformationTable.Location = new System.Drawing.Point(486, 62);
            this.RTWInformationTable.Name = "RTWInformationTable";
            this.RTWInformationTable.RowCount = 6;
            this.RTWInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.RTWInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.RTWInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.RTWInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.RTWInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.RTWInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.RTWInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RTWInformationTable.Size = new System.Drawing.Size(387, 236);
            this.RTWInformationTable.TabIndex = 34;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(3, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 20;
            this.StatusLabel.Text = "Status";
            // 
            // StatusField
            // 
            this.StatusField.FormattingEnabled = true;
            this.StatusField.Items.AddRange(new object[] {
            "Add Statuses Here"});
            this.StatusField.Location = new System.Drawing.Point(196, 3);
            this.StatusField.Name = "StatusField";
            this.StatusField.Size = new System.Drawing.Size(188, 21);
            this.StatusField.TabIndex = 21;
            // 
            // LTDEligibleLabel
            // 
            this.LTDEligibleLabel.AutoSize = true;
            this.LTDEligibleLabel.Location = new System.Drawing.Point(3, 39);
            this.LTDEligibleLabel.Name = "LTDEligibleLabel";
            this.LTDEligibleLabel.Size = new System.Drawing.Size(64, 13);
            this.LTDEligibleLabel.TabIndex = 22;
            this.LTDEligibleLabel.Text = "LTD Eligible";
            // 
            // DailyHoursWorkedField
            // 
            this.DailyHoursWorkedField.Location = new System.Drawing.Point(196, 198);
            this.DailyHoursWorkedField.Name = "DailyHoursWorkedField";
            this.DailyHoursWorkedField.Size = new System.Drawing.Size(188, 20);
            this.DailyHoursWorkedField.TabIndex = 31;
            // 
            // LTDEligibleField
            // 
            this.LTDEligibleField.AutoSize = true;
            this.LTDEligibleField.Location = new System.Drawing.Point(196, 42);
            this.LTDEligibleField.Name = "LTDEligibleField";
            this.LTDEligibleField.Size = new System.Drawing.Size(15, 14);
            this.LTDEligibleField.TabIndex = 23;
            this.LTDEligibleField.UseVisualStyleBackColor = true;
            // 
            // DailyHoursWorkedLabel
            // 
            this.DailyHoursWorkedLabel.AutoSize = true;
            this.DailyHoursWorkedLabel.Location = new System.Drawing.Point(3, 195);
            this.DailyHoursWorkedLabel.Name = "DailyHoursWorkedLabel";
            this.DailyHoursWorkedLabel.Size = new System.Drawing.Size(102, 13);
            this.DailyHoursWorkedLabel.TabIndex = 30;
            this.DailyHoursWorkedLabel.Text = "Daily Hours Worked";
            // 
            // ReferralReceivedLabel
            // 
            this.ReferralReceivedLabel.AutoSize = true;
            this.ReferralReceivedLabel.Location = new System.Drawing.Point(3, 78);
            this.ReferralReceivedLabel.Name = "ReferralReceivedLabel";
            this.ReferralReceivedLabel.Size = new System.Drawing.Size(93, 13);
            this.ReferralReceivedLabel.TabIndex = 24;
            this.ReferralReceivedLabel.Text = "Referral Received";
            this.ReferralReceivedLabel.Click += new System.EventHandler(this.ReferralRecievedLabel_Click);
            // 
            // HourlySalaryField
            // 
            this.HourlySalaryField.Location = new System.Drawing.Point(196, 159);
            this.HourlySalaryField.Name = "HourlySalaryField";
            this.HourlySalaryField.Size = new System.Drawing.Size(188, 20);
            this.HourlySalaryField.TabIndex = 29;
            // 
            // ReferralReceivedField
            // 
            this.ReferralReceivedField.Location = new System.Drawing.Point(196, 81);
            this.ReferralReceivedField.Name = "ReferralReceivedField";
            this.ReferralReceivedField.Size = new System.Drawing.Size(188, 20);
            this.ReferralReceivedField.TabIndex = 25;
            // 
            // HourlySalaryLabel
            // 
            this.HourlySalaryLabel.AutoSize = true;
            this.HourlySalaryLabel.Location = new System.Drawing.Point(3, 156);
            this.HourlySalaryLabel.Name = "HourlySalaryLabel";
            this.HourlySalaryLabel.Size = new System.Drawing.Size(69, 13);
            this.HourlySalaryLabel.TabIndex = 28;
            this.HourlySalaryLabel.Text = "Hourly Salary";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(3, 117);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(55, 13);
            this.StartDateLabel.TabIndex = 26;
            this.StartDateLabel.Text = "Start Date";
            // 
            // StartDateField
            // 
            this.StartDateField.Location = new System.Drawing.Point(196, 120);
            this.StartDateField.Name = "StartDateField";
            this.StartDateField.Size = new System.Drawing.Size(188, 20);
            this.StartDateField.TabIndex = 27;
            // 
            // PersonalInformationTable
            // 
            this.PersonalInformationTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PersonalInformationTable.ColumnCount = 2;
            this.PersonalInformationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PersonalInformationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PersonalInformationTable.Controls.Add(this.EmployeeNumberLabel, 0, 0);
            this.PersonalInformationTable.Controls.Add(this.EmployeeNumberField, 1, 0);
            this.PersonalInformationTable.Controls.Add(this.FirstNameLabel, 0, 1);
            this.PersonalInformationTable.Controls.Add(this.textBox1, 1, 1);
            this.PersonalInformationTable.Controls.Add(this.LastNameLabel, 0, 2);
            this.PersonalInformationTable.Controls.Add(this.LastNameField, 1, 2);
            this.PersonalInformationTable.Controls.Add(this.CityLabel, 0, 3);
            this.PersonalInformationTable.Controls.Add(this.CityField, 1, 3);
            this.PersonalInformationTable.Controls.Add(this.ProvinceLabel, 0, 4);
            this.PersonalInformationTable.Controls.Add(this.ProvinceField, 1, 4);
            this.PersonalInformationTable.Controls.Add(this.PostalCodeLabel, 0, 5);
            this.PersonalInformationTable.Controls.Add(this.PostalCodeField, 1, 5);
            this.PersonalInformationTable.Controls.Add(this.HomeNumberLabel, 0, 6);
            this.PersonalInformationTable.Controls.Add(this.textBox2, 1, 6);
            this.PersonalInformationTable.Controls.Add(this.WorkNumberLabel, 0, 7);
            this.PersonalInformationTable.Controls.Add(this.WorkNumberField, 1, 7);
            this.PersonalInformationTable.Controls.Add(this.EmailField, 1, 8);
            this.PersonalInformationTable.Controls.Add(this.EmailLabel, 0, 8);
            this.PersonalInformationTable.Location = new System.Drawing.Point(19, 62);
            this.PersonalInformationTable.Name = "PersonalInformationTable";
            this.PersonalInformationTable.RowCount = 9;
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.Size = new System.Drawing.Size(387, 357);
            this.PersonalInformationTable.TabIndex = 33;
            // 
            // EmployeeNumberLabel
            // 
            this.EmployeeNumberLabel.AutoSize = true;
            this.EmployeeNumberLabel.Location = new System.Drawing.Point(3, 0);
            this.EmployeeNumberLabel.Name = "EmployeeNumberLabel";
            this.EmployeeNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.EmployeeNumberLabel.TabIndex = 1;
            this.EmployeeNumberLabel.Text = "Employee Number";
            // 
            // EmployeeNumberField
            // 
            this.EmployeeNumberField.Location = new System.Drawing.Point(196, 3);
            this.EmployeeNumberField.Name = "EmployeeNumberField";
            this.EmployeeNumberField.Size = new System.Drawing.Size(188, 20);
            this.EmployeeNumberField.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 39);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(3, 78);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameField
            // 
            this.LastNameField.Location = new System.Drawing.Point(196, 81);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(188, 20);
            this.LastNameField.TabIndex = 5;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(3, 117);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 6;
            this.CityLabel.Text = "City";
            // 
            // CityField
            // 
            this.CityField.Location = new System.Drawing.Point(196, 120);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(188, 20);
            this.CityField.TabIndex = 7;
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(3, 156);
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
            this.ProvinceField.Location = new System.Drawing.Point(196, 159);
            this.ProvinceField.Name = "ProvinceField";
            this.ProvinceField.Size = new System.Drawing.Size(188, 21);
            this.ProvinceField.TabIndex = 9;
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(3, 195);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.PostalCodeLabel.TabIndex = 10;
            this.PostalCodeLabel.Text = "Postal Code";
            // 
            // PostalCodeField
            // 
            this.PostalCodeField.Location = new System.Drawing.Point(196, 198);
            this.PostalCodeField.Name = "PostalCodeField";
            this.PostalCodeField.Size = new System.Drawing.Size(188, 20);
            this.PostalCodeField.TabIndex = 11;
            // 
            // HomeNumberLabel
            // 
            this.HomeNumberLabel.AutoSize = true;
            this.HomeNumberLabel.Location = new System.Drawing.Point(3, 234);
            this.HomeNumberLabel.Name = "HomeNumberLabel";
            this.HomeNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.HomeNumberLabel.TabIndex = 12;
            this.HomeNumberLabel.Text = "Home Number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 13;
            // 
            // WorkNumberLabel
            // 
            this.WorkNumberLabel.AutoSize = true;
            this.WorkNumberLabel.Location = new System.Drawing.Point(3, 273);
            this.WorkNumberLabel.Name = "WorkNumberLabel";
            this.WorkNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.WorkNumberLabel.TabIndex = 14;
            this.WorkNumberLabel.Text = "Work Number";
            // 
            // WorkNumberField
            // 
            this.WorkNumberField.Location = new System.Drawing.Point(196, 276);
            this.WorkNumberField.Name = "WorkNumberField";
            this.WorkNumberField.Size = new System.Drawing.Size(188, 20);
            this.WorkNumberField.TabIndex = 15;
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(196, 315);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(188, 20);
            this.EmailField.TabIndex = 17;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(3, 312);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email";
            // 
            // SubmitEntryButton
            // 
            this.SubmitEntryButton.Location = new System.Drawing.Point(486, 336);
            this.SubmitEntryButton.Name = "SubmitEntryButton";
            this.SubmitEntryButton.Size = new System.Drawing.Size(387, 23);
            this.SubmitEntryButton.TabIndex = 32;
            this.SubmitEntryButton.Text = "Submit Entry";
            this.SubmitEntryButton.UseVisualStyleBackColor = true;
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
            this.RTWInformationTable.ResumeLayout(false);
            this.RTWInformationTable.PerformLayout();
            this.PersonalInformationTable.ResumeLayout(false);
            this.PersonalInformationTable.PerformLayout();
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
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label EmployeeNumberLabel;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PersonalInformationLabel;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label WorkNumberLabel;
        private System.Windows.Forms.Label HomeNumberLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.ComboBox StatusField;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label RTWInformationLabel;
        private System.Windows.Forms.Label ReferralReceivedLabel;
        private System.Windows.Forms.CheckBox LTDEligibleField;
        private System.Windows.Forms.Label LTDEligibleLabel;
        private System.Windows.Forms.DateTimePicker ReferralReceivedField;
        private System.Windows.Forms.Button SubmitEntryButton;
        private System.Windows.Forms.TextBox DailyHoursWorkedField;
        private System.Windows.Forms.Label DailyHoursWorkedLabel;
        private System.Windows.Forms.TextBox HourlySalaryField;
        private System.Windows.Forms.Label HourlySalaryLabel;
        private System.Windows.Forms.DateTimePicker StartDateField;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.TableLayoutPanel RTWInformationTable;
        private System.Windows.Forms.TableLayoutPanel PersonalInformationTable;
        private System.Windows.Forms.TextBox EmployeeNumberField;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox LastNameField;
        private System.Windows.Forms.TextBox CityField;
        private System.Windows.Forms.ComboBox ProvinceField;
        private System.Windows.Forms.TextBox PostalCodeField;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox WorkNumberField;
    }
}

