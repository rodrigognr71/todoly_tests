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
        public void WhenIEnterTheName(string project)
        {
            leftSite.projectNameTextBox.SetText(project);
        }

        [When(@"I click on ""([^""]*)"" button")]
        public void WhenIClickOnAddButton(string add)
        {
            leftSite.addButton.Click();
        }

        [Then(@"I see the project ""([^""]*)"" in the Projects list")]
        public void ThenISeeTheProjectInTheProjectsList(string project)
        {
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed(project),
                "ERROR!The project was not created.");
        }

        [Then(@"I click on Option button of ""([^""]*)""")]
        public void ThenIClickOnOptionButton(string project)
        {
            leftSite.ClickProjectName(project);
            leftSite.optionButton.Click();  
        }

        [Then(@"I click on Edit button")]
        public void ThenIClickOnEditButton()
        {
            leftSite.editButton.Click();
        }

        [Then(@"I edit the name of the project to ""([^""]*)""")]
        public void ThenIEditTheNameOfTheProjectTo(string projectNameEdited)
        {
            leftSite.projectNameEditedTexBox.SetText(projectNameEdited);
        }

        [Then(@"I click on SAVE project button")]
        public void ThenIClickOnSAVEProjectButton()
        {
            Thread.Sleep(500);
            leftSite.saveButton.Click();
        }
    }
}
