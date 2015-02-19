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
        // Boolean representing the status of data entry, defaults to false for !existingPerson
        Boolean ExistingPerson = false;
        // Reference list translating a Last Name, First Name String to an employee number used by ExistingSearch
        private Dictionary<String, int> ReferenceTable = new Dictionary<string, int>(); // Change Name?
        // Existing person data
        private DataEntry ExistingPersonReference = null;

        public MainFrame()
        {
            InitializeComponent();
            DatabaseRead("Employee");
            DatabaseRead("Case");
        }

        // Action Listeners
        private void ReferralRecievedLabel_Click(object sender, EventArgs e)
        {

        }
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
            if (EmployeeNumberField.Text != "" || ExistingPerson)
            {
                
                if (ExistingPerson && ExistingPersonReference != null) {
                    // Use Existing Person to fill instead of fields
                    NewEntry.PersonalFields["Employment Number"] = ExistingPersonReference.PersonalFields["Employment Number"];
                    NewEntry.PersonalFields["First Name"] = ExistingPersonReference.PersonalFields["First Name"];
                    NewEntry.PersonalFields["Last Name"] = ExistingPersonReference.PersonalFields["Last Name"];
                    NewEntry.PersonalFields["Street Address"] = ExistingPersonReference.PersonalFields["Street Address"];
                    NewEntry.PersonalFields["City"] = ExistingPersonReference.PersonalFields["City"];
                    NewEntry.PersonalFields["Province"] = ExistingPersonReference.PersonalFields["Province"];
                    NewEntry.PersonalFields["Phone Number (Home)"] = ExistingPersonReference.PersonalFields["Phone Number (Home)"];
                    NewEntry.PersonalFields["Phone Number (Work)"] = ExistingPersonReference.PersonalFields["Phone Number (Work)"];
                    NewEntry.PersonalFields["Email"] = ExistingPersonReference.PersonalFields["Email"];
                }
                else
                {
                    NewEntry.PersonalFields["Employment Number"] = EmployeeNumberField.Text;
                    NewEntry.PersonalFields["First Name"] = FirstNameField.Text;
                    NewEntry.PersonalFields["Last Name"] = LastNameField.Text;
                    NewEntry.PersonalFields["Street Address"] = StreetAddressField.Text;
                    NewEntry.PersonalFields["City"] = CityField.Text;
                    NewEntry.PersonalFields["Province"] = ProvinceField.Text;
                    NewEntry.PersonalFields["Phone Number (Home)"] = HomeNumberField.Text;
                    NewEntry.PersonalFields["Phone Number (Work)"] = WorkNumberField.Text;
                    NewEntry.PersonalFields["Email"] = EmailField.Text;
                }
                // Potentially find a better way to fill these
                

                NewEntry.RTWFields["Employment Number"] = EmployeeNumberField.Text;
                NewEntry.RTWFields["LTD Eligible"] = LTDEligibleField.Checked;
                NewEntry.RTWFields["Referral Recieved"] = ReferralReceivedField.Value;
                NewEntry.RTWFields["Start Date"] = StartDateField.Value;
                NewEntry.RTWFields["Hours Worked/Day"] = DailyHoursWorkedField.Text;
                NewEntry.RTWFields["Hourly Salary"] = HourlySalaryField.Text;

                //Potentially add calculated fields, otherwise let database fill them
                AddedEntries.Add(NewEntry);
            }
            else
            {
                // TO DO: ERROR TEXT BOX as employee # is critical
            }
        }
        private void ExistingPersonSearchField_Changed(object sender, EventArgs e)
        {
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
        private void FillExistingPersonSearch()
        {
            // Fills the Existing Person Search Field with the names of people currently in the database
            List<String> FillList = new List<String>();
            // Resets Reference Table and Sxisting SearchField to be filled 
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
            foreach (String name in FillList)
            {
                ExistingPersonSearchField.Items.Add(name);
            }
        }
        // Custom Functions
        private Boolean DatabaseRead(String commandString)
        {
            // Connects to the access database and reads entries into MainDatabase
            // Connect string determines the table to read or a custom command string
            // Returns true on success false on failure
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sean\Documents\DisabilityServicesDB.accdb;Persist Security Info=False;"; //Temporarily referencing a static location
            string StringCommand;
            switch (commandString)
            {
                case "Employee":
                    StringCommand = "SELECT * FROM Employees;";
                    break;
                case "Case":
                    StringCommand = "SELECT * FROM CaseInfo;";
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
                        String[] EmployeeFields = new String[10] { "Employment Number", "Last Name", "First Name","Street Address","City","Province","Postal Code","Phone Number (Home)","Phone Number (Work)","Email" }; // Consider replacing with reference
                        for (int i = 0; i < 10; i++)
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
                        String[] CaseFields = new String[26] { "ID", "Employee Number", "LTD Eligible", "Referral Recieved", "Sick Leave Start", "Sick Leave Expiry", "180 Days Follow-Up", "LTD Application Required",
                            "LTD Application Sent", "Employee Stat to GWL","Benefits Sheet Required","Day 160","Day 181 + 3 Months","Benefits Sheet Sent","Benefits Sheet Recieved","Accomodation Start Date",
                            "Return to Work","Return to Work Date","Return To Work Follow-Up","RTW Follow-Up Complete","Return To Work End Plan","Accomodation Follow-Up","Number of Days Absent","Hourly Salary",
                            "Hours Worked/Day","SL Cost/Day"}; // Consider replacing with reference
                        for (int i = 0; i < 26 ; i++)
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
                Debug.WriteLine(ex.Message); //Should eventually produce a pop-up with retry option
                return false;
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
    
        public DataEntry()
        {
            // Constructor adding all fields to their respective dictionary 
            // Consider replacing with reference
            RTWFields.Add("ID",null);
            RTWFields.Add("Employee Number", null);
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
}
