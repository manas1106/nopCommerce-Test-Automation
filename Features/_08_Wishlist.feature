Feature: Wishlist

Scenario: Verify User is able to login with valid login credentials
  When User clicks on login button
  Then Login page should open
  When User Enter email as "a@a.com" and password as "123456"
  And Clicks on Login button
  Then User should be redirected to home page
  When User clicks on wishlist link
  Then user should be able to see the wishlist page
  And Wishlist item count should be "(0)"
