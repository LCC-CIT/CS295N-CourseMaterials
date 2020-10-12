#Handling Nulls in C#

****

**Contents**

[TOC]

## Declaring an object to be nullable using `?`

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



## Null Coalescing operator: `??`

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



## Null Conditional operator: `?` 

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

## Reference

- [Microsoft C# Language Reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/)
- [Microsoft C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog/) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------