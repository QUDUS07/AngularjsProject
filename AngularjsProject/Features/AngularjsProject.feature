Feature: AngularjsProject

As a user to benefit from this platform,
i have to register on the plafrom.

@tag1
Scenario: Validate Registration on Angularjs
	Given I navigate to the website
	And I click on the SignUp
	And I enter Username
	And I enter Email
	And I enter Password
	When I click on SignUp button 
	Then I should be able to register successfully 
