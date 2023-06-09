Feature: Task feature

As a user I want to edit and delete a task from a project

@task @positive @regression
Scenario: Edit a task created in a project
	Given I navigate to the page "todo.ly"
	And I login using my credentials
	When I click on "My project edited" project
	And I enter the name "new task" in task list 
	And I click on "Add" task button
	Then I see the task "new task" created
	And I edit the "new task" created
	And I click on SAVE button
	Then I see the edited "task edited" task name
	
@task @positive @regression
Scenario: Delete a task from a project
	Given I navigate to the page "todo.ly"
	And I login using my credentials
	When I click on "My project edited" project
	And I enter the name "new task" in task list 
	And I click on "Add" task button
    And I click on the task "new task" 
	And I click on Option menu of "new task"
	And I click on Delete button
	Then I see the info message is displayed
	And I see the "new task" is deleted
	
