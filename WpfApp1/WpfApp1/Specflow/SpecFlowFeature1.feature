﻿
Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given i start exe
	Given I have entered 50 into the calculator	
	When I press add	
	Then the result should be 50 on the screen
