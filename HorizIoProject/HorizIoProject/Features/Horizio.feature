Feature: Horizio

@mytag
Scenario: modal appears
	Given a user not logged in
	And on the homepage
	When I click on Call on the genie 
	Then a modal appears and asks me to make a choice between Make a profitable investment or Manage the rental of your property.