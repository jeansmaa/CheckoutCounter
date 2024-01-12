Summary
To achieve the objective of the exercise, all the required functionalities have been implemented.
There are two projects in the solution:
•	CheckoutCounter (program logic and structure).
•	CheckoutCounter.Tests (program unit tests).

There are two service present on this project.
CC_CheckOutService: This the service to scan the products to calculate the total price taking into consideration the active promotions. 
CC_PromotionService: This is the service to mangage the list of active promotions. Every elemnet of the list have a promotion and the product associated to it.

*******************************************************************************************************************************************************************
Running the app
Step by Step to start the process
1- Create a new instance of CC_PromotionService.
2- Create a new instance of CC_CheckOutService.
3- Create one or many instance of CC_Product to be scanned.
4- If any of the products is going to be on promotion create a new instance of CC_Promotion and add it to the list on CC_PromotionService.
5- Call the method Scan using the instance of CC_CheckOutService.

*******************************************************************************************************************************************************************
Promotions Logic on this software 
********Buy one, get one free: Every time the customer pay for one item the next one is for free.
Beer price: 2 usd
Example 1:
Customer buy 1 beers, the customer have to pay 2 usd.
Example 2:
Customer buy 2 beers, the customer have to pay 2 usd.
Example 3:
Customer buy 3 beers, the customer have to pay 4 usd.
Example 4:
Customer buy 4 beers, the customer have to pay 4 usd.

********Buy two, get one free: Every time the customer pay for two item the next one is for free.
Beer price: 2 usd
Example 1:
Customer buy 1 beers, the customer have to pay 2 usd.
Example 2:
Customer buy 2 beers, the customer have to pay 4 usd.
Example 3:
Customer buy 3 beers, the customer have to pay 4 usd.
Example 4:
Customer buy 4 beers, the customer have to pay 6 usd.
Example 5:
Customer buy 5 beers, the customer have to pay 8 usd.
Example 6:
Customer buy 6 beers, the customer have to pay 8 usd.





