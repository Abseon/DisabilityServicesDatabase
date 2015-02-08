using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabilityServiceDatabase
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void ReferralRecievedLabel_Click(object sender, EventArgs e)
        {

        }

    }
    public class DataEntry
    {
        // Class representing the data contained in a single entry either created by the application or read from the database
        // Note: This is not a single person's account but rather a single disability account
        
        //RTW Information
        public int ID;
        public int EmployeeNumber;
        public String Status;
        public Boolean LTDEligible;
        public DateTime ReferralReceived;
        public DateTime SickLeaveStart;
        public DateTime SickLeaveExpiry;
        public DateTime n180FollowUp;
        public DateTime n180Sent;
        public DateTime LTDApplicationRequired;
        public DateTime LTDApplicationSent;
        public DateTime EmployeeStatToGWL;
        public DateTime BenefitsSheetRequired;
        public DateTime Day160;
        public DateTime Day181Plus3Months;
        public DateTime BenefitsSheetSent;
        public DateTime BenefitsSheetRecieved;
        public DateTime AccommodationStartDate;
        public String ReturnToWork;
        public DateTime ReturnToWorkDate;
        public DateTime ReturnToWorkFollowUp;
        public DateTime RTWFollowUpComplete;
        public DateTime ReturnToWorkEndPlan;
        public DateTime AccomadationFollowUp;
        public DateTime NumberOfDaysAbsent;
        public int HourlySalary;
        public int DailyHoursWorked;
        public int SLCostPerDay;

        //Personal Info
        public String LastName;
        public String FirstName;
        public String StreetAddress;
        public String City;
        public String Province;
        public String PostalCode;
        public String HomeNumber;
        public String WorkNumber;
        public String Email;


    }
}
