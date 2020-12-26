Feature: StepDefinition
Testing the multiline step resusabulity

Scenario: Enter user details in userform

Given I login to application
| UserName | Password |
| admin    | admin    |
And I enter following details
| Title | Intial | Firtsname |
| Mr.   | K      | Kartin    |