using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestProject1.src.code.page;

namespace TestProject1.src.StepsDefinitions
{
    [Binding]
    public class ProjectStepDefinitions
    {
        LoginSection loginSection = new LoginSection();
        MainPage mainPage = new MainPage();
        LeftSite leftSite = new LeftSite();
   

        [Given(@"I navigate to the page ""([^""]*)""")]
        public void GivenINavigateToThePage(string p0)
        {
           
        }

        [Given(@"I login using my credentials")]
        public void GivenIEnterMyCredentials()
        {
            mainPage.loginButton.Click();
            loginSection.Login("bootcamp2@mojix.com", "12345");
        }

        [When(@"I click on ""([^""]*)"" button in Project menu")]
        public void WhenIClickOnButtonInProjectMenu(string p0)
        {
            leftSite.addNewProjectButton.Click();
        }

        [When(@"I enter the name ""([^""]*)""")]
        public void WhenIEnterTheName(string p0)
        {
            leftSite.projectNameTextBox.SetText("REtest");
        }

        [When(@"I click on ""([^""]*)"" button")]
        public void WhenIClickOnAddButton(string add)
        {
            leftSite.addButton.Click();
        }

        [Then(@"I see the project ""([^""]*)"" in the Projects list")]
        public void ThenISeeTheProjectInTheProjectsList(string p0)
        {
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("REtest"),
                "ERROR!The project was not created. The issue is already reported [ID-5]");
        }

    }
}
