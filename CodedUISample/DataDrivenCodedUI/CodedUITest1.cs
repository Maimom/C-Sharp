using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;


namespace DataDrivenCodedUI
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        [TestMethod]
        [DeploymentItem(@"Assets\RegisterUsers.xlsx")]
        [DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xls)};dbq=|DataDirectory|\\RegisterUsers.xlsx;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "Users$", DataAccessMethod.Sequential)] 
        public void ValidateUsersRegistered()
        {
            var browserWindow = BrowserWindow.Launch(new Uri("http://localhost:26641/Account/LogOn"));
            AccountLogon logon = new AccountLogon(browserWindow);
            var user = TestContext.DataRow["User Name"].ToString();
            var password = TestContext.DataRow["Password"].ToString();
            Assert.IsTrue(
                         logon.LogonAsUser(user, password)
                         .IsUserLoggedOn(),"Expected to log on to the system for user '" + user + "'");
        }



        [TestMethod]
        [DeploymentItem(@"Assets\KeywordDriven.xlsx")]
        [DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xls)};dbq=|DataDirectory|\\KeywordDriven.xlsx;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "Driver$", DataAccessMethod.Sequential)]
        public void GenericKeywordDrivenTestMethod()
        {
            var scenario2Run = TestContext.DataRow["Scenario 2 Run"].ToString();
            var URL = TestContext.DataRow["URL"].ToString();
            
            BrowserWindow bw = BrowserWindow.Launch(new Uri(URL));
            bw.Maximized = true;

            var cmd = TestContext.DataConnection.CreateCommand();
                        cmd.CommandText = "select * from ["+ scenario2Run +"$]"; //+ sheetName+"$"
            var reader = cmd.ExecuteReader();
  
            while (reader.Read())
            {
                var control = reader.GetValue(0).ToString(); 
                var action = reader.GetValue(1).ToString(); 
                var value= reader.GetValue(2).ToString(); 

                Console.WriteLine("Control: {0}, action: {1}, Value {2}", control, action, value);
                ProcessScenarioStep(bw, control, action, value);
            }
        }

        private void ProcessScenarioStep(BrowserWindow browserWindow, string control, string action, string value)
        {
            var actionableControl = GetControlForAction(browserWindow, action, control);
            ExecuteAction(actionableControl, action, value);
        }

        private void ExecuteAction(HtmlControl actionableControl, string action, string value)
        {
            if (action == "Edit")
            {                
                HtmlEdit ctrl = actionableControl as HtmlEdit;
                ctrl.Text = value;
            }

            if (action == "Click")
            {
                // ensure we click in the middle of the control
                var top = actionableControl.Top;
                var left = actionableControl.Left;
                var width = actionableControl.Width;
                var clickPoint = actionableControl.GetClickablePoint();
                Console.Write("clickpoint : {0}, top:{1}, left:{2}, width:{3}", clickPoint, top, left, width);
                //actionableControl.DrawHighlight();
                Mouse.Click(actionableControl);
            }

        }

        private HtmlControl GetControlForAction(BrowserWindow browserWindow, string action, string controlName)
        {
            if (action == "Edit")
            {
                HtmlEdit element = new HtmlEdit(browserWindow);
                element.SearchProperties.Add(HtmlEdit.PropertyNames.Name, controlName);
                return element;
            }

            if(action == "Click")
            {
                HtmlControl element = new HtmlControl(browserWindow);
                element.SearchProperties.Add(HtmlInputButton.PropertyNames.FriendlyName, controlName, PropertyExpressionOperator.Contains);
                // now look if we found it, but ensure we have the 
                // inner most control that we can find with this search
                if (element.TryFind())
                {
                    var child = new HtmlControl(element);
                    child.SearchProperties.Add(HtmlInputButton.PropertyNames.FriendlyName, controlName, PropertyExpressionOperator.Contains);
                    if (child.TryFind())
                    {
                        return child;
                    }
                    else
                        return element;
                }
                Console.WriteLine("Unable to locate control for action:{0} and controlname:{1}", action, controlName);
                return element;
            }
            
            return null;
        }



        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
