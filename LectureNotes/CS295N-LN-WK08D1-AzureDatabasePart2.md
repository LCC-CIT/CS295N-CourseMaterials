---
title: Create and configure an Azure MySQL Db Server
description: How to create and configure an Azure Database for MySQL Flexible Server
keywords: MySQL, environment variable, connection string, Azure, publish
material: Lecture Notes
generator: Typora
author: Brian Bird
---

**CS295N Web Development 1: ASP.NET**

<h1>Data base and Entity Framework</h1>

<h2>Contents</h2>

[TOC]

## Introduction

Previously, we added Entity Framework to our web apps and set up a local MySQL database server. We used dotnet CLI commands to add migrations and update the database with a schema based on the migrations.

In this session, we will create a MySQL database server on Azure, configure it and use dotnet CLI commands to update the database with the schema for our web apps.

## 1. Create and Configure an MySQL Server on Azure

Follow these instructions: [Setup for Azure Database for MySQL Flexible Server](../Notes/AzureMySqlSetupGuide.html#with-ef-cli-tools)  
Note that Azure will fail to deploy your server if it isn't in certain regions. The regions that work seem to vary from user to user. Two regions that have worked for some are: West US 2 and West US 3  (February 2026). This seems to be a "glitch" on Azure since according to the documentation all US regions should work.

## 2. Prepare Your Web App and Dev Environment

### Prerequisites

- You should have previously added an `appsettings.Development.json` file to your project with a connection string for your local MySQL server in it.

- You should have also set up your project to manage user secrets so that your connection string does not contain the username and password for your local database server.

### Add a Production appsettings File and DB Credentials.

- Add an `appsettings.Production.json` file to your project with a connection string for your Azure MySQL server in it. This will look just like the connection string for the dev DB server except the server name will be for the one on Azure.

  ```json
  "server=cs295mysqlserver.mysql.database.azure.com;database=code_reviews;""
  ```

- Add your Azure DB server username and password to environment variables on your dev machine. This is the syntax to use to set and verify them:   
  **Power Shell:**

  ```powershell
  $env:DbUser="your_azure_username"
  $env:DbPassword="your_azure_password"
  echo $env:DbUser
  echo $env:DbPassword
  ```

  **Command Prompt**

  ```bash
  set DbUser=your_azure_username
  set DbPassword=your_azure_password
  echo %DbUser%
  echo %DbPassword%
  ```

## 3. Update the Database on Azure

- Execute this CLI command from the folder containing your web app project on your dev machine:  
  ```bash
  dotnet ef database update -- --environment production
  ```
  Note that there are two sets of dashes, `-- --` , this is not a typo!

- Verify that your schema (tables) were added to the database by connection MySQL Workbench to the DB on Azure.

## 4. Prepare your App Service an Publish to Azure

- Using the Azure Portal web page, Go to your App Service. In the menu on the left select Settings and then Environment Variables. Use the interface provided to add environment variables for the DB username and password. Use the same *names* and *values* you used on your dev machine.
- Now you can publish your web app like you have done previously and it should work with the database you just set up on Azure.


------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) These ASP.NET Core MVC Lecture Notes written by [Brian Bird](https://profbird.dev) in <time>2026</time>,  are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

