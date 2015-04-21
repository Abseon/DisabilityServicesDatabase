using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DisabilityServiceDatabase
{
    public partial class MainFrame : Form
    {
        // Collection Representing the Entries recieved from the Database 
        private List<DataEntry> MainDatabase = new List<DataEntry>();
        // Collection Representing the Entires added during the current Session
        private List<DataEntry> AddedEntries = new List<DataEntry>();
        // Collection To Handle Notification Dates
        private List<Notification> Notifications = new List<Notification>();
        // Boolean representing the status of data entry, defaults to false for !existingPerson
        Boolean ExistingPerson = false;
        // Reference list translating a Last Name, First Name String to an employee number used by ExistingSearch
        private Dictionary<String, int> ReferenceTable = new Dictionary<string, int>(); 
        // Existing person data
        private DataEntry ExistingPersonReference = null;
        // Path of database to be connected to
        private string DatabaseLocation;
        // Existing Employee List for refilling the combo box after text is entered
        private List<string> ExistingEmployees = new List<string>();

        public MainFrame()
        {
            InitializeComponent();
            SetConnectionString();
            DatabaseRead("Employee");   
            DatabaseRead("Case");      
            PopulateNotifications();
            DisplayNotifications("Date","None");
            DisplayReports();
            SetInitial();
        }

        // Action Listeners
        private void ExistingPersonButton_Click(object sender, EventArgs e)
        {
            // Switches from Personal Input to an existing person search
            ExistingPerson = !ExistingPerson;
            PersonalInformationTable.Visible = !PersonalInformationTable.Visible;
            ExistingPersonSearchField.Visible = !ExistingPersonSearchField.Visible;
            ExistingPersonButton.Checked = ExistingPerson;
            if (ExistingPerson)
            {
                FillExistingPersonSearch();
            }
        }
        private void SubmitEntryButton_Click(object sender, EventArgs e)
        {
            // On submit button press all entered data is added as a DataEntry object to AddedEntries
            DataEntry NewEntry = new DataEntry();
            int test; //Used to test if the employee number is valid
            if ((EmployeeNumberField.Text != "" && Int32.TryParse(EmployeeNumberField.Text, out test)) || (ExistingPerson && ExistingPersonReference != null))
            {
                // Potentially find a better way to fill these
                if (ExistingPerson && ExistingPersonReference != null ) {
                    // Use Existing Person to fill instead of fields
                    NewEntry.PersonalFields["Employment Number"] = ExistingPersonReference.PersonalFields["Employment Number"];
                    NewEntry.PersonalFields["First Name"] = ExistingPersonReference.PersonalFields["First Name"];
                    NewEntry.PersonalFields["Last Name"] = ExistingPersonReference.PersonalFields["Last Name"];
                    NewEntry.PersonalFields["Street Address"] = ExistingPersonReference.PersonalFields["Street Address"];
                    NewEntry.PersonalFields["City"] = ExistingPersonReference.PersonalFields["City"];
                    NewEntry.PersonalFields["Province"] = ExistingPersonReference.PersonalFields["Province"];
                    NewEntry.PersonalFields["Postal Code"] = ExistingPersonReference.PersonalFields["Postal Code"];
                    NewEntry.PersonalFields["Phone Number (Home)"] = ExistingPersonReference.PersonalFields["Phone Number (Home)"];
                    NewEntry.PersonalFields["Phone Number (Work)"] = ExistingPersonReference.PersonalFields["Phone Number (Work)"];
                    NewEntry.PersonalFields["Email"] = ExistingPersonReference.PersonalFields["Email"];
                    NewEntry.RTWFields["Employee Number"] = ExistingPersonReference.PersonalFields["Employment Number"];
                    NewEntry.ExistingPerson = true;
                }
                else 
                {
                    NewEntry.PersonalFields["Employment Number"] = Int32.Parse(EmployeeNumberField.Text);
                    NewEntry.PersonalFields["First Name"] = FirstNameField.Text;
                    NewEntry.PersonalFields["Last Name"] = LastNameField.Text;
                    NewEntry.PersonalFields["Street Address"] = StreetAddressField.Text;
                    NewEntry.PersonalFields["City"] = CityField.Text;
                    NewEntry.PersonalFields["Province"] = ProvinceField.Text;
                    NewEntry.PersonalFields["Postal Code"] = PostalCodeField.Text;
                    NewEntry.PersonalFields["Phone Number (Home)"] = HomeNumberField.Text;
                    NewEntry.PersonalFields["Phone Number (Work)"] = WorkNumberField.Text;
                    NewEntry.PersonalFields["Email"] = EmailField.Text;
                    NewEntry.RTWFields["Employee Number"] = Int32.Parse(EmployeeNumberField.Text);
                }

                NewEntry.RTWFields["Status"] = StatusField.Text;
                NewEntry.RTWFields["LTD Eligible"] = LTDEligibleField.Checked;
                NewEntry.RTWFields["Referral Recieved"] = ReferralReceivedField.Value;
                NewEntry.RTWFields["Sick Leave Start"] = StartDateField.Value;

                // Because these are currency types it converts to decimal if possible otherwise defaults to 0 // Probably change to 0 on "" else error
                decimal testDecimal;
                if (Decimal.TryParse(DailyHoursWorkedField.Text,out testDecimal))
                {
                    NewEntry.RTWFields["Hours Worked/Day"] = Decimal.Parse(DailyHoursWorkedField.Text);
                } 
                else
                {
                    NewEntry.RTWFields["Hours Worked/Day"] = 0m;
                }
                if (Decimal.TryParse(HourlySalaryField.Text, out testDecimal))
                {
                    NewEntry.RTWFields["Hourly Salary"] = Decimal.Parse(HourlySalaryField.Text);
                }
                else
                {
                    NewEntry.RTWFields["Hourly Salary"] = 0m;
                }
                
                NewEntry.ContainsCaseInfo = true;
                NewEntry.ContainsPersonalInfo = true;

                //Potentially add calculated fields, otherwise let database fill them
                if (AddedEntries.Count == 0)
                {
                    // Sets up option to publish
                    PublishButton.Visible = true;
                }
                AddedEntries.Add(NewEntry);
                ClearFields();
            }
            else
            {
                if (ExistingPerson)
                {
                    MessageBox.Show("Please select an employee");
                }
                else
                {
                    MessageBox.Show("Entered Employee number must be a number");
                }
                
            }
        }
        private void PublishButton_Click(object sender, EventArgs e)
        {
            // Confirms publish then iterates through added entries and writes them to the Database
            String plural;
            if (AddedEntries.Count == 1)
            {
                plural = " entry ";
            }
            else
            {
                plural = " entries ";
            }
            if (MessageBox.Show("There are " + AddedEntries.Count.ToString() + plural + "to be Published\n Proceed?", "Publish", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                foreach (DataEntry inputEntry in AddedEntries)
                {
                    DatabaseWrite(inputEntry);
                }
                PublishButton.Visible = false;
            }
            
        }
        private void ExistingPersonSearchField_Changed(object sender, EventArgs e)
        {
            Debug.WriteLine("Enter");
            // On Person select switch the Existing Person reference
            String CurrentPerson = ExistingPersonSearchField.SelectedItem.ToString();
            int SearchID = ReferenceTable[CurrentPerson];
            foreach (DataEntry item in MainDatabase)
            {
                if (item.ContainsPersonalInfo)
                {
                    if (item.PersonalFields["Employment Number"].ToString() == SearchID.ToString())
                    {
                        ExistingPersonReference = item;
                    }
                }
            }
        }
        private void ExistingPersonSearchField_TextUpdate(object sender, EventArgs e)
        {
            // Reset the Reference as a value may not be a employee
            ExistingPersonReference = null;
            // Refresh before removing
            ExistingPersonSearchField.Items.Clear();
            foreach (String ExistingName in ExistingEmployees)
            {
                ExistingPersonSearchField.Items.Add(ExistingName);
            }
            //  Resets the cursor
            ExistingPersonSearchField.SelectionStart = ExistingPersonSearchField.Text.Length;
            // Update List to only contain names with the text in the text box
            String NewText = ExistingPersonSearchField.Text;
            List<String> ToRemove = new List<String>();
            if (NewText != "")
            {
                foreach (String EmployeeName in ExistingPersonSearchField.Items)
                {
                    if (!EmployeeName.Contains(NewText))
                    {
                        ToRemove.Add(EmployeeName);
                    }
                }
            }
            foreach (String RemovedName in ToRemove)
            {
                ExistingPersonSearchField.Items.Remove(RemovedName);
            }

        }
        private void SortByField_Changed(object sender, EventArgs e)
        {
            RefreshNotifications();
        }
        private void ShowExpiredField_Changed(object sender, EventArgs e)
        {
            RefreshNotifications();
        }
        private void NotificationsTable_CellContentClicked(object sender, DataGridViewCellEventArgs e)
        {
            // Update the Notification that in the database and then remove it from notifications
            if (NotificationsTable.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewCheckBoxCell) // Potentially rewrite or add references to the sorted notifications list to avoid search
            {
                Notification ToDelete = null;
                foreach (Notification NotificationCase in Notifications)
                {
                    if (NotificationsTable.Rows[e.RowIndex].Cells[0].Value.ToString() == NotificationCase.EmployeeName && NotificationsTable.Rows[e.RowIndex].Cells[1].Value.ToString() == NotificationCase.NotificationType)// Looks for Name and notification type match
                    {
                        ToDelete = NotificationCase;
                    }
                    
                }
                if (ToDelete != null)
                {
                    // Update database with today's date
                    Dictionary<String,String> AssociatedFieldsLookup = new Dictionary<String,String>() { 
                        {"Sick Leave Expiry",null}, {"180 Days Follow-Up",null}, {"LTD Application Required","LTD Application Sent"},
                        {"Benefits Sheet Required","Benefits Sheet Sent"},{"Day 160",null},{"Day 181 + 3 Months",null},{"Return To Work Follow-Up","RTW Follow-Up Complete"},
                        {"Return To Work End Plan",null},{"Accomodation Follow-Up",null} 
                    };
                    String AssociatedType = AssociatedFieldsLookup[ToDelete.NotificationType];
                    if (AssociatedType != null)
                    {
                        DatabaseUpdate("Documentation", "`" + AssociatedType + "`", "\"" + DateTime.Today.ToShortDateString() + "\"", "ID", ToDelete.CaseNumber.ToString());
                    }
                    Notifications.Remove(ToDelete);
                    RefreshNotifications();
                }
                

            }
            
        }
        // Database Access Functions
        private Boolean DatabaseRead(String commandString)
        {
            // Connects to the access database and reads entries into MainDatabase
            // Connect string determines the table to read or a custom command string
            // Returns true on success false on failure
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DatabaseLocation +";Persist Security Info=False;";
            string StringCommand;
            switch (commandString)
            {
                case "Employee":
                    StringCommand = "SELECT * FROM `Client Contact Information`;";
                    break;
                case "Case":
                    StringCommand = "SELECT * FROM Documentation;";
                    break;
                default:
                    StringCommand = commandString;
                    break;

            } 
            OleDbConnection DatabaseConnection = new OleDbConnection(ConnectionString);
            OleDbCommand DatabaseCommand = new OleDbCommand(StringCommand, DatabaseConnection);
            OleDbDataAdapter DatabaseAdapter = new OleDbDataAdapter(DatabaseCommand);
            DataSet DatabaseSet = new DataSet();

            // Attempts to Connect to the database
            try 
            { 
                
                DatabaseConnection.Open();
                DatabaseAdapter.Fill(DatabaseSet);
                // DB Access Here is the first table as there is only one because of the query
                DataRowCollection DatabaseRows = DatabaseSet.Tables[0].Rows;

                if (commandString == "Employee")
                {   
                    
                    foreach (DataRow SingleRow in DatabaseRows)
                    {
                        // Reads the values into a Data Entry - this is order dependent
                        DataEntry ReadEntry = new DataEntry();
                        String[] EmployeeFields = new String[] { "Employment Number", "Last Name", "First Name","Street Address","City","Province","Postal Code","Phone Number (Home)","Phone Number (Work)","Email" }; // Consider replacing with reference
                        int SetLength;
                        if (SingleRow.ItemArray.Length < EmployeeFields.Length)
                        {
                            SetLength = SingleRow.ItemArray.Length;
                        }
                        else
                        {
                            SetLength = EmployeeFields.Length;
                        }
                        for (int i = 0; i < SetLength; i++)
                        {
                            ReadEntry.PersonalFields[EmployeeFields[i]] = SingleRow.ItemArray[i];
                        }
                        ReadEntry.ContainsPersonalInfo = true;
                        MainDatabase.Add(ReadEntry);
                    }
                }
                else if (commandString == "Case")
                {
                    foreach (DataRow SingleRow in DatabaseRows)
                    {
                        // Reads the values into a Data Entry - this is order dependent
                        DataEntry ReadEntry = new DataEntry();
                        String[] CaseFields = new String[] { "ID", "Employee Number","Status", "LTD Eligible", "Referral Recieved", "Sick Leave Start", "Sick Leave Expiry", "180 Days Follow-Up", "LTD Application Required",
                            "LTD Application Sent", "Employee Stat to GWL","Benefits Sheet Required","Day 160","Day 181 + 3 Months","Benefits Sheet Sent","Benefits Sheet Recieved","Accomodation Start Date",
                            "Return to Work","Return to Work Date","Return To Work Follow-Up","RTW Follow-Up Complete","Return To Work End Plan","Accomodation Follow-Up","Number of Days Absent","Hourly Salary",
                            "Hours Worked/Day","SL Cost/Day"}; // Consider replacing with reference
                        int SetLength;
                        if (SingleRow.ItemArray.Length < CaseFields.Length)
                        {
                            SetLength = SingleRow.ItemArray.Length;
                        }
                        else
                        {
                            SetLength = CaseFields.Length;
                        }
                        for (int i = 0; i < SetLength ; i++)
                        {
                            ReadEntry.RTWFields[CaseFields[i]] = SingleRow.ItemArray[i];
                        }
                        ReadEntry.ContainsCaseInfo= true;
                        MainDatabase.Add(ReadEntry);
                    }
                }
                DatabaseConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                // DB should always close
                DatabaseConnection.Close();
                MessageBox.Show(ex.Message);
                if (MessageBox.Show("Error occurred in Database Connect", "Retry?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    return DatabaseRead(commandString);
                }
                else
                {
                    return false;
                }
            }
            
        }
        private Boolean DatabaseWrite(DataEntry inputEntry)
        {
            // Writes a given inputEntry to the Access Database
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DatabaseLocation + ";Persist Security Info=False;";
            string EmployeeInsertCommand = "INSERT INTO `Client Contact Information` (";
            string CaseInsertCommand = "INSERT INTO Documentation (";
            
            // Writing Insert Command strings
            String[] EmployeeFields = new String[10] { "Employment Number", "Last Name", "First Name", "Street Address", "City", "Province", "Postal Code", "Phone Number (Home)", "Phone Number (Work)", "Email" }; // Consider replacing with reference // Also may differ from actual DB
            for (int i = 0; i < EmployeeFields.Length; i++)
            {
                EmployeeInsertCommand += "`" + EmployeeFields[i] + "`";
                if (i != EmployeeFields.Length - 1)
                {
                    EmployeeInsertCommand += ",";
                }
            }
            EmployeeInsertCommand += ") VALUES (";
            if (!inputEntry.ExistingPerson)
            {
                for (int i = 0; i < EmployeeFields.Length; i++)
                {
                    object entryValue = inputEntry.PersonalFields[EmployeeFields[i]];
                    if (entryValue is int)
                    {
                        EmployeeInsertCommand += entryValue.ToString();
                    }
                    else
                    {
                        EmployeeInsertCommand += "\"" + entryValue.ToString() + "\"";
                    }
                    if (i != EmployeeFields.Length - 1)
                    {
                        EmployeeInsertCommand += ",";
                    }
                }
            }
            EmployeeInsertCommand += ")";

            String[] CaseFields = new String[7] { "Employee Number","Status", "LTD Eligible", "Referral Recieved", "Sick Leave Start","Hourly Salary","Hours Worked/Day"}; //Replace with reference probably //Ignores ID and non filled fields
            for (int i = 0; i < CaseFields.Length; i++)
            {
                CaseInsertCommand += "`" + CaseFields[i] + "`";
                if (i != CaseFields.Length - 1)
                {
                    CaseInsertCommand += ",";
                }
            }
            CaseInsertCommand += ") VALUES (";
            for (int i = 0; i < CaseFields.Length; i++)
            {
                object entryValue = inputEntry.RTWFields[CaseFields[i]];
                if (entryValue == null)
                {
                    entryValue = "";
                }
                if (entryValue is int || entryValue is bool || entryValue is decimal)
                {
                    CaseInsertCommand += entryValue.ToString();
                } 
                else
                {
                    CaseInsertCommand += "\"" + entryValue.ToString() + "\"";
                }
                if (i != CaseFields.Length - 1)
                {
                    CaseInsertCommand += ",";
                }
            }
            CaseInsertCommand += ")";

            OleDbConnection DatabaseConnection = new OleDbConnection(ConnectionString);
            OleDbCommand EmployeeCommand = new OleDbCommand(EmployeeInsertCommand, DatabaseConnection);
            OleDbCommand CaseCommand = new OleDbCommand(CaseInsertCommand, DatabaseConnection);

            // Attempts to Connect to the database
            try
            {

                DatabaseConnection.Open();
                // DB Access Here is the first table as there is only one because of the query
                if (!inputEntry.ExistingPerson)
                {
                    EmployeeCommand.ExecuteNonQuery();
                }
                CaseCommand.ExecuteNonQuery();
                
                DatabaseConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                // Make sure to close DB on fail or success
                DatabaseConnection.Close();
                MessageBox.Show(ex.Message);
                if (MessageBox.Show("Error occurred in Database Connect", "Retry?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    return DatabaseWrite(inputEntry);
                }
                else
                {
                    return false;
                }
            }
        }
        private Boolean DatabaseUpdate(String tableName, String updatedField, String updatedValue, String searchField, String searchValue)
        {
            // Provides the ability to update a table with a given field value based on search values
            // Note provided string values must have the surrounding "" quotes
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DatabaseLocation + ";Persist Security Info=False;";
            string UpdateCommandString = "UPDATE " + tableName + " SET " + updatedField + "=" + updatedValue + " WHERE " + searchField + "=" + searchValue + ";";
            OleDbConnection DatabaseConnection = new OleDbConnection(ConnectionString);
            OleDbCommand UpdateCommand = new OleDbCommand(UpdateCommandString, DatabaseConnection);
            try
            {
                DatabaseConnection.Open();
                UpdateCommand.ExecuteNonQuery();
                DatabaseConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                // Make sure to close DB on fail or success
                DatabaseConnection.Close();
                MessageBox.Show(ex.Message);
                if (MessageBox.Show("Error occurred in Database Connect", "Retry?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    return DatabaseUpdate(tableName, updatedField, updatedValue, searchField, searchValue);
                }
                else
                {
                    return false;
                }
            }
        }
        // Custom Functions
        private void FillExistingPersonSearch()
        {
            // Fills the Existing Person Search Field with the names of people currently in the database
            List<String> FillList = new List<String>();
            // Resets Reference Table and Existing SearchField to be filled 
            ReferenceTable = new Dictionary<string, int>();
            ExistingPersonSearchField.Items.Clear();
            foreach (DataEntry item in MainDatabase)
            {
                if (item.ContainsPersonalInfo)
                {
                    String FillString = item.PersonalFields["Last Name"].ToString() + "," + item.PersonalFields["First Name"].ToString();
                    FillList.Add(FillString);
                    ReferenceTable.Add(FillString, Convert.ToInt32(item.PersonalFields["Employment Number"])); // Note potential error if not convertable !!!

                }
            }
            FillList.Sort();
            foreach (String Name in FillList)
            {
                ExistingPersonSearchField.Items.Add(Name);
                ExistingEmployees.Add(Name);
            }
        }
        private void SetConnectionString()
        {
            OpenFileDialog ConnectionPrompt = new OpenFileDialog();

            ConnectionPrompt.Filter = "Access Files (*.accdb)|*.accdb|All files (*.*)|*.*";
            ConnectionPrompt.FilterIndex = 0;
            ConnectionPrompt.RestoreDirectory = true;

            if (ConnectionPrompt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DatabaseLocation = ConnectionPrompt.FileName.ToString();
                }
                catch (Exception ex)
                {
                    SetConnectionString();
                }
            }
        }
        private void PopulateNotifications()
        {
            // Takes the inputted MainDatabase and populates a list of Notification object 
            // for use by the notifications section

            // Separates Employee and case entries
            List<DataEntry> cases = new List<DataEntry>();
            List<DataEntry> employees = new List<DataEntry>();
            // Set List of Forms/notifications to add
            String[] CaseDateFields = new String[] {  "Sick Leave Expiry", "180 Days Follow-Up", "LTD Application Required","Benefits Sheet Required","Day 160","Day 181 + 3 Months",
                            "Return To Work Follow-Up","Return To Work End Plan","Accomodation Follow-Up"};
            // List of associated dates that show if a form is completed and when (null if no associated form)
            // Must be equal in length
            String[] AssociatedCaseFields = new String[] { null, null, "LTD Application Sent", "Benefits Sheet Sent", null, null,"RTW Follow-Up Complete", null, null};
            foreach (DataEntry entry in MainDatabase)
            {   
                // Assumes only one is true
                if (entry.ContainsCaseInfo)
                {
                    cases.Add(entry);
                }
                else if (entry.ContainsPersonalInfo)
                {
                    employees.Add(entry);
                }
            }
            foreach (DataEntry caseData in cases)
            {   
                // First find the associated employee's name
                String employeeName = "";
                int caseNumber = Int32.Parse(caseData.RTWFields["ID"].ToString()); //Technically has potential for error ?
                foreach (DataEntry employee in employees)
                {
                    if (employee.PersonalFields["Employment Number"].ToString() == caseData.RTWFields["Employee Number"].ToString())
                    { 
                        employeeName = employee.PersonalFields["Last Name"] + ", " + employee.PersonalFields["First Name"];
                    }
                } 
                for (int i = 0; i < CaseDateFields.Length;i++)
                {
                    if (AssociatedCaseFields[i] == null) // Ignore complete check if there is no associated field
                    {
                            Notification addedNotification = new Notification();
                            addedNotification.CaseNumber = caseNumber;
                            if (caseData.RTWFields[CaseDateFields[i]] is DateTime)
                            {
                                addedNotification.NotificationDate = (DateTime)caseData.RTWFields[CaseDateFields[i]]; //Bugs if empty due to cast
                            }
                            addedNotification.NotificationType = CaseDateFields[i];
                            addedNotification.EmployeeName = employeeName;
                            Notifications.Add(addedNotification);
                    }
                    else
                    {
                        if (caseData.RTWFields[AssociatedCaseFields[i]] == null || caseData.RTWFields[AssociatedCaseFields[i]] is DBNull) // Only add if the associated sent/complete field is null
                        {

                            Notification addedNotification = new Notification();
                            addedNotification.CaseNumber = caseNumber;
                            if (caseData.RTWFields[CaseDateFields[i]] is DateTime)
                            {
                                addedNotification.NotificationDate = (DateTime)caseData.RTWFields[CaseDateFields[i]]; //Bugs if empty due to cast
                            }
                            addedNotification.NotificationType = CaseDateFields[i];
                            addedNotification.EmployeeName = employeeName;
                            Notifications.Add(addedNotification);
                        }
                    }
                }

            }
        }
        private void DisplayNotifications(string SortBy,String CutOffDate)
        {
            // Takes the Given Notifications List and Fills the Notification Table
            // Switch allows for sort by different aspects
            List<Notification> SortedNotifications;
            switch (SortBy)
            {
                case "Name":
                    SortedNotifications = Notifications.OrderBy(a => a.EmployeeName).ToList<Notification>();
                    break;
                case "Form":
                    SortedNotifications = Notifications.OrderBy(a => a.NotificationType).ToList<Notification>();
                    break;
                case "Date":
                    SortedNotifications = Notifications.OrderBy(a => a.NotificationDate).ToList<Notification>();
                    break;
                default:
                    SortedNotifications = Notifications.OrderBy(a => a.NotificationDate).ToList<Notification>();
                    break;

            }
            DateTime SortDate;
            // Chooses the cut off date Note: this will not change until refreshed
            switch (CutOffDate)
            {
                case "None":
                    SortDate = DateTime.Today.AddDays(-1); // Include the current date
                    break;
                case "Last Week":
                    SortDate = DateTime.Today.AddDays(-7);
                    break;
                case "Last 3 Weeks":
                    SortDate = DateTime.Today.AddDays(-21);
                    break;
                case "Last Month":
                    SortDate = DateTime.Today.AddMonths(-1);
                    break;
                case "All":
                    SortDate = DateTime.MinValue;
                    break;
                default:
                    SortDate = DateTime.Today;
                    break;
            }
            foreach (Notification FormDate in SortedNotifications)
            {
                if (FormDate.NotificationDate > SortDate)
                {
                    NotificationsTable.Rows.Add(FormDate.EmployeeName, FormDate.NotificationType, FormDate.NotificationDate.ToShortDateString(),false);
                }
            }
        }
        private void ClearNotifications()
        {
            NotificationsTable.Rows.Clear();
        }
        private void DisplayReports()
        {
            // Sets up the Reports Table on program start or report select
            String[] CaseFields = new String[] {"Employee Number","Status", "LTD Eligible", "Referral Recieved", "Sick Leave Start", "Sick Leave Expiry", "180 Days Follow-Up", "LTD Application Required",
                            "LTD Application Sent", "Employee Stat to GWL","Benefits Sheet Required","Day 160","Day 181 + 3 Months","Benefits Sheet Sent","Benefits Sheet Recieved","Accomodation Start Date",
                            "Return to Work","Return to Work Date","Return To Work Follow-Up","RTW Follow-Up Complete","Return To Work End Plan","Accomodation Follow-Up","Number of Days Absent","Hourly Salary",
                            "Hours Worked/Day","SL Cost/Day"};
            for (int i = 0;i < CaseFields.Length;i++)
            {
                ReportTable.Columns.Add(CaseFields[i], CaseFields[i]);
            }
            // Set Default Size of Columns
            foreach (DataGridViewColumn col in ReportTable.Columns)
            {
                col.Width = 80;
            }
            // Sample Code
            String[] SampleFields = new String[26];
            foreach (DataEntry data in MainDatabase)
            {
                if (data.ContainsCaseInfo)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (data.RTWFields[CaseFields[i]] != null)
                        {
                            SampleFields[i] = data.RTWFields[CaseFields[i]].ToString();
                        }
                        else
                        {
                            SampleFields[i] = "";
                        }
                    }
                    ReportTable.Rows.Add(SampleFields);
                }
            }

        }
        private void ClearFields()
        {
            foreach (Control Cont in PersonalInformationTable.Controls)
            {
                if (Cont is TextBox)
                {
                    Cont.ResetText();
                }
            }
            foreach (Control Cont in RTWInformationTable.Controls)
            {
                if (Cont is TextBox)
                {
                    Cont.ResetText();
                }
            }
        }
        private void SetInitial()
        {
            // Sets the initial values of several fields (purely aesthetic)
            SortByField.SelectedIndex = 0;
            ShowExpiredField.SelectedIndex = 0;
            ReportSelectField.SelectedIndex = 0;
        }
        private void RefreshNotifications()
        {
            // Clear and update notifications table
            ClearNotifications();
            if (SortByField.SelectedItem == null)
            {
                DisplayNotifications("Date", ShowExpiredField.SelectedItem.ToString());
            }
            else if (ShowExpiredField.SelectedItem == null)
            {
                DisplayNotifications(SortByField.SelectedItem.ToString(), "None");
            }
            else
            {
                DisplayNotifications(SortByField.SelectedItem.ToString(), ShowExpiredField.SelectedItem.ToString());
            }
        }

    }
    public class DataEntry
    {
        // Class representing the data contained in a single entry either created by the application or read from the database
        // Note: This may contain Case info, personal info or both
        
        //RTW (Case) Information
        public Dictionary<string, object> RTWFields = new Dictionary<string, object>();
        //Personal Info
        public Dictionary<string, object> PersonalFields = new Dictionary<string, object>();
        // Booleans indicating the information in the field defaulted to false
        public Boolean ContainsCaseInfo = false;
        public Boolean ContainsPersonalInfo = false;
        // Prevents Insertion of already existing person
        public Boolean ExistingPerson = false;
    
        public DataEntry()
        {
            // Constructor adding all fields to their respective dictionary 
            // Consider replacing with reference
            RTWFields.Add("ID",null);
            RTWFields.Add("Employee Number", null);
            RTWFields.Add("Status", null);
            RTWFields.Add("LTD Eligible", null);
            RTWFields.Add("Referral Recieved", null);
            RTWFields.Add("Sick Leave Start", null);
            RTWFields.Add("Sick Leave Expiry", null);
            RTWFields.Add("180 Days Follow-Up", null);
            RTWFields.Add("LTD Application Required", null);
            RTWFields.Add("LTD Application Sent", null);
            RTWFields.Add("Employee Stat to GWL", null);
            RTWFields.Add("Benefits Sheet Required", null);
            RTWFields.Add("Day 160", null);
            RTWFields.Add("Day 181 + 3 Months", null);
            RTWFields.Add("Benefits Sheet Sent", null);
            RTWFields.Add("Benefits Sheet Recieved", null);
            RTWFields.Add("Accomodation Start Date", null);
            RTWFields.Add("Return to Work", null);
            RTWFields.Add("Return to Work Date", null);
            RTWFields.Add("Return To Work Follow-Up", null);
            RTWFields.Add("RTW Follow-Up Complete", null);
            RTWFields.Add("Return To Work End Plan", null);
            RTWFields.Add("Accomodation Follow-Up", null);
            RTWFields.Add("Number of Days Absent", null);
            RTWFields.Add("Hourly Salary", null);
            RTWFields.Add("Hours Worked/Day", null);
            RTWFields.Add("SL Cost/Day", null);

            PersonalFields.Add("Employment Number",null);
            PersonalFields.Add("Last Name",null);
            PersonalFields.Add("First Name", null);
            PersonalFields.Add("Street Address", null);
            PersonalFields.Add("City", null);
            PersonalFields.Add("Province", null);
            PersonalFields.Add("Postal Code", null);
            PersonalFields.Add("Phone Number (Home)", null);
            PersonalFields.Add("Phone Number (Work)", null);
            PersonalFields.Add("Email", null);

        }

    }
    public class Notification
    {
        // A class which encapsulates basic info on a specific form to be sent
        // as well as a reference to the DataEntry that it is based off of
        public String EmployeeName;
        public DateTime NotificationDate;
        public String NotificationType;
        public int CaseNumber;
    }
}
