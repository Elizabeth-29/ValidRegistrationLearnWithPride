Feature: RegistrationForm

A short summary of the feature

@tag1
Scenario: Registration Form
	Given a user navigates to the website
	And user enters First name
	And user enters Last name
	And user enters Address
	And user enters Email address
	And user enters Phone number
	And user enters First name
	And user ticks Gender
	And user ticks Hobbies
	And user selects Language
	And user selects Skills
	And user selects Country
	And user selects Year of birth
	And user selects Month of birth
	And user selects Day of birth
	And user enters Password
	And user enters Confirm Password
	When user clicks the Submit button
	Then user is registered successfully

