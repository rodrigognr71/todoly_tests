using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.src.code.control;

namespace TestProject1.src.code.page
{
    public class TaskSection
    {
        public TextBox taskNameTextBox = new TextBox(By.Id("NewItemContentInput"));
        public Button addTaskButton = new Button(By.Id("NewItemAddButton"));
        public TextBox editTaskTextBox = new TextBox(By.XPath("//textarea[@id='ItemEditTextbox']"));
        public Button editButton = new Button(By.ClassName("edit"));
        public Button saveEditedTaskName = new Button(By.XPath("//div[@id='ItemEditDiv']//*[@id=\"ItemEditSubmit\"]"));

        public bool TaskNameIsDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("//td[@class=\"ItemContent\"]//div[text()='" + nameValue +"']"));
            return nameProject.IsControlDisplayed();
        }

        public void ClickTaskName(String nameValue)
        {
            TextBox nameProject = new TextBox(By.XPath("//td[@class=\"ItemContent\"]//div[text()='" + nameValue + "']"));
            nameProject.Click();
        }
    }
}
