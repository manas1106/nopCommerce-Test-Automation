Feature: SearchProduct

Scenario: Verify user is able to search from  Product search bar
  When User clicks on login button
  Then Login page should open
  When User Enter email as "a@a.com" and password as "123456"
  And Clicks on Login button
  Then User should be redirected to home page
  When User Enter the Product Name <"Product"> in Search textbox
  And Click Search button 
  Then User should see the searched product or result as <"search_result">

Examples: 
	| Prodcut              | search_result                                      |
	| Flower Girl Bracelet | Flower Girl Bracelet                               |
	| WVS                  | No products were found that matched your criteria. |

