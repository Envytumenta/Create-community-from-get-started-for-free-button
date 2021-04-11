Feature: Createcommunity
 
@Create community from the GET STARTED FOR FREE button 

Scenario:Create community from the GET STARTED FOR FREE button on the home screen.
Given that I am a user on Giftrete website (www.giftrete.com)
When user click on get started for free button
And user click on register
And user enter email address
And user enter first name
And user enter last name
And user enter phone number
And user enter password
And user re-enter password 
And user Click on register now button
Then user should be logged in