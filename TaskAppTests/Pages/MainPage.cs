using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAppTests.Util;

namespace TaskAppTests.Pages
{
    public class MainPage : Driver
    {

        public MainPage() 
        {
            PageFactory.InitElements(Instance, this);
        }

        [FindsBy(How = How.ClassName, Using = "alert-info")]
        private IWebElement SignedSuccessfullyMessage { get; set; }


        [FindsBy(How = How.ClassName, Using = "alert-warning")]
        private IWebElement AlertWarning { get; set; }


        [FindsBy(How = How.PartialLinkText, Using = "My Tasks")]
        private IWebElement MyTasks { get; set; }


        [FindsBy(How = How.ClassName, Using = "panel-heading")]
        private IWebElement ToBeDone { get; set; }


        [FindsBy(How = How.ClassName, Using = "navbar navbar-default")]
        private IWebElement welcomeMessage { get; set; }


        [FindsBy(How = How.Id, Using = "new_task")]
        private IWebElement taskNameField { get; set; }


        [FindsBy(How = How.ClassName, Using = "glyphicon-plus")]
        private IWebElement AddTask { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div[2]/div/table/tbody/tr[1]/td[2]/a")]
        private IWebElement lastTask { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div[2]/div/table/tbody/tr[1]/td[4]/button")]
        private IWebElement ManageSubtasksButton { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/div[2]")]
        private IWebElement ModalDialog { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/div[1]/h3")]
        private IWebElement ModalIdTask { get; set; }

        
        [FindsBy(How = How.Id, Using = "edit_task")]
        private IWebElement ModalDescriptionTask { get; set; }

        [FindsBy(How = How.Id, Using = "new_sub_task")]
        private IWebElement ModalSubtaskName { get; set; }

        [FindsBy(How = How.Id, Using = "dueDate")]
        private IWebElement ModalDueDate { get; set; }

        [FindsBy(How = How.Id, Using = "add-subtask")]
        private IWebElement AddSubTask { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/div[2]/div[2]/table/tbody/tr/td[2]")]
        private IWebElement ModalSubtaskNameCreated { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/div[3]/button")]
        private IWebElement ModalClose { get; set; }


        Guid guid;

        public bool IsLoggedIn()
        {
            try
            {
                bool containsMessage = SignedSuccessfullyMessage.Text.Contains("Signed in successfully.");
                return containsMessage;
            }
            catch (NoSuchElementException)
            {
                try
                {
                    bool containsMessage = !AlertWarning.Text.Contains("Invalid email or password.");
                    return containsMessage;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public bool IsMyTasksActive()
        {
            try
            {
                MyTasks.Click();

                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsToBeDoneActive()
        {
            try
            {
                return ToBeDone.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool CheckWelcomeMessage()
        {
            try
            {
                bool containsMessage = welcomeMessage.Text.Contains("Hey Luana, this is your todo list for today:");
                return containsMessage;
            }
            catch (NoSuchElementException)
            {
                return false;
      
            }
        }

        public void CreatNewTask(string text)
        {

            taskNameField.SendKeys(text);
                       
        }
        public void CreatNewTaskMore252Char(string text)
        {

            taskNameField.SendKeys(text);
            taskNameField.SendKeys(text);
            taskNameField.SendKeys(text);
            taskNameField.SendKeys(text);
            taskNameField.SendKeys(text);
            taskNameField.SendKeys(text);
            taskNameField.SendKeys(text);


        }

        public void CreateUsinEnter()
        {

            taskNameField.SendKeys(Keys.Enter); 
        }

        public void CreatNewTaskWithButton()
        {

            AddTask.Click();

        }

        
        public string getLastTask()
        {

            return lastTask.Text;

        }

        public bool ManageSubtasksButtonActive()
        {

            try
            {
                return ManageSubtasksButton.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool ManageSubtakButtonContainsMessage()
        {
            try
            {
                bool containsMessage = ManageSubtasksButton.Text.Contains("Manage Subtasks");
                return containsMessage;
            }
            catch (NoSuchElementException)
            {
                return false;

            }
        }
        public bool ManageSubtakButtonContainsNumbers(int qnt)
        {
            try
            {
                bool containsMessage = ManageSubtasksButton.Text.Contains(Convert.ToString(qnt));
                return containsMessage;
            }
            catch (NoSuchElementException)
            {
                return false;

            }
        }

        public void ManageSubtaskClick()
        {
            ManageSubtasksButton.Click();
        }

        public bool ModalDialogIsActivate()
        {
            try
            {
                return ModalDialog.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string IdTaksModalDialogIsEditable()
        {
            
            return ModalIdTask.GetAttribute("type");

        }
        public string DescritptionTaskModalDialogIsEditable()
        {
            return ModalDescriptionTask.GetAttribute("type");


        }

        //***********************
        public bool subtaskDescriptionActive()
        {
            try
            {
                return ModalSubtaskName.Displayed;
                
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void FillDescriptionField(string description)
        {
            ModalSubtaskName.SendKeys(description);
        }

        //***************************
        public bool DueDateActive()
        {
            try
            {
                return ModalDueDate.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        public void FillDateField(string date)
        {
            ModalDueDate.Clear();
            ModalDueDate.SendKeys(date);
        }
        //***********************
        public void ClickAddSubTask()
        {
            AddSubTask.Click();
            wait(); wait(); wait(); wait(); wait(); wait(); wait(); wait(); wait();
        }


        public string GetLastSubTask()
        {

            return ModalSubtaskNameCreated.Text;

        }

        public void ModalClosePopup()
        {

            ModalClose.Click();

        }


        public void CleanDueDateField()
        {
            ModalDueDate.Clear();
        }

        public void EmptyDescriptionSubtaskName()
        {
            ModalSubtaskName.Clear();
        }
        

    }
}
