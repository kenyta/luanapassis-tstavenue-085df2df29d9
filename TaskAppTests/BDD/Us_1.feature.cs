﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TaskAppTests.BDD
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("User stories1 Create Task")]
    [NUnit.Framework.CategoryAttribute("CreateTask")]
    public partial class UserStories1CreateTaskFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Us_1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "User stories1 Create Task", "  As a ToDo App user\r\n  I should  be able to create a task\r\n  So I can manage my " +
                    "tasks", ProgrammingLanguage.CSharp, new string[] {
                        "CreateTask"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 See My Tasks link on the NavBar")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void _01SeeMyTasksLinkOnTheNavBar()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 See My Tasks link on the NavBar", new string[] {
                        "test"});
#line 9
    this.ScenarioSetup(scenarioInfo);
#line 10
      testRunner.Given("the user do the loggin in ToDo app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
      testRunner.When("the user successfully logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
      testRunner.Then("the user should see the menu My Tasks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02 Validate user name logged")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void _02ValidateUserNameLogged()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 Validate user name logged", new string[] {
                        "test"});
#line 14
    this.ScenarioSetup(scenarioInfo);
#line 15
      testRunner.Given("the user do the loggin in ToDo app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
      testRunner.When("user click in My Tasks link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
      testRunner.Then("the user should see a message on the top part saying Hey Kenya, this is your todo" +
                    " list for today", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03 Add new task by hitting Enter")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void _03AddNewTaskByHittingEnter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03 Add new task by hitting Enter", new string[] {
                        "test"});
#line 19
    this.ScenarioSetup(scenarioInfo);
#line 20
      testRunner.Given("the user do the loggin in ToDo app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
      testRunner.When("user click in My Tasks link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
      testRunner.And("write the task name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
      testRunner.And("hitting ENTER", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
      testRunner.Then("the task should be on the list of created tasks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("04 Add new task clicking in Add")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void _04AddNewTaskClickingInAdd()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04 Add new task clicking in Add", new string[] {
                        "test"});
#line 26
     this.ScenarioSetup(scenarioInfo);
#line 27
       testRunner.Given("the user do the loggin in ToDo app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
       testRunner.When("user click in My Tasks link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
       testRunner.And("write the task name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
       testRunner.And("click on the buton Add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
       testRunner.Then("the task should be on the list of created tasks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("05 Tasks must require at least three characters")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void _05TasksMustRequireAtLeastThreeCharacters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05 Tasks must require at least three characters", new string[] {
                        "test"});
#line 33
     this.ScenarioSetup(scenarioInfo);
#line 34
       testRunner.Given("the user do the loggin in ToDo app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
       testRunner.When("user click in My Tasks link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
       testRunner.And("enter with a task less than three chars", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
       testRunner.And("click on the buton Add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
       testRunner.Then("the task shouldn not be on the list of create tasks because it must have at least" +
                    " three characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("06 Tasks can not have more than 250 characters")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void _06TasksCanNotHaveMoreThan250Characters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06 Tasks can not have more than 250 characters", new string[] {
                        "test"});
#line 40
      this.ScenarioSetup(scenarioInfo);
#line 41
        testRunner.Given("the user do the loggin in ToDo app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
        testRunner.When("user click in My Tasks link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
        testRunner.And("enter with a task name with more than two hundred fifty chars", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
        testRunner.And("click on the buton Add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
        testRunner.Then("the task shouldn not be on the list of create tasks because has more than two hun" +
                    "dred fifty chars", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
