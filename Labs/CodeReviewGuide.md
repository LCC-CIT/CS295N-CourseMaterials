# Code Review Guide

Use this guide when responding to your lab partner's PR. You can do the review "free form" by writing a review that address all of the areas listed below, or you can use the [Code Review Checklist](CodeReviewCehcklist.md) I've written. 

The checklist is a markdown document. It won't open in your browser, but you can download it and then paste the checklist section of the document into the comment section of your lab partner's PR and answer all the questions in the checklist. 

## Functionality

- Does it compile without errors?
- Does it run without throwing exceptions or crashing?
- Does it meet all the requirements for this lab assignment?
- Is the code written using correct style and best coding practices?

## Aspects of coding style to check

- Is proper indentation used?

- Are the HTML elements and variables named descriptively?

- Have any unnecessary lines of code or files been removed?

- Are there explanatory comments in the code?

- Do variable names use camelCase? 

- Are properties, methods and classes named using PascalCase (aka TitleCase)?

- Are constant names written using ALL_CAPS?

## Best practices in Object Oriented Programming

- Is the code DRY (no duplicated blocks of code)?

- Are named constants used instead of repeated literal constants?

- Is code that does computation or logical operations separated into its own class instead of being added to the code-behind?

- Are all instance variables (aka fields) private?

- Are local variables used instead of instance variables wherever possible?

- Does each method do just one thing (no “Swiss Armey” methods)?

- Are classes “loosely coupled” and “highly coherent”?



------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC course materials by [Brian Bird](https://profbird.dev), written 2017, revised 2022, are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

