using System;
using TechTalk.SpecFlow;

using TaskAppTests.Util;
using TaskAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TaskAppTests
{
    [Binding]
    public class UserStories2CreateSubTaskSteps
    {
        public string subTaskName;
        public string taskName = DateTime.Now+" "+Guid.NewGuid().ToString();

        
        [Given(@"create a new task")]
        public void GivenCreateANewTask()
        {
            MainPage mainPage = new MainPage();
            mainPage.IsMyTasksActive();
            mainPage.CreatNewTask(taskName);
            mainPage.CreateUsinEnter();
            var tskname = mainPage.getLastTask();
            Assert.AreEqual(tskname, taskName, "The task wasn't created");
        }
        
        [Given(@"click on the button Manage Subtasks")]
        public void GivenClickOnTheButtonManageSubtasks()
        {
            MainPage mainPage = new MainPage();
            mainPage.ManageSubtaskClick();
        }
        
        [Then(@"user should see a button labeled as Manage Subtasks")]
        public void ThenUserShouldSeeAButtonLabeledAsManageSubtasks()
        {
            MainPage mainPage = new MainPage();
            Assert.IsTrue(mainPage.ManageSubtasksButtonActive(), "The button Manage Subtask is not visible");
            Assert.IsTrue(mainPage.ManageSubtakButtonContainsMessage(), "The button's label is wrong"); 
        }
        
        [Then(@"the number of subtasks created")]
        public void ThenTheNumberOfSubtasksCreated()
        {
            MainPage mainPage = new MainPage();
            int qnt = 0;
            Assert.IsTrue(mainPage.ManageSubtakButtonContainsNumbers(qnt), "The subtask quantity is wrong ");
        }
        
        [Then(@"a popup is opened")]
        public void ThenAPopupIsOpened()
        {
            MainPage mainPage = new MainPage();
            Assert.IsTrue(mainPage.ModalDialogIsActivate(), "There is no modal dialog opened");
            
        }
        
        [Then(@"shoud have only field with the task ID and the task description")]
        public void ThenShoudHaveOnlyFieldWithTheTaskIDAndTheTaskDescription()
        {   
            MainPage mainPage = new MainPage();
            Assert.AreNotEqual(mainPage.IdTaksModalDialogIsEditable(), "textarea", "The field id subtask is editable");
            Assert.AreNotEqual(mainPage.DescritptionTaskModalDialogIsEditable(), "textarea", "The field description subtask is editable");
        }

        [Then(@"shoud have the subTask field")]
        public void ThenShoudHaveTheSubTaskField()
        {
            MainPage mainPage = new MainPage();
            Assert.IsTrue(mainPage.subtaskDescriptionActive(), "There is no subtask description active");
        }


        [Then(@"should have a due date")]
        public void ThenShouldHaveADueDate()
        {
            MainPage mainPage = new MainPage();
            Assert.IsTrue(mainPage.DueDateActive(), "There is no due date active");
        }

        [Then(@"write the subTask ""(.*)""")]
        public void ThenWriteTheSubTask(string p0)
        {
            MainPage mainPage = new MainPage();
            mainPage.FillDescriptionField(p0);
            subTaskName = p0;
        }
        
        [Then(@"write the due date ""(.*)""")]
        public void ThenWriteTheDueDate(string p0)
        {
            MainPage mainPage = new MainPage();
            mainPage.FillDateField(p0);

        }
        
        [Then(@"click in Add Subtask")]
        public void ThenClickInAddSubtask()
        {
            MainPage mainPage = new MainPage();
            mainPage.ClickAddSubTask();
            
        }
        
        [Then(@"subtask can not be created")]
        public void ThenSubtaskCanNotBeCreated()
        {
            MainPage mainPage = new MainPage();
            var tskname = mainPage.GetLastSubTask();
            Assert.AreNotEqual(tskname, subTaskName, "The SubTaks was created with wrong format date");
        }

        [Then(@"subtask can not be created with empty description")]
        public void ThenSubtaskCanNotBeCreatedWithEmptyDescription()
        {

            MainPage mainPage = new MainPage();
            var tskname = mainPage.GetLastSubTask();
            if (tskname == "empty")
                tskname = tskname.Replace("empty", "-");
            Assert.AreNotEqual(tskname, "-", "The SubTaks was created with empty description");
        }


        [Then(@"write the subTask name")]
        public void ThenWriteTheSubTaskName()
        {
            MainPage mainPage = new MainPage();
            mainPage.FillDescriptionField("Subtask Name 1");
            subTaskName = "Subtask Name 1";

        }
        
        [Then(@"write the due date empty")]
        public void ThenWriteTheDueDateEmpty()
        {
            MainPage mainPage = new MainPage();
            mainPage.CleanDueDateField();
        }
        

        
        [Then(@"write the subTask name empty")]
        public void ThenWriteTheSubTaskNameEmpty()
        {
            MainPage mainPage = new MainPage();
            mainPage.EmptyDescriptionSubtaskName();
        }
        
        [Then(@"write the due date")]
        public void ThenWriteTheDueDate()
        {
            MainPage mainPage = new MainPage();
            mainPage.FillDateField("31/12/2018");
        }
        
       
        [Then(@"Subtasks that were addeed should be appended on the bottom part of the modal dialog")]
        public void ThenSubtasksThatWereAddeedShouldBeAppendedOnTheBottomPartOfTheModalDialog()
        {
            MainPage mainPage = new MainPage();
            var tskname = mainPage.GetLastSubTask();
            Assert.AreEqual(tskname, subTaskName, "The SubTaks was not created");
        }

        [Then(@"close popup")]
        public void ThenClosePopup()
        {

            MainPage mainPage = new MainPage();
            mainPage.ModalClosePopup();
        }


    }
}
