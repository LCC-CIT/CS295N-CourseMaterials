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
  - 
  - Add a link for the bootstrap min.css file to _Layout.cshtml so that it is available in all the views
- Official web site: http://getbootstrap.com

### Features and Concepts

- Preliminaries

  - Enable static pages in startup.cs

  - Add to the head section:

    ```
    <meta name="viewport" content="width=device-width, initial-scale=1">
    ```

    - *meta*
      Metadata is data about data. The <meta> tag provides metadata about the HTML document.Metadata will not be displayed on the page, but will be machine parsable. - W3Schools
    - *width=device-width* 
      Sets the width of the page to follow the screen-width of the device
    - *initial-scale=1*
      Sets the initial zoom level when the page is first loaded by the browser.

- Containers - fixed width and fluid

- Grid system

  - Bootstrap’s grid system uses a series of containers, rows, and columns to position and align content. In version 4, the grid system is built with the CSS3 Flexbox, and in version 3 it was built using CSS floats. Both versions are fully responsive.
    - [Flexbox](https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_Flexible_Box_Layout/Basic_Concepts_of_Flexbox): A one-dimensional layout model that is part of CSS3. It provides a way to distribute space between items and align them. ("One dimensional" means flexbox deals with layout in one dimension at a time — either a row or a column.)

- Improvements on basic HTML and CSS

  - Typography - redefines the default fonts for HTML elements and provides special font management classes
  - Colors - contextual classes that provide "meaning through colors"
  - Tables - adds light padding and horizontal dividers
  - Images - provides multiple image shapes and makes images responsive
  - Buttons - special classes that make <a>, <input>, or <button> elements look like nicely styled buttons
  - Drop-downs
  - Forms
  - Inputs
  - Tooltip

- Features not in HTML or CSS

  - Jumbotron - large grey box that calls attention to it's content. It is responsive
  - Alerts - Messages with colored backgrounds and an x to dismiss them
  - Button Groups - horizontal or vertical row of buttons with the same colored background
  - Badges - used to add additional information to a line
  - Progress bars - turn a container element into a progress bar
  - Pagination
  - List Groups
  - Cards
  - Navs
  - Navbar
  - Carousel
  - Modal
  - Popover
  - Scrollspy
  - Utilities
    - Border
    - Radius
    - Align
    - Float
    - Width, Height
    - Spacing
    - Position

- 

- 
- 

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
- See page 153 in the textbook for more details
- Static pages must be enabled your web app (the section on Bower)

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

## Book Info Web App Example

[GitHub Repository: 
CS296N-BookInfo-Core-2
AddBootstrap branch](https://github.com/LCC-CIT/CS296N-BookInfo-Core-2/tree/AddBootstrap)

## Reference

[Use LibMan with ASP.NET Core in Visual Studio](https://docs.microsoft.com/en-us/aspnet/core/client-side/libman/libman-vs?view=aspnetcore-3.1)

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------