# Asynchronous Programming with Asynch and Await

## Task Asynchronous Programming Model

Asynchronous methods are non-blocking methods. Execution moves on to the next line of code after the method call without waiting for the method to reutrn.

Each asyc method returns a ***Task*** object. You can start as many Async methods as you want (within practical limits) without waiting for one to finish before you start another.

The ***await*** keyword provides a way to pause execution until an async method completes or until it returns a Task object. Using await on a Task rather than a method often improves performance.

Use the ***async*** keyword when declaring an asynchronous method. 

- Any method declared as async, must return a Task object. This can be done by:
  - Calling another async method.
  - Using the static ***Task.FromResult&lt;T&gt;()*** method to return a Task.
- Every async method must be called from withiin another async method or the async method can be called with the .***Wait()*** method.

## Examples

[Async Breakfast example](https://github.com/dotnet/samples/tree/master/snippets/csharp/tour-of-async) (for Microsoft tutorial)

## References

Wenzel, Maria, et al [Asynchronous programming with async and await](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/). 2019. Microsoft Programming Guide.

Video tutorials by Mika Dumont and Bill Wagner. [Introduction To Async, Await, And Tasks | C# Advanced [5 of 8]](https://channel9.msdn.com/Series/C-Advanced/Introduction-To-Async-Await-And-Tasks--C-Advanced-5-of-8?term=async%20await&lang-en=true). 2020. Microsoft C# Advanced Video Tutorial.



------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
These ASP.NET Core MVC Lecture Notes, written by [Brian Bird](https://birdsbits.blog), fall 019, are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

