Feature: UserLogin

Background: 
	Given Browser is open and User is on nopCommerce landing page

Scenario: Verify User is able to login with valid login credentials
  When User clicks on login button
  Then Login page should open
  When User Enter email as "a@a.com" and password as "123456"
  And Clicks on Login button
  Then User should be redirected to home page
  
Scenario: Verify the error message for invalid login
  When User clicks on login button
  Then Login page should open
  When User Enter invalid email as "a@s.com" and and password as "123456"
  And Clicks on Login button
  Then User should see the error message for invalid login credentials 

Scenario: Verify User is able to LogOut successfully
  When User clicks on login button
  Then Login page should open
  When User Enter email as "a@a.com" and password as "123456"
  And Clicks on Login button
  Then User should be redirected to home page
  When Click on Logout Button 
  Then user should be logged out successfully 

Scenario: Verify user gets error when user enters email in wrong format
  When User clicks on login button
  Then Login page should open
  When User Enter email as "a@a" and password as "123456"
  Then User should get error message for as "Wrong email"

Scenario: Verify User gets error message to enter email address when email kept empty
  When User clicks on login button
  Then Login page should open
  When User Enter email as "" and password as "123456"
  And Clicks on Login button
  Then User should get error message as "Please enter your email"
