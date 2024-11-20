Feature: OpenProductDetails 

Scenario: Verify product details page should open when click on product 
  When User clicks on login button
  Then Login page should open
  When User Enter email as "a@a.com" and password as "123456"
  And Clicks on Login button
  Then User should be redirected to home page
  When User Clicks on Product Link of product Apple MacBook Pro 13 inch
  Then Product Details should open 
  And Product prrice should be displayed 
