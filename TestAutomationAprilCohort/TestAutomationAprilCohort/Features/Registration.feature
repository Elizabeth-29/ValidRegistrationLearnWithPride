Feature: Registration

A short summary of the feature

@tag1
Scenario: ValidRegistration
	Given a user launches the website
	And clicks on Signup
	And enters username
	And enters email
	And enters password
	When user clicks Sign up button
	Then user should be registered successfully

