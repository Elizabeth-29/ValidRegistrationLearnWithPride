Feature: DataDrivenWithParameter

A short summary of the feature

@tag1
Scenario: ValidRegistration
	Given a user launches the website "https://angularjs.realworld.io/#/"
	And clicks on Signup
	And enters username "Bambo"
	And enters email "bambo@yahoo.com"
	And enters password "yinus"
	When user clicks Sign up button
	Then user should be registered successfully
