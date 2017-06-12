Feature: Status Code
	As a user
	I want to get the status code
	So that I know what the response code is

Scenario: Verify Status Code
	Given Google is running
	Then I should get a "200" response code
