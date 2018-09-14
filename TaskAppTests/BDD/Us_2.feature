@createSubTask

Feature: User stories2 Create SubTask
  As a ToDo App user
  I should be able to create a subtask
  So I can break down my tasks in smaller pieces

  Scenario: 07 User should see a button labeled as 'Manage Substasks'
    Given the user do the loggin in ToDo app 
	And create a new task
    Then user should see a button labeled as Manage Subtasks

   Scenario: 08 Manage Subtasks popup should have the number of subtasks created for that tasks
    Given the user do the loggin in ToDo app 
	And create a new task
    Then user should see a button labeled as Manage Subtasks 
	And the number of subtasks created

	
	Scenario: 09 only field of description and id
    Given the user do the loggin in ToDo app 
	And create a new task
	And click on the button Manage Subtasks
	Then a popup is opened 
	And shoud have only field with the task ID and the task description


    Scenario: 10 Should be a form with the SubTask Description and due date
     Given the user do the loggin in ToDo app 
	 And create a new task
	 And click on the button Manage Subtasks
	 Then a popup is opened 
     And shoud have the subTask field
     And should have a due date
      
	  	 
	Scenario Outline: 11 The due date field should have MM/dd/yyyy format
       Given the user do the loggin in ToDo app 
	   And create a new task
	   And click on the button Manage Subtasks
	   Then a popup is opened 
       And write the subTask "<subtasksName>"
       And write the due date "<dueDateFormat>"
       And click in Add Subtask
	   Then subtask can not be created
	   And close popup
       Examples:
       |subtasksName             | dueDateFormat |
       |subtask invalid format 1 | 02/08/2017    |
       |subtask invalid format 2 | 2017/08/02    |
       |subtask invalid format 3 | 02/08/17      |
       |subtask invalid format 4 | august/02/2017|

        
    Scenario: 12 Due date field is rquired 
        Given the user do the loggin in ToDo app 
	    And create a new task
	    And click on the button Manage Subtasks
	    Then a popup is opened 
        And write the subTask name
        And write the due date empty
        And click in Add Subtask
		Then subtask can not be created
		And close popup
         
     Scenario: 13 Description field is rquired 
        Given the user do the loggin in ToDo app 
	    And create a new task
	    And click on the button Manage Subtasks
	    Then a popup is opened 
        And write the subTask name empty
        And write the due date 
        And click in Add Subtask
        Then subtask can not be created with empty description
		And close popup

    Scenario: 14 Subtasks that were addeed should be appended on the bottom part of the modal dialog
        Given the user do the loggin in ToDo app 
	    And create a new task
	    And click on the button Manage Subtasks
	    Then a popup is opened 
        And write the subTask name 
        And write the due date 
        And click in Add Subtask
        Then Subtasks that were addeed should be appended on the bottom part of the modal dialog
		And close popup

