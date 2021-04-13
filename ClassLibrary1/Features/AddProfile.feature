Feature: Add profile Feature

@products

Scenario: Add profile feature-edit description
	Given I have logged in 
		| name   | password |
		| dongshaohui31@gmail.com | Test123! |
	When I edit my description
	Then I can see the pop up notification with Description has been saved successfully 


Scenario: Add profile feature-add new language
	Given I have logged in
		| name   | password |
		| dongshaohui31@gmail.com | Test123! |
	When I add new language
	Then I can see the pop up notification with <language> has been added to your languages


Scenario: Add profile feature - add availibility 
	Given I have logged in
		| name   | password |
		| dongshaohui31@gmail.com | Test123! |
	When I add new availinility
	Then I can see the pop up notification with Availability updated
