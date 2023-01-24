Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 5
	When the two numbers are added
	Given the second number is 7
	Then the result should be 12

Scenario: Multiply two numbers
	Given the first number is 5
	When the two numbers are multiplied
	Given the second number is 7
	Then the result should be 35

Scenario: Reduce
	Given the first number is 5
	When the number is reduced
	Given the second number is 7
	Then the result should be -2

Scenario: Divide
	Given the first number is 7
	When the number is divided
	Given the second number is 5
	Then the result should be 1.4