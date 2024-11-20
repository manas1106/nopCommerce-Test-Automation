Feature: MyAccount

Background: 
	Given Browser is open and User is on nopCommerce landing page

Scenario: Verify user is able to navigate to My Account page
	When User clicks on login button
	Then Login page should open
	When User Enter email as "a@a.com" and password as "123456"
	And Clicks on Login button
	Then User should be redirected to home page
	When User Clicks on MyAccount link 
	Then Then User should be redirected to MyAccount Page 

Scenario: Verify user should be able to update the company name 
	When User clicks on login button
	Then Login page should open
	When User Enter email as "a@a.com" and password as "123456"
	And Clicks on Login button
	Then User should be redirected to home page
	When User Clicks on MyAccount link 
	Then Then User should be redirected to MyAccount Page 
	When Enter the company name as "Sample Company"
	And Click on Save Button 
	Then Comapany Name should be updated and User should be able to see the success message

Scenario: Verify user should be able able to see the orders of user
	When User clicks on login button
	Then Login page should open
	When User Enter email as "a@a.com" and password as "123456"
	And Clicks on Login button
	Then User should be redirected to home page
	When User Clicks on MyAccount link 
	Then Then User should be redirected to MyAccount Page 
	When when User click on Order link 
	Then Then order list should be displayed 

Scenario: Verify user should be able able to see the reward points of user
	When User clicks on login button
	Then Login page should open
	When User Enter email as "a@a.com" and password as "123456"
	And Clicks on Login button
	Then User should be redirected to home page
	When User Clicks on MyAccount link 
	Then Then User should be redirected to MyAccount Page 
	When when User click on Rewards Point link 
	Then Then rewards Points should be displayed as "Your current balance is 0 reward points ($0.00)."
	
