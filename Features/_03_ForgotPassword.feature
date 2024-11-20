Feature: PasswordRecovery

Scenario: Verify Email is sent for password recovery.
	When User clicks on Login Link 
	Then User should be redirected to Login Page 
	When User clicks on Forgot Password link
	Then User should be redirected to Password Recovery Page 
	When User Enter recovery Email as "a@a.com" 
	And Clicks Recover button
	Then User should see the be able to see the message for recovery email sent 

Scenario: Verify Email is not sent for password recovery if entered email not found.
	When User clicks on Login Link 
	Then User should be redirected to Login Page 
	When User clicks on Forgot Password link
	Then User should be redirected to Password Recovery Page 
	When User Enter recovery Email as "a@s.com" 
	And Clicks Recover button
	Then User should see the be able to see the message for recovery email not found
