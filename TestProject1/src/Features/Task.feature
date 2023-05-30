Feature: Task feature

As a user I want to edit, move and delete a task from a project

@task
Scenario: Edit a task created in a project
	Given I navigate to the page "todo.ly"
	And I login using my credentials
	When I click on the project
	And I enter the name "new task" in task list 
	And I click on "Add" task button
	And I see the task "new task" created
	And I click on the task "new task" created
	And I click on SAVE button
	Then I see the edited "task edited" task name
