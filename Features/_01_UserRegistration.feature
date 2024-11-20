Feature: UserRegistration

Scenario: Validate user can open registration page on nopCommerce app
  When Click on Registration button 
  Then Registration page should open 

Scenario: Verify User registers with a valid info, email and password 
  When User Enters the Personal Details as First name as "Jacob" and Last name as "Mtest" and Email as "a@a.com"
  And Check the Newsletter check box 
  And Enters the password as "123456" and confirm password as "123456"
  And Click on Register button 
  Then User should should be able to see message for successfull registration 
  When Click on the Continue button after registration 
  Then User should be logged in and redirected to Hope Page 
