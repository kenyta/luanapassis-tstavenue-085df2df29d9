using System;
using TechTalk.SpecFlow;
using TaskAppTests.Util;
using TaskAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TaskAppTests.Tests
{
    [Binding]
    public class UserStories1CreateTaskSteps : Start
    {
        string username = "kenyta2@gmail.com";
        string password = "12345678";
        public string taskName = DateTime.Now + " " + Guid.NewGuid().ToString();
        public string taskName2Chars = Guid.NewGuid().ToString().Substring(0, 2);
        public string taskNameBeforeSubmit;


        [Given(@"the user do the loggin in ToDo app")]
        public void GivenTheUserDoTheLogginInToDoApp()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Submit(username, password);
        }
        
        [When(@"the user successfully logged in")]
        public void WhenTheUserSuccessfullyLoggedIn()
        {
            MainPage mainPage = new MainPage();
            Assert.IsTrue(mainPage.IsLoggedIn(), "User cannot login with valid credentiais.");
        }

        [Then(@"the user should see the menu My Tasks")]
        public void ThenTheUserShouldSeeTheMenuMyTasks()
        {
            MainPage mainPage = new MainPage();
            mainPage.IsMyTasksActive();
            Assert.IsTrue(mainPage.IsToBeDoneActive(), "The Task List is not visible");
        }

        [When(@"user click in My Tasks link")]
        public void WhenUserClickInMyTasksLink()
        {
            MainPage mainPage = new MainPage();
            mainPage.IsMyTasksActive();
        }

        [Then(@"the user should see a message on the top part saying Hey Kenya, this is your todo list for today")]
        public void ThenTheUserShouldSeeAMessageOnTheTopPartSayingHeyKenyaThisIsYourTodoListForToday()
        {
            MainPage mainPage = new MainPage();
            Assert.IsTrue(mainPage.CheckWelcomeMessage(), "Wrong messager");
        }

        [When(@"write the task name")]
        public void WhenWriteTheTaskName()
        {
            MainPage mainPage = new MainPage();
            mainPage.CreatNewTask(taskName);

        }

        [When(@"hitting ENTER")]
        public void WhenHittingENTER()
        {
            MainPage mainPage = new MainPage();
            mainPage.CreateUsinEnter();
        }

        [Then(@"the task should be on the list of created tasks")]
        public void ThenTheTaskShouldBeOnTheListOfCreatedTasks()
        {
            MainPage mainPage = new MainPage();
            var tskname = mainPage.getLastTask();
            Assert.AreEqual(tskname, taskName, "The task wasn't created");

        }

        [When(@"click on the buton Add")]
        public void WhenClickOnTheButonAdd()
        {
            MainPage mainPage = new MainPage();
            mainPage.CreatNewTaskWithButton();
        }

        [Then(@"the task shouldn not be on the list of create tasks because it must have at least three characters")]
        public void ThenTheTaskShouldnNotBeOnTheListOfCreateTasksBecauseItMustHaveAtLeastThreeCharacters()
        {
            MainPage mainPage = new MainPage();
            var tskname = mainPage.getLastTask();
            Assert.AreNotEqual(tskname, taskName2Chars, "The task was created with less than 3 chars");
        }

        [When(@"enter with a task less than three chars")]
        public void WhenEnterWithATaskLessThanThreeChars()
        {
            MainPage mainPage = new MainPage();
            mainPage.CreatNewTask(taskName2Chars);

        }

        [Then(@"the task shouldn not be on the list of create tasks because has more than two hundred fifty chars")]
        public void ThenTheTaskShouldnNotBeOnTheListOfCreateTasksBecauseHasMoreThanCharacters()
        {
            MainPage mainPage = new MainPage();
            var tskName = mainPage.getLastTask();
            Boolean auxiliar;
            if (tskName.Length > 250)
                auxiliar = false;
            else
                auxiliar = true;
            Assert.IsTrue(auxiliar, "The task was created with more than 250 chars");
        }

        [When(@"enter with a task name with more than two hundred fifty chars")]
        public void WhenEnterWithATaskNameWithMoreThanTwoHundredFiftyChars()
        {
            MainPage mainPage = new MainPage();
            mainPage.CreatNewTaskMore252Char(taskName);
        }



    }
}
