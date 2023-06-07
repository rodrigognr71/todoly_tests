Feature: Create a project feature

Create a new project in todo.ly

@createProject
Scenario: Create a project in todo.ly
	Given I navigate to the page "todo.ly"
	And I login using my credentials
	When I click on "Add New Project" button in Project menu
	And I enter the name "My project"
	And I click on "Add" button
	Then I see the project "My project" in the Projects list

Scenario: Update a project in todo.ly
	Given I navigate to the page "todo.ly"
	And I login using my credentials
	Then I see the project "My project" in the Projects list
	And I click on Option button of "My project"
	And I click on Edit button
	And I edit the name of the project to "My project edited"
	And I click on SAVE project button
	Then I see the project "My project edited" in the Projects list
