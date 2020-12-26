Feature: ExcelFeature


@add
Scenario Outline: Add two numbers
	Given the first number is <Num1>
	And the second number is <Num2>
	When the two numbers are added
	Then the result should be <Result>

@source:data.xlsx
Examples: 
| Num1 | Num2 | Result |

