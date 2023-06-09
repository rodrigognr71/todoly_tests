using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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
    public class TaskStepDefinitions
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();
        TaskSection taskSection = new TaskSection();

        [When(@"I click on ""([^""]*)"" project")]
        public void WhenIClickOnProject(string project)
        {
            leftSite.ClickProjectName(project);
        }

        [When(@"I enter the name ""([^""]*)"" in task list")]
        public void WhenIEnterTheNameInTaskList(string p0)
        {
            taskSection.taskNameTextBox.Click();
            taskSection.taskNameTextBox.SetText(p0);          
        }

        [When(@"I click on ""([^""]*)"" task button")]
        public void WhenIClickOnTaskButton(string add)
        {
            taskSection.addTaskButton.Click();
        }
        
        [Then(@"I see the task ""([^""]*)"" created")]
        public void WhenISeeTheTaskCreated(string task)
        {
            Assert.IsTrue(taskSection.TaskNameIsDisplayed(task), "ERROR!The task was not created");
            Thread.Sleep(1000);
        }

        [Then(@"I edit the ""([^""]*)"" created")]
        public void WhenIClickOnTheTaskCreated(string task)
        {
            taskSection.ClickTaskName(task);
            Thread.Sleep(1000);
            taskSection.editTaskTextBox.SetText(task + "EDITED");
        }

        [When(@"I click on the task ""([^""]*)""")]
        public void WhenIClickOnTheTask(string task)
        {
            taskSection.ClickTaskName(task);
        }

        [Then(@"I click on SAVE button")]
        public void WhenIClickOnSAVEButton()
        {
            taskSection.saveEditedTaskName.Click();
        }

        [When(@"I click on Option menu of ""([^""]*)""")]
        public void WhenIClickOnOptionMenuOf(string task)
        {
            taskSection.optionTaskButton.Click();
        }

        [When(@"I click on Delete button")]
        public void WhenIClickOnDeleteButton()
        {
            taskSection.deleteTaskButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"I see the ""([^""]*)"" is deleted")]
        public void ThenISeeTheTaskIsDeleted(string task)
        {
            Assert.IsFalse(taskSection.TaskNameIsDisplayed(task),
               "ERROR!The task was not deleted.");
        }


        [Then(@"I see the edited ""([^""]*)"" task name")]
        public void ThenISeeTheEditedTaskName(string newName)
        {
            Assert.IsTrue(taskSection.TaskNameIsDisplayed(newName),
                "ERROR!The task was not edited. The issue is already reported in my final task of the Manual QA module [ID-5]");
        }

        [Then(@"I see the info message is displayed")]
        public void ThenISeeTheInfoMessageIsDisplayed()
        {
            Assert.IsTrue(taskSection.InfoMessageDisplayed(),"the info message is not displayed");
        }
    }
}
