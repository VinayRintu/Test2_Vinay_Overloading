// See https://aka.ms/new-console-template for more information
using Test2_Vinay_Overloading;

Console.WriteLine("Hello, World!");

MethodOverloadingCalculations objectOverloading = new MethodOverloadingCalculations();
double sumOfTwoIntegers= objectOverloading.Add(10, 10);
Console.WriteLine("Sum Of Two Integers  : "+ sumOfTwoIntegers);

string fullName= objectOverloading.Add("Ravula", "Vinay");
Console.WriteLine("Adding Firstname And Lastname : "+fullName);

 objectOverloading.Add(14, 15, 13);
