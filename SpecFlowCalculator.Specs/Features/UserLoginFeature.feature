Feature: UserLoginFeature

@user
Scenario: Login for user portal
Given I have opened the application
And I login to application
Then I see user portal

Scenario: Login for user portability
Given I have opened the application
And I login to application as admin
Then I see last date logged in data  is 5 days from current date
And I see the menus like
| Menu_1 | Menu_2   | Menu_3 | Menu_4   |
| Login  | Settings | Logout | Advenced |