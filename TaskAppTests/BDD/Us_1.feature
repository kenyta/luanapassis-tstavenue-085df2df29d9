@CreateTask

Feature: User stories1 Create Task
  As a ToDo App user
  I should  be able to create a task
  So I can manage my tasks

@test
    Scenario: 01 See My Tasks link on the NavBar
      Given the user do the loggin in ToDo app
      When the user successfully logged in
      Then the user should see the menu My Tasks
 @test
    Scenario: 02 Validate user name logged
      Given the user do the loggin in ToDo app
      When user click in My Tasks link
      Then the user should see a message on the top part saying Hey Kenya, this is your todo list for today
 @test
    Scenario: 03 Add new task by hitting Enter
      Given the user do the loggin in ToDo app
      When user click in My Tasks link
      And write the task name
      And hitting ENTER
      Then the task should be on the list of created tasks
 @test
     Scenario: 04 Add new task clicking in Add
       Given the user do the loggin in ToDo app
       When user click in My Tasks link
       And write the task name
       And click on the buton Add
       Then the task should be on the list of created tasks
 @test
     Scenario: 05 Tasks must require at least three characters
       Given the user do the loggin in ToDo app
       When user click in My Tasks link
       And enter with a task less than three chars
       And click on the buton Add
       Then the task shouldn not be on the list of create tasks because it must have at least three characters
 @test
      Scenario: 06 Tasks can not have more than 250 characters
        Given the user do the loggin in ToDo app
        When user click in My Tasks link
        And enter with a task name with more than two hundred fifty chars
        And click on the buton Add
        Then the task shouldn not be on the list of create tasks because has more than two hundred fifty chars

 