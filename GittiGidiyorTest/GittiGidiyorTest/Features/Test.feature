Feature: Test
	GittiGidiyor Test Feature

@mytag
Scenario: Test For GittiGidiyor
	Given I lounch the Application
	Then I should see  page title 
	When I have entered "Samsung" into SearchBox
	Then Labels related to "Samsung" are shown on the results page
	When I locate second page
	Then I should know second page is shown
	When I add third product to Cart
	And I click Cart Button
	Then I should see third product is shown 
	And I remove product 
	And I validate product not exist in cart
	
