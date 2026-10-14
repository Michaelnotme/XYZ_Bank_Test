Feature: Add Customer
  As a Bank Manager
  I want to add a new customer

Scenario: Bank Manager successfully adds a new customer
  Given I navigate to the banking website
  When I click on the Bank Manager Login button
  And I click on the Add Customer tab
  And I enter First Name "Bdzhilka", Last Name "Shalena", and Post Code "E55669"
  And I click the Add Customer submit button
  Then I should see a success alert and accept it