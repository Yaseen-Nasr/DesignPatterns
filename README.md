# Design Patterns (Working on)
This repository contains a collection of commonly used design patterns that I have implemented to better understand how they work and how they can be applied to solve software engineering problems.

To keep the code organized, I've created a separate class library project to hold all the design patterns. I have also provided detailed documentation and code examples for each pattern to make it easy for users to understand how they work and how to use them.

Here are some of the design patterns that are included in this repository:

1-Singleton Pattern
                          
                          
2-Adapter Pattern      

I assume that PayRollSystem ( a legacy system) i have to deal with it so in AdapterPattern projc i apply this pattern by `PayrollSystemEmployeeAdapter.cs` and `PayrollSystemPayItemAdapter.cs` to to constract the `Empolyee` and `PayItem` that the `PayRollsystem` to adapt the expected inputs and outputs
far from chenges requirements in AdapterPattern projc
          
3-Strategy Pattern && -Factory Patterns (handilling Null Object)

 Apply simple factory pattern in `StrategyPattern` project when create new instance of `ICustomerDiscountStrategy` to centralizetion creation instance with in `CustomerDiscountStrategyFactory` and handling null object excebtion  by return the default instance of `NewCustomerDiscountStrategy`,


-Decorator Pattern

-Observer Pattern

-Command Pattern

-Template Method Pattern



For each pattern, I have provided a brief description of what it is, how it works, and when it is appropriate to use. I have also included code examples in C# to illustrate how the pattern can be implemented.
