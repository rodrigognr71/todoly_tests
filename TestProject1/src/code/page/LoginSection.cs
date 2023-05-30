using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.src.code.control;

namespace TestProject1.src.code.page
{
    public class LoginSection
    {
        public TextBox emailTextBox = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail"));
        public TextBox pwdTextBox = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword"));
        public Button loginButton = new Button(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin"));

        public void Login(String user, String pwd)
        {
            emailTextBox.SetText(user);
            pwdTextBox.SetText(pwd);
            loginButton.Click();
        }
    }
}
