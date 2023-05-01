# Design Patterns (Working on)
This repository contains a collection of commonly used design patterns that I have implemented to better understand how they work and how they can be applied to solve software engineering problems.

To keep the code organized, I've created a separate class library project to hold all the design patterns. I have also provided detailed documentation and code examples for each pattern to make it easy for users to understand how they work and how to use them.

Here are some of the design patterns that are included in this repository:

1-Singleton Pattern
                          
                          
2-Adapter Pattern      

I assume that PayRollSystem ( a legacy system) i have to deal with it so in AdapterPattern projc i apply this pattern by `PayrollSystemEmployeeAdapter.cs` and `PayrollSystemPayItemAdapter.cs` to to constract the `Empolyee` and `PayItem` that the `PayRollsystem` to adapt the expected inputs and outputs
far from chenges requirements in AdapterPattern projc
          
3-Strategy Patter 

4-Factory Patterns n (handilling Null Object)

 Apply simple factory pattern in `SalesSystem` project when create new instance of `ICustomerDiscountStrategy` to centralizetion creation instance with in `CustomerDiscountStrategyFactory` and handling null object excebtion  by return the default instance of `NewCustomerDiscountStrategy`,

5-Template Method Pattern 

in `SalesSystem` procject
    in this case i have to Shoping cart types one for `online` and another `in store` and have a steps to calculate taxes and discount in this case requirments is to calculate discount only in `online` and for some reason there's no discount for `In store` carts for now so by make a `ShopingCart` abstract class as a base class and a chiled class `OnlineShopingCart`,`InstoreShopingCart` 
and ovveride the behavier of `ApplyDiscount()` which is a 'template method' to calculate discount only in online,
-Decorator Pattern

-Observer Pattern

-Command Pattern

 


For each pattern, I have provided a brief description of what it is, how it works, and when it is appropriate to use. I have also included code examples in C# to illustrate how the pattern can be implemented.
