<h1>C# Features for MVC: Part 1</h1>

****

**Contents**

[TOC]

## C# Attributes

Attributes are used for adding *metadata*[^1] to C# code elements such as: classes, methods, and properties. We can write our own attributes or use pre-written attributes. 

Read more about attributes here: [Use Attributes in C#](https://learn.microsoft.com/en-US/dotnet/csharp/tutorials/attributes)

### Attributes used in ASP.NET


`[HttpGet]`

Identifies a controller method that handles HTTP GET requests. The ASP.NET middle-ware will route incoming GET requests, with a matching URL, to a method with this attribute. This is the default for controller methods, so methods without any attribute will still get GET requests.

`[HttpPost]`

This does the same thing as `[HttpGet]` except for POST requests.

`        [Required]`

This attribute is a validation constraint that can be placed on a model property that will enable you to write code to generate an error message if a user doesn't enter anything when filling out a form that uses a model with this property.

`[StringLength(500, MinimumLength = 10)]`

This is also a validation constraint that can be used on a model property. This one constrains a string to a minimum length of 10 and maximum length of 500.



## Handling Nulls in C#

### Declaring an object to be nullable using `?`

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



### Null Coalescing operator: `??`

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



### Null Conditional operator: `?` 

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
- [Use Attributes in C#](https://learn.microsoft.com/en-US/dotnet/csharp/tutorials/attributes)&mdash;Microsoft Tutorial



[^1]: *Metadata* is general computer science term for structured information (data) that might be added to some software element.

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev/) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 