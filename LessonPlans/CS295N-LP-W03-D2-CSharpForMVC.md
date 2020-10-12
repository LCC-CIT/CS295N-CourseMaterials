#Important C# Features for ASP.NET Core MVC

****

| Where we are                          |                                         |
| ------------------------------------- | --------------------------------------- |
| 1. Intro to MVC                       | 6. Unit Testing                         |
| 2. More on MVC / Satelessness of HTTP | 7. Model Design / Entity Framework (EF) |
| 3. C# Review / Advanced C# for MVC    | 8. More on EF / LINQ                    |
| 4. Razor Views                        | 9. Model Binding / Validation           |
| 5. Web Dev Tools / Midterm            | 10. Configuration / URL routing         |

**Contents**

[TOC]

##Introduction

Your textbook (Freeman 2017), describes quite a few C# features with which you may or may not be familiar. These notes cover some of the features that I think are either trickier to understand or that are likely to be unfamiliar.

##Handling Nulls

- **Declaring an object to be nullable** using `?`

  Example:  

  ```C#
  // Reference types are inherently nullable
  string favoriteElf = null;
  
  // But value types are not nullable
  int numberOfRings = null;
  // assignment error!
  
  // We can declare a value type as nullable this way: 
  int? numberOfElfRings = null;
  ```

  [Experiment with this example on .NET Fiddle ](https://dotnetfiddle.net/np40Nr)

  

- **Null Coalescing operator**: `??`

  This operator is used to test for a null value and return a specified value instead of null.

  Example:

  ```C#
  // Parallel arrays with the number of rings given and to whom 
  // There is intentionally a null in place of the Dark Lord
  int[] rings = {9, 7, 3, 1}; string[] owners = {"Mortals", "Dwarves", "Elves", null}; 
  
  // Try switching to the commented out line and see what happens 
  for(int i = 0; i < rings.Length; i++) 
  {  
    // Console.Write(owners[i]);  
    Console.Write(owners[i] ?? "");  
    Console.WriteLine(": " + rings[i]); 
  }
  ```
  [Experiment with this example on .NET Fiddle](https://dotnetfiddle.net/J0SaAM)

  [The null coalescing operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator) - MS C# Language Reference

  

- **Null Conditional operator**: `?` 

  Used to test an object for null before accessing an element or field. It short-circuits the operation and returns null.

  ```C#
// Parallel arrays with the number of rings given and to whom
  // There is intentionally a null in place of the Dark Lord
int[] rings = {9, 7, 3, 1};
  string[] owners = null;

  // Try removing the null conditional operator and see what happens
  for(int i = 0; i < rings.Length; i++) 
  {  
    Console.WriteLine(owners?[i] + ": " + rings[i]);
  }
  ```
  
  [Experiment with this example on .NET Fiddle](https://dotnetfiddle.net/Fm1HAj)
  
  [The null conditional operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-conditional-operators) - MS C# Language Reference

***Note***: in the textbook (Freeman 2017), on page 71, theGetProducts method is just for demonstration purposes. You wouldn't put a method like this in a "real" model.

**Extension Methods** 

This C# feature allows you to add methods to a class for which you cannot modify the source code. This could be a class that is part of the .NET Library, or it could be some 3rd party library that you can't modify.

- Example:
  `public static class IntExtension{  // the parameter following *this* is the class that is being extended   public static string DigitToWord(this int i)   {     string word;     switch(i)     {       case 1: word = "one";         break;       case 2: word = "two";         break;       default: word = "out of range";         break;     }     return word;   }} ``public class Program{   public static void Main()   {     int aNumber = 3;     Console.WriteLine(aNumber.DigitToWord());   }}`
- [Experiment with this example on .NET Fiddle](https://dotnetfiddle.net/Qdf8Cy)
- [Extension Methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods) - MS C# Programming Guide
- [How to: Implement and Call a Custom Extension Method](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-implement-and-call-a-custom-extension-method) - MS C# Programming Guide



**Lambda Expressions** 

- **Lambda syntax** 
  

This syntax gives us an alternative way to define methods. 

  Example: 

  ```C#
  // A normal method definition
  float Sum(int a, int b){     return a + b;}
  
  // A lambda method definition
  float Product(int a, int b) => a * b; `
  ```

  [Lambda Expressions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions) - MS C# Programming Guide

  

- **Anonymous methods and Delegates** 
  

One of the advantages of lambda expressions is that they make it easy to define anonymous methods. One way anonymous methods are used is when assigning a method to a delegate.

  ```C#
  // Declaration of a delegate type
  public delegate int Calculate (int n1, int n2);  
  
  // Create an instance of the delegate
  // and assign an anonymous method to it the old/normal way
  static Calculate mathDel = delegate(int n1, int n2) {return n1 - n2;};
  
  // see the lambda version of this below, in the main  
  /***** Drivers for the methods above *****/
  public static void Main() {    
    Console.Write("Test mathDel with subtract method: ");
    Console.WriteLine(mathDel(5, 7));
    // assign a new method to mathDel using a lambda and test it
    mathDel = (nm1, nm2) => {return nm1 * nm2;};
    Console.Write("Test mathDel with multiply method: ");
    Console.WriteLine(mathDel(5, 7));
  }
  ```

  [Experiment with this on DotNet Fiddle](https://dotnetfiddle.net/1AXWid)

  

- The List Sort method has a function parameter which expects a delegate:
  
  `List.Sort(Comparison<T>)`
  

 Here's an example of using a lambda expression to define a delegate and using it in the Sort method:

  ```C#
  var names = new List() {"Fili", "Kili", "Oin", "Gloin", "Bombur", "Boffer"};
  // Sort using a custuom Comparison delegate - sort on last letter of name
  names.Sort((name1,name2) =>  name1.Substring(name1.Length - 1).CompareTo(name2.Substring(name2.Length - 1)));
  foreach(string s in names) {  Console.WriteLine(s)`
  ```

  

  

- [Experiment with this on DotNet Fiddle](https://dotnetfiddle.net/CK1pwt)

- [MS Docs: List Sort method

  ](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=netframework-4.7.2)

- **Func** - a predefined delegate class
  Syntax: Func<T, TResult)
  Example:
  `// Definition of a delegate using the Func classstatic Func Calculate = (n1, n2) => n1 - n2;/***** In Main *****/Console.Write("Test Calculate with subtract method: ");Console.WriteLine(Calculate(5, 7));     // assign a new method to the Calculate delegate using a lambda expression and test itCalculate = (nm1, nm2) => {return nm1 * nm2;};Console.Write("Test mathDel with multiply method: ");Console.WriteLine(Calculate(5, 7));` 

- [Experiment with this on DotNet Fiddle](https://dotnetfiddle.net/)

- MS Docs: [Func Delegate](https://docs.microsoft.com/en-us/dotnet/api/system.func-2?redirectedfrom=MSDN&view=netframework-4.7.2)

**Reference**

- [Microsoft C# Language Reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/)
- [Microsoft C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog/) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------