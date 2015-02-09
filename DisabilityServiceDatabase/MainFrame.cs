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

        public MainFrame()
        {
            InitializeComponent();
            Debug.WriteLine(DatabaseRead("Employee").ToString());
            Debug.WriteLine(DatabaseRead("Case").ToString());
            Debug.WriteLine("END");
        }

        private void ReferralRecievedLabel_Click(object sender, EventArgs e)
        {

        }
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
                // DB Access Here vvv
                // To be added
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
        // Note: This is not a single person's account but rather a single disability account
        
        //RTW Information
        public Dictionary<string, object> RTWFields = new Dictionary<string, object>();
        //Personal Info
        public Dictionary<string, object> PersonalFields = new Dictionary<string, object>();
        // Booleans indicating the information in the field defaulted to false
        public Boolean ContainsCaseInfo = false;
        public Boolean ContainsPersonalInfo = false;
    
        public DataEntry()
        {
            // Constructor adding all fields to their respective dictionary
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
            RTWFields.Add("Days Worked/Day", null);
            RTWFields.Add("SL Cost/Day", null);

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
