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
            this.DataEntryTab = new System.Windows.Forms.TabPage();
            this.PublishButton = new System.Windows.Forms.Button();
            this.ExistingPersonSearchField = new System.Windows.Forms.ComboBox();
            this.ExistingPersonButton = new System.Windows.Forms.RadioButton();
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
            this.EmailField = new System.Windows.Forms.TextBox();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.EmployeeNumberField = new System.Windows.Forms.TextBox();
            this.WorkNumberField = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.HomeNumberField = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.WorkNumberLabel = new System.Windows.Forms.Label();
            this.HomeNumberLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.PostalCodeField = new System.Windows.Forms.TextBox();
            this.StreetAddressField = new System.Windows.Forms.TextBox();
            this.ProvinceField = new System.Windows.Forms.ComboBox();
            this.CityField = new System.Windows.Forms.TextBox();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StreetAddressLabel = new System.Windows.Forms.Label();
            this.SubmitEntryButton = new System.Windows.Forms.Button();
            this.RTWInformationLabel = new System.Windows.Forms.Label();
            this.PersonalInformationLabel = new System.Windows.Forms.Label();
            this.ReportsTab = new System.Windows.Forms.TabPage();
            this.NotificationsTab = new System.Windows.Forms.TabPage();
            this.NotificationsTable = new System.Windows.Forms.DataGridView();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowExpiredLabel = new System.Windows.Forms.Label();
            this.ShowExpiredField = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.SortByField = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.DataEntryTab.SuspendLayout();
            this.RTWInformationTable.SuspendLayout();
            this.PersonalInformationTable.SuspendLayout();
            this.NotificationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsTable)).BeginInit();
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
            this.MainTab.Controls.Add(this.DataEntryTab);
            this.MainTab.Controls.Add(this.ReportsTab);
            this.MainTab.Controls.Add(this.NotificationsTab);
            this.MainTab.Location = new System.Drawing.Point(12, 27);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1160, 722);
            this.MainTab.TabIndex = 1;
            // 
            // DataEntryTab
            // 
            this.DataEntryTab.Controls.Add(this.PublishButton);
            this.DataEntryTab.Controls.Add(this.ExistingPersonSearchField);
            this.DataEntryTab.Controls.Add(this.ExistingPersonButton);
            this.DataEntryTab.Controls.Add(this.RTWInformationTable);
            this.DataEntryTab.Controls.Add(this.PersonalInformationTable);
            this.DataEntryTab.Controls.Add(this.SubmitEntryButton);
            this.DataEntryTab.Controls.Add(this.RTWInformationLabel);
            this.DataEntryTab.Controls.Add(this.PersonalInformationLabel);
            this.DataEntryTab.Location = new System.Drawing.Point(4, 22);
            this.DataEntryTab.Name = "DataEntryTab";
            this.DataEntryTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataEntryTab.Size = new System.Drawing.Size(1152, 696);
            this.DataEntryTab.TabIndex = 0;
            this.DataEntryTab.Text = "Data Entry";
            this.DataEntryTab.UseVisualStyleBackColor = true;
            // 
            // PublishButton
            // 
            this.PublishButton.Location = new System.Drawing.Point(553, 385);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(387, 23);
            this.PublishButton.TabIndex = 37;
            this.PublishButton.Text = "Publish Entries";
            this.PublishButton.UseVisualStyleBackColor = true;
            this.PublishButton.Visible = false;
            this.PublishButton.Click += new System.EventHandler(this.PublishButton_Click);
            // 
            // ExistingPersonSearchField
            // 
            this.ExistingPersonSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExistingPersonSearchField.FormattingEnabled = true;
            this.ExistingPersonSearchField.Items.AddRange(new object[] {
            "HIM",
            "HER",
            "IT"});
            this.ExistingPersonSearchField.Location = new System.Drawing.Point(118, 44);
            this.ExistingPersonSearchField.Name = "ExistingPersonSearchField";
            this.ExistingPersonSearchField.Size = new System.Drawing.Size(288, 21);
            this.ExistingPersonSearchField.TabIndex = 36;
            this.ExistingPersonSearchField.Visible = false;
            this.ExistingPersonSearchField.SelectedValueChanged += new System.EventHandler(this.ExistingPersonSearchField_Changed);
            // 
            // ExistingPersonButton
            // 
            this.ExistingPersonButton.AutoSize = true;
            this.ExistingPersonButton.Location = new System.Drawing.Point(314, 21);
            this.ExistingPersonButton.Name = "ExistingPersonButton";
            this.ExistingPersonButton.Size = new System.Drawing.Size(103, 17);
            this.ExistingPersonButton.TabIndex = 35;
            this.ExistingPersonButton.Text = "Existing Person?";
            this.ExistingPersonButton.UseVisualStyleBackColor = true;
            this.ExistingPersonButton.Click += new System.EventHandler(this.ExistingPersonButton_Click);
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
            this.RTWInformationTable.Location = new System.Drawing.Point(553, 88);
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
            this.PersonalInformationTable.Controls.Add(this.EmailField, 1, 9);
            this.PersonalInformationTable.Controls.Add(this.LastNameField, 1, 2);
            this.PersonalInformationTable.Controls.Add(this.FirstNameField, 1, 1);
            this.PersonalInformationTable.Controls.Add(this.EmployeeNumberField, 1, 0);
            this.PersonalInformationTable.Controls.Add(this.WorkNumberField, 1, 8);
            this.PersonalInformationTable.Controls.Add(this.FirstNameLabel, 0, 1);
            this.PersonalInformationTable.Controls.Add(this.LastNameLabel, 0, 2);
            this.PersonalInformationTable.Controls.Add(this.HomeNumberField, 1, 7);
            this.PersonalInformationTable.Controls.Add(this.EmailLabel, 0, 9);
            this.PersonalInformationTable.Controls.Add(this.WorkNumberLabel, 0, 8);
            this.PersonalInformationTable.Controls.Add(this.HomeNumberLabel, 0, 7);
            this.PersonalInformationTable.Controls.Add(this.PostalCodeLabel, 0, 6);
            this.PersonalInformationTable.Controls.Add(this.PostalCodeField, 1, 6);
            this.PersonalInformationTable.Controls.Add(this.StreetAddressField, 1, 3);
            this.PersonalInformationTable.Controls.Add(this.ProvinceField, 1, 5);
            this.PersonalInformationTable.Controls.Add(this.CityField, 1, 4);
            this.PersonalInformationTable.Controls.Add(this.ProvinceLabel, 0, 5);
            this.PersonalInformationTable.Controls.Add(this.CityLabel, 0, 4);
            this.PersonalInformationTable.Controls.Add(this.StreetAddressLabel, 0, 3);
            this.PersonalInformationTable.Location = new System.Drawing.Point(50, 88);
            this.PersonalInformationTable.Name = "PersonalInformationTable";
            this.PersonalInformationTable.RowCount = 10;
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PersonalInformationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(196, 336);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(188, 20);
            this.EmailField.TabIndex = 17;
            // 
            // LastNameField
            // 
            this.LastNameField.Location = new System.Drawing.Point(196, 77);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(188, 20);
            this.LastNameField.TabIndex = 5;
            // 
            // FirstNameField
            // 
            this.FirstNameField.Location = new System.Drawing.Point(196, 40);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(188, 20);
            this.FirstNameField.TabIndex = 3;
            // 
            // EmployeeNumberField
            // 
            this.EmployeeNumberField.Location = new System.Drawing.Point(196, 3);
            this.EmployeeNumberField.Name = "EmployeeNumberField";
            this.EmployeeNumberField.Size = new System.Drawing.Size(188, 20);
            this.EmployeeNumberField.TabIndex = 0;
            // 
            // WorkNumberField
            // 
            this.WorkNumberField.Location = new System.Drawing.Point(196, 299);
            this.WorkNumberField.Name = "WorkNumberField";
            this.WorkNumberField.Size = new System.Drawing.Size(188, 20);
            this.WorkNumberField.TabIndex = 15;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 37);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(3, 74);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // HomeNumberField
            // 
            this.HomeNumberField.Location = new System.Drawing.Point(196, 262);
            this.HomeNumberField.Name = "HomeNumberField";
            this.HomeNumberField.Size = new System.Drawing.Size(188, 20);
            this.HomeNumberField.TabIndex = 13;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(3, 333);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email";
            // 
            // WorkNumberLabel
            // 
            this.WorkNumberLabel.AutoSize = true;
            this.WorkNumberLabel.Location = new System.Drawing.Point(3, 296);
            this.WorkNumberLabel.Name = "WorkNumberLabel";
            this.WorkNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.WorkNumberLabel.TabIndex = 14;
            this.WorkNumberLabel.Text = "Work Number";
            // 
            // HomeNumberLabel
            // 
            this.HomeNumberLabel.AutoSize = true;
            this.HomeNumberLabel.Location = new System.Drawing.Point(3, 259);
            this.HomeNumberLabel.Name = "HomeNumberLabel";
            this.HomeNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.HomeNumberLabel.TabIndex = 12;
            this.HomeNumberLabel.Text = "Home Number";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(3, 222);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.PostalCodeLabel.TabIndex = 10;
            this.PostalCodeLabel.Text = "Postal Code";
            // 
            // PostalCodeField
            // 
            this.PostalCodeField.Location = new System.Drawing.Point(196, 225);
            this.PostalCodeField.Name = "PostalCodeField";
            this.PostalCodeField.Size = new System.Drawing.Size(188, 20);
            this.PostalCodeField.TabIndex = 11;
            // 
            // StreetAddressField
            // 
            this.StreetAddressField.Location = new System.Drawing.Point(196, 114);
            this.StreetAddressField.Name = "StreetAddressField";
            this.StreetAddressField.Size = new System.Drawing.Size(188, 20);
            this.StreetAddressField.TabIndex = 6;
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
            this.ProvinceField.Location = new System.Drawing.Point(196, 188);
            this.ProvinceField.Name = "ProvinceField";
            this.ProvinceField.Size = new System.Drawing.Size(188, 21);
            this.ProvinceField.TabIndex = 9;
            // 
            // CityField
            // 
            this.CityField.Location = new System.Drawing.Point(196, 151);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(188, 20);
            this.CityField.TabIndex = 7;
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(3, 185);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(49, 13);
            this.ProvinceLabel.TabIndex = 8;
            this.ProvinceLabel.Text = "Province";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(3, 148);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 6;
            this.CityLabel.Text = "City";
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Location = new System.Drawing.Point(3, 111);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.Size = new System.Drawing.Size(76, 13);
            this.StreetAddressLabel.TabIndex = 37;
            this.StreetAddressLabel.Text = "Street Address";
            // 
            // SubmitEntryButton
            // 
            this.SubmitEntryButton.Location = new System.Drawing.Point(553, 342);
            this.SubmitEntryButton.Name = "SubmitEntryButton";
            this.SubmitEntryButton.Size = new System.Drawing.Size(387, 23);
            this.SubmitEntryButton.TabIndex = 32;
            this.SubmitEntryButton.Text = "Submit Entry";
            this.SubmitEntryButton.UseVisualStyleBackColor = true;
            this.SubmitEntryButton.Click += new System.EventHandler(this.SubmitEntryButton_Click);
            // 
            // RTWInformationLabel
            // 
            this.RTWInformationLabel.AutoSize = true;
            this.RTWInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RTWInformationLabel.Location = new System.Drawing.Point(673, 21);
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
            this.NotificationsTab.Controls.Add(this.NotificationsTable);
            this.NotificationsTab.Controls.Add(this.ShowExpiredLabel);
            this.NotificationsTab.Controls.Add(this.ShowExpiredField);
            this.NotificationsTab.Controls.Add(this.SortByLabel);
            this.NotificationsTab.Controls.Add(this.SortByField);
            this.NotificationsTab.Location = new System.Drawing.Point(4, 22);
            this.NotificationsTab.Name = "NotificationsTab";
            this.NotificationsTab.Size = new System.Drawing.Size(1152, 696);
            this.NotificationsTab.TabIndex = 2;
            this.NotificationsTab.Text = "Notifications";
            this.NotificationsTab.UseVisualStyleBackColor = true;
            // 
            // NotificationsTable
            // 
            this.NotificationsTable.AllowUserToAddRows = false;
            this.NotificationsTable.AllowUserToDeleteRows = false;
            this.NotificationsTable.AllowUserToResizeColumns = false;
            this.NotificationsTable.AllowUserToResizeRows = false;
            this.NotificationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotificationsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeName,
            this.FormType,
            this.DateRequired});
            this.NotificationsTable.Location = new System.Drawing.Point(34, 14);
            this.NotificationsTable.Name = "NotificationsTable";
            this.NotificationsTable.ShowEditingIcon = false;
            this.NotificationsTable.Size = new System.Drawing.Size(750, 650);
            this.NotificationsTable.TabIndex = 4;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 200;
            // 
            // FormType
            // 
            this.FormType.HeaderText = "Form Type";
            this.FormType.Name = "FormType";
            this.FormType.ReadOnly = true;
            this.FormType.Width = 200;
            // 
            // DateRequired
            // 
            this.DateRequired.HeaderText = "Date Required By";
            this.DateRequired.Name = "DateRequired";
            this.DateRequired.ReadOnly = true;
            this.DateRequired.Width = 307;
            // 
            // ShowExpiredLabel
            // 
            this.ShowExpiredLabel.AutoSize = true;
            this.ShowExpiredLabel.Location = new System.Drawing.Point(812, 54);
            this.ShowExpiredLabel.Name = "ShowExpiredLabel";
            this.ShowExpiredLabel.Size = new System.Drawing.Size(72, 13);
            this.ShowExpiredLabel.TabIndex = 3;
            this.ShowExpiredLabel.Text = "Show Expired";
            // 
            // ShowExpiredField
            // 
            this.ShowExpiredField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowExpiredField.FormattingEnabled = true;
            this.ShowExpiredField.Items.AddRange(new object[] {
            "None",
            "Last 3 days",
            "Last Week",
            "Last 3 Weeks",
            "Last Month",
            "All"});
            this.ShowExpiredField.Location = new System.Drawing.Point(929, 51);
            this.ShowExpiredField.Name = "ShowExpiredField";
            this.ShowExpiredField.Size = new System.Drawing.Size(204, 21);
            this.ShowExpiredField.TabIndex = 2;
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Location = new System.Drawing.Point(812, 18);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(41, 13);
            this.SortByLabel.TabIndex = 1;
            this.SortByLabel.Text = "Sort By";
            this.SortByLabel.Click += new System.EventHandler(this.SortByLabel_Click);
            // 
            // SortByField
            // 
            this.SortByField.DisplayMember = " ";
            this.SortByField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortByField.FormattingEnabled = true;
            this.SortByField.Items.AddRange(new object[] {
            "Date",
            "Form Type",
            "Name"});
            this.SortByField.Location = new System.Drawing.Point(929, 15);
            this.SortByField.Name = "SortByField";
            this.SortByField.Size = new System.Drawing.Size(204, 21);
            this.SortByField.TabIndex = 0;
            this.SortByField.SelectedIndexChanged += new System.EventHandler(this.SortByField_SelectedIndexChanged);
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
            this.DataEntryTab.ResumeLayout(false);
            this.DataEntryTab.PerformLayout();
            this.RTWInformationTable.ResumeLayout(false);
            this.RTWInformationTable.PerformLayout();
            this.PersonalInformationTable.ResumeLayout(false);
            this.PersonalInformationTable.PerformLayout();
            this.NotificationsTab.ResumeLayout(false);
            this.NotificationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsTable)).EndInit();
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
        private System.Windows.Forms.TabPage DataEntryTab;
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
        private System.Windows.Forms.TextBox FirstNameField;
        private System.Windows.Forms.TextBox LastNameField;
        private System.Windows.Forms.TextBox CityField;
        private System.Windows.Forms.ComboBox ProvinceField;
        private System.Windows.Forms.TextBox PostalCodeField;
        private System.Windows.Forms.TextBox HomeNumberField;
        private System.Windows.Forms.TextBox WorkNumberField;
        private System.Windows.Forms.RadioButton ExistingPersonButton;
        private System.Windows.Forms.ComboBox ExistingPersonSearchField;
        private System.Windows.Forms.Label StreetAddressLabel;
        private System.Windows.Forms.TextBox StreetAddressField;
        private System.Windows.Forms.Button PublishButton;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.ComboBox SortByField;
        private System.Windows.Forms.Label ShowExpiredLabel;
        private System.Windows.Forms.ComboBox ShowExpiredField;
        private System.Windows.Forms.DataGridView NotificationsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequired;
    }
}

