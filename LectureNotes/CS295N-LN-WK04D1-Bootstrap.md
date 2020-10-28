CS296N Web Development 2: ASP.NET

# Responsive Web Sites with Bootstrap

**Topics by week** 

| Weekly Topics                             |                                               |
| ----------------------------------------- | --------------------------------------------- |
| 1. Intro to Web Dev                       | 6. Entity Framework / Deploying a DB to Azure |
| 2. Intro to MVC / Deploying to Azure      | 7. Debugging / *Veteran's Day holiday*        |
| 3. Working with data                      | 8. Controllers                                |
| 4. **Bootstrap**                          | 9. Razor Views / *Thanksgiving holiday*       |
| 5. Midterm Quiz / Unit testing with xUnit | 10. Razor Views (continued)                   |



## Contents

[TOC]

------

## Introduction



### Announcements


## Bootstrap 



> *Build responsive, mobile-first projects on the web with the world's most popular front-end component library.* - from the Bootstrap web site
> Current version: 4.0.0

### Responsive Web Design

- Responsive web design (RWD) is an approach to web design which makes web pages render well on a variety of devices and window or screen sizes - [Wikipedia](https://en.wikipedia.org/wiki/Responsive_web_design)
- Responsive Web Design is about using HTML and CSS to resize, hide, shrink, enlarge, or move the content to make it look good on any screen - [W3Schools](https://www.w3schools.com/html/html_responsive.asp)

### What is Bootstrap?

- A CSS and JavaScript front-end web framework
- Simplifies responsive design
- Includes templates for typography, forms, buttons, tables, navigation, modals, image carousels and more
- Tutorial:[W3Schools Bootstrap 4 Tutorial](https://www.w3schools.com/bootstrap4/)
- Use with Razor views:
  - Add a link for the bootstrap min.css file to _Layout.cshtml so that it is available in all the views.

### Improvements on basic HTML and CSS

- Typography - redefines the default fonts for HTML elements and provides special font management classes
- Colors - contextual classes that provide "meaning through colors"
- Tables - adds light padding and horizontal dividers
- Images - provides multiple image shapes and makes images responsive
- Buttons - special classes that make `<a>`, `<input>`, or `<button>` elements look like nicely styled buttons
- Drop-downs
- Forms
- Inputs
- Tooltip

### Features and Concepts

This is not a comprehensive list of Bootstraps features and concepts. See one of the tutorials or the official Bootstrap site in the [Reference]() section for more.

- Containers - fixed width and fluid

- Grid system
The grid system is fundamental to the way Bootstrap facilitates responsive web sites.
  
  - Bootstrap’s grid system uses a series of containers, rows, and columns to position and align content. In version 4, the grid system is built with the CSS3 Flexbox, and in version 3 it was built using CSS floats. Both versions are fully responsive.
    
    - [Flexbox](https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_Flexible_Box_Layout/Basic_Concepts_of_Flexbox): A one-dimensional layout model that is part of CSS3. It provides a way to distribute space between items and align them. ("One dimensional" means flexbox deals with layout in one dimension at a time — either a row or a column.)
    
  - Columns
    
      - Rows can contain up to 12 columns.
    - The col class specifies the number of columns an element will span.
    
    | Class     | Screen Width | Name        |
    | --------- | ------------ | ----------- |
    | `col-`    | &lt;576px    | Extra small |
    | `col-sm-` | &gt;=576px   | Small       |
    | `col-md-` | &gt;=768px   | Medium      |
    | `col-lg-` | &gt;=992px   | Large       |
    | `col-xl-` | &gt;=1200px  | eXtra Large |
  
- Margins and Padding
  ([From W3Schools](https://www.w3schools.com/bootstrap4/bootstrap_utilities.asp))

  The classes are used in the format: `{property}{sides}-{size}` for `xs` and `{property}{sides}-{breakpoint}-{size}` for `sm`, `md`, `lg`, and `xl`.
  
  Where *property* is one of:
  
  - `m` - sets `margin`
  - `p` - sets `padding`
  
  Where *sides* is one of:
  
  - `t` - sets `margin-top` or `padding-top`
  - `b` - sets `margin-bottom` or `padding-bottom`
  - `l` - sets `margin-left` or `padding-left`
  - `r` - sets `margin-right` or `padding-right`
  - `x` - sets both `padding-left` and `padding-right` or `margin-left` and `margin-right`
  - `y` - sets both `padding-top` and `padding-bottom` or `margin-top` and `margin-bottom`
  - blank - sets a `margin` or `padding` on all 4 sides of the element
  
  Where *size* is one of:
  
  - `0` - sets `margin` or `padding` to `0`
  - `1` - sets `margin` or `padding` to `.25rem` (4px if font-size is 16px)
  - `2` - sets `margin` or `padding` to `.5rem` (8px if font-size is 16px)
  - `3` - sets `margin` or `padding` to `1rem` (16px if font-size is 16px)
  - `4` - sets `margin` or `padding` to `1.5rem` (24px if font-size is 16px)
  - `5` - sets `margin` or `padding` to `3rem` (48px if font-size is 16px)
  - `auto` - sets `margin` to auto
  
  **Note:** margins can also be negative, by adding an "n" in front of *size*:
  
  - `n1` - sets `margin` to `-.25rem` (-4px if font-size is 16px)
  - `n2` - sets `margin` to `-.5rem` (-8px if font-size is 16px)
  - `n3` - sets `margin` to `-1rem` (-16px if font-size is 16px)
  - `n4` - sets `margin` to `-1.5rem` (-24px if font-size is 16px)
  - `n5` - sets `margin` to `-3rem` (-48px if font-size is 16px)


- Jumbotron

  
  - [See W3Schools](https://www.w3schools.com/bootstrap4/bootstrap_jumbotron.asp)
  
- Buttons

  - [See W3Schools](https://www.w3schools.com/bootstrap4/bootstrap_buttons.asp)

- Forms

    - [See W3Schools](https://www.w3schools.com/bootstrap4/bootstrap_forms.asp)

### Using Bootstrap with ASP.NET Core

- Enable static pages in startup.cs

- Add to the head section of Razor views:

  ```
  <meta name="viewport" content="width=device-width, initial-scale=1">
  ```

  - *meta*
    Metadata is data about data. The <meta> tag provides metadata about the HTML document.Metadata will not be displayed on the page, but will be machine parsable. - W3Schools
  - *width=device-width* 
    Sets the width of the page to follow the screen-width of the device
  - *initial-scale=1*
    Sets the initial zoom level when the page is first loaded by the browser.




------

## Other Popular Front-End Libraries and Frameworks

- [jQuery](http://jquery.com)
  jQuery is a fast, small, and feature-rich JavaScript library. It makes things like HTML document traversal and manipulation, event handling, animation, and Ajax much simpler with an easy-to-use API that works across a multitude of browsers. With a combination of versatility and extensibility, jQuery has changed the way that millions of people write JavaScript. - from the jQuery web site
- [AngularJS](https://angularjs.org)
  *HTML is great for declaring static documents, but it falters when we try to use it for declaring dynamic views in web-applications. AngularJS lets you extend HTML vocabulary for your application. The resulting environment is extraordinarily expressive, readable, and quick to develop.* - from the AngularJS web site.
- [React](https://reactjs.org/docs/try-react.html)
  *React is a declarative, efficient, and flexible JavaScript library for building user interfaces.* - from the React web site
- [Font Awesome](https://fontawesome.com)
  *Gives you scalable vector icons that can instantly be customized — size, color, drop shadow, and anything that can be done with the power of CSS*. - from the FontAwesome web site

------

## Static Web Content in Core ASP.NET MVC

Static web content primarily consists of HTML, CSS and JavaScript files (but can also include images, etc.) 

- In ASP.NET projects, CSS and JavaScript and typically are stored in:
  - wwwroot/js
  - wwwroot/css
- Static pages must be enabled your web app. 
  - They are enabled by default when you use the Visual Studio MVC App project template to create your app.

### LibMan

> Library Manager (LibMan) is a lightweight, client-side library  acquisition tool. LibMan downloads popular libraries and frameworks from the file system or from a [content delivery network (CDN)](https://wikipedia.org/wiki/Content_delivery_network). The supported CDNs include [CDNJS](https://cdnjs.com/), [jsDelivr](https://www.jsdelivr.com/), and [unpkg](https://unpkg.com/#/). The selected library files are fetched and placed in the appropriate location within the ASP.NET Core project.&mdash;Scott Addie in [Client-side library acquisition in aSP.NET Core with LibMan](https://docs.microsoft.com/en-us/aspnet/core/client-side/libman/?view=aspnetcore-3.1)

### Bundling and Minification

- Facilitate fast file loading for client browsers
  - Bundling - reduce the number of HTTP requests needed
  - Minification - reduce file size
- Visual Studio Bundler & Minifier extension
  - Add to visual studio through the menu item: Tools ➤ Extensions and Updates, then select "online"
  - In the Solution Explorer, select multiple files of the same type (css or js), right-click, and select "Bundle and MInify Files"
    - Files must be selected in the order you want them to be loaded by the browser
    - The result will be a bundle.css or bundle.js file which will contain:
      - bundle.min.js
      - or bundle.min.css
  - Experiment: Open the new files and inspect them. What do you see?
  - Visual Studio automatically updates minified bundles
    - Modify a source .js or .css file to see how the bundle.min file gets updated
- Linking to the files in the Razor View
  - Modify the original link and script elements to link to the new minified bundles:
    - <link rel="stylesheet" href="css/bundle.min.css" />
    - <script src="js/bundle.min.js"></script>

------



## Example

[GitHub Repository: 
CS296N-BookInfo-Core-2
AddBootstrap branch](https://github.com/LCC-CIT/CS296N-BookInfo-Core-2/tree/AddBootstrap)



## Reference

### Textbook

Ch. 3, "How to make a web app responsive with Bootstrap", *Murach’s ASP.NET Core MVC*, 1st Edition, by Mary Delamater and Joel Murach, Murach Books, 2020.

**Note:** the textbook example uses the Bootstrap class `form-horizontal` [which has been deprecated in Bootstrap 4](https://getbootstrap.com/docs/4.5/migration/#forms-1).

### Online

[Use LibMan with ASP.NET Core in Visual Studio](https://docs.microsoft.com/en-us/aspnet/core/client-side/libman/libman-vs?view=aspnetcore-3.1)&mdash;Microsoft Tutorial by Scott Addie

[Bootstrap 4 Tutorial](https://www.w3schools.com/bootstrap4/default.asp)&mdash;W3Schools

[Bootstrap Web Site](http://getbootstrap.com)&mdash;Official site

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

