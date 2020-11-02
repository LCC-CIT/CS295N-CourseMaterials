#Lambda Expressions



**Contents**

[TOC]

## Lambda syntax

This syntax gives us an alternative way to define methods. 

  Example: 

  ```C#
  // A normal method definition
  float Sum(int a, int b){     return a + b;}
  
  // A lambda method definition
  float Product(int a, int b) => a * b; `
  ```

  [Lambda Expressions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions) - MS C# Programming Guide

  

## Anonymous methods and Delegates

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
  names.Sort((name1,name2) =>  name1.Substring(name1.Length - 1)
             .CompareTo(name2.Substring(name2.Length - 1)));
  foreach(string s in names) {
    Console.WriteLine(s)
  }
  ```

- [Experiment with this on DotNet Fiddle](https://dotnetfiddle.net/CK1pwt)

- [MS Docs: List Sort method](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=netframework-4.7.2)

- **Func** - a predefined delegate class
  Syntax: 
  
  `Func<T, TResult)`

  Example:
  
  ```C#
  
  // Definition of a delegate using the Func class
  static Func Calculate = (n1, n2) => n1 - n2;
  /***** In Main *****/
  Console.Write("Test Calculate with subtract method: ");
  Console.WriteLine(Calculate(5, 7));
  // Assign a new method to the Calculate delegate using a lambda expression
  // and test it
  Calculate = (nm1, nm2) => {return nm1 * nm2;};
  Console.Write("Test mathDel with multiply method: ");
  Console.WriteLine(Calculate(5, 7));
  ```
  
  
  
- [Experiment with this on DotNet Fiddle](https://dotnetfiddle.net/)

- MS Docs: [Func Delegate](https://docs.microsoft.com/en-us/dotnet/api/system.func-2?redirectedfrom=MSDN&view=netframework-4.7.2)

**Reference**

- [Microsoft C# Language Reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/)
- [Microsoft C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog/) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------