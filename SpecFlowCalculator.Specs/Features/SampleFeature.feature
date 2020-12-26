Feature: SampleFeature

Scenario: Create a new employees

When I fill all the  mandatory details form
| Name   | Age | Phone      | Email                   |
| Himmer | 38  | 0662758021 | jean.f.himmer@gmail.com |
| Barbe | 42  | 0628000132 | elosivi@yahoo.fr |

Scenario Outline: Create a new employees for differente iteration

When I fill all the  mandatory  details form <Name>, <Age> and <Phone> 

Examples: 
| Name   | Age | Phone      |
| Himmer | 38  | 0662758021 |
| Barbe | 42  | 0628000132  | 

Scenario: Check if i could get the details entered via table from extended steps
When I fill all the  mandatory details form
| Name   | Age | Phone      | Email          |
| Himmer | 38  | 0662758021 | toto@gmail.com |
Then I should  get the same value from extended steps