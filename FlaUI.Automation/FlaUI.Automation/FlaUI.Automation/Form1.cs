using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FlaUI.UIA2;
using FlaUI.Automation;
using FlaUI.Core.WindowsAPI;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Tools;
using FlaUI.Core.Definitions;
using FlaUI.Core.Conditions;
using FlaUI.UIA3;
using FlaUI.UIA2.Patterns;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.AutomationElements.PatternElements;
using FlaUI.Core.Patterns.Infrastructure;



namespace FlaUI.Automation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var app = FlaUI.Core.Application.Launch("TaskListApp.exe");
            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);

                //var txtDesc = window.FindFirst(TreeScope.Descendants, window.ConditionFactory.ByAutomationId("txtTaskDescription"));

               // PropertyCondition xEllist3 = new PropertyCondition(("txtTaskDescription"), "CustomHeaderClass", PropertyConditionFlags.IgnoreCase);

                //var txtDesc = window.FindFirst(TreeScope.Children, new PropertyCondition(ControlType.Text));



                var txtDesc = window.FindFirst(TreeScope.Descendants, window.ConditionFactory.ByAutomationId("txtTaskDescription")).AsTextBox();

                txtDesc.Text = "Hello world";

                //var menu = window.FindFirst(TreeScope.Descendants, window.ConditionFactory.ByAutomationId("menuone")).AsMenu();

                var btn = window.FindFirst(TreeScope.Descendants, window.ConditionFactory.ByAutomationId("btnSave"));

                btn.Click();

                //FlaUI.Core.AutomationElements.Infrastructure.AutomationElement menuElement = window.FindFirst(TreeScope.Descendants, new PropertyCondition(FlaUI.Core.AutomationElements.Infrastructure.AutomationElement., menuName)); 
                

                
            }
        }
    }
}

