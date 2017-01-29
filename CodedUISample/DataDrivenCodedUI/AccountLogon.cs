using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataDrivenCodedUI
{
    class AccountLogon
    {
        private BrowserWindow _browserWindow;

        public AccountLogon(BrowserWindow browserWindow)
        {
            // TODO: Complete member initialization
            _browserWindow = browserWindow;
        }

        public AccountLogon LogonAsUser(string user, string password)
        {
            EnterUserName(user);
            EnterPassword(password);
            ClickLogin();
            return this;
        }

        private void ClickLogin()
        {
            HtmlInputButton button = new HtmlInputButton(_browserWindow);
            button.SearchProperties.Add(HtmlInputButton.PropertyNames.ValueAttribute, "Log On");
            Mouse.Click(button);
        }

        private void EnterPassword(string password)
        {
            HtmlEdit pwd = new HtmlEdit(_browserWindow);
            pwd.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "Password");
            pwd.Text = password;
        }

        private void EnterUserName(string user)
        {
            HtmlEdit userName = new HtmlEdit(_browserWindow);
            userName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "UserName");
            userName.Text = user;
        }

        public bool IsUserLoggedOn()
        {
            // find the text "Address And Payment" on the screen and we know we logged on succesfull
            // or find the text "Login was unsuccessful" on the screen, either would work
            HtmlSpan errorMessage = new HtmlSpan(_browserWindow);
            errorMessage.SearchProperties.Add(HtmlSpan.PropertyNames.InnerText, "Login was unsuccessful", PropertyExpressionOperator.Contains);
            return !errorMessage.TryFind();
        }

        
    }
}
