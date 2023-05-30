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

        [When(@"I click on the project")]
        public void WhenIClickOnTheProject()
        {
            leftSite.ClickProjectName("REtest");
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

        [When(@"I see the task ""([^""]*)"" created")]
        public void WhenISeeTheTaskCreated(string task)
        {
            Assert.IsTrue(taskSection.TaskNameIsDisplayed(task), "ERROR!The task was not created");
            Thread.Sleep(1000);
        }

        [When(@"I click on the task ""([^""]*)"" created")]
        public void WhenIClickOnTheTaskCreated(string task)
        {
            taskSection.ClickTaskName(task);
            Thread.Sleep(1000);
            taskSection.editTaskTextBox.SetText(task + "EDITED");
        }

        [When(@"I click on SAVE button")]
        public void WhenIClickOnSAVEButton()
        {
            taskSection.saveEditedTaskName.Click();
        }

        [Then(@"I see the edited ""([^""]*)"" task name")]
        public void ThenISeeTheEditedTaskName(string newName)
        {
            Assert.IsTrue(taskSection.TaskNameIsDisplayed(newName), 
                "ERROR!The task was not edited. The issue is already reported [ID-5]");
        }
    }
}
