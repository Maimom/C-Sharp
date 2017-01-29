using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;






namespace Automation.White
{
    public partial class Automation : Form
    {
        public Automation()
        {
            InitializeComponent();
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
      
            TestStack.White.Application application = TestStack.White.Application.Launch(@"A:\Github\C-Sharp\WinFormExample\TaskListApp\TaskListApp\bin\Debug\TaskListApp.exe");

            Window window = application.GetWindow("Task List");

            var taskDescription = window.Get<TestStack.White.UIItems.TextBox>(SearchCriteria.ByAutomationId("txtTaskDescription"));

            taskDescription.SetValue("Hello World");
            
            var startDate = window.Get<TestStack.White.UIItems.DateTimePicker>(SearchCriteria.ByAutomationId("dtpStartDate"));
            var sdate = Convert.ToDateTime("12/12/2016");                
            window.WaitWhileBusy();
            startDate.SetDate(sdate, DateFormat.DayMonthYear);
            window.WaitWhileBusy();

            var endDate = window.Get<TestStack.White.UIItems.DateTimePicker>(SearchCriteria.ByAutomationId("dtpEndDate"));
            var edate = Convert.ToDateTime("01/01/2017");
            window.WaitWhileBusy();
            endDate.SetDate(edate, DateFormat.DayMonthYear);
            window.WaitWhileBusy();

            var personal = window.Get <TestStack.White.UIItems.CheckBox> (SearchCriteria.ByAutomationId("chkPersonal"));
            personal.SetValue(true);

            var saveButton = window.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByAutomationId("btnSave"));
            saveButton.Click(); 
 
           



            
            
        }

        private void Automation_Load(object sender, EventArgs e)
        {

        }
    }
}
