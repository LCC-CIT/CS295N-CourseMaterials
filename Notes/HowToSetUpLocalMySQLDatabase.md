<h1>How to Set Up a Local MySQL Database</h1>

[TOC]

## Install MySQL and MySQL Workbench

Download the [community version here](https://dev.mysql.com/downloads/workbench/). Use version 8.0.45 of the installer (the latest as of 2/10/2026). 

- There are two installers, a web installer and a standard installer. I recommend using the web installer since the initial download size is small. It will download just the items you choose to install as it installs them.

- On the opening dialog of the installer, choose the "Full" option, which will install MySQL Server and MySQL Workbench (a GUI client for managing MySQL Server, users and databases), along with some other related tools.
- Choose version 8.0.44 of MySQL Server.
- Accept all the default configuration settings in the install dialogs.

**Notes:** 

- The latest LTS version of the Community Edition of MySQL Server is 8.4.8, but it is not fully compatible with the Community Edition of MySQL Workbench.
- These instructions were tested on Windows 11, but should also work on Windows 10 and with minor changes on MacOS.



## Create a New User and Database

### 1. Create a New User
1. Open MySQL Workbench and on the home page, connect to MySQL server as the root user.  
   <img src="Images\MysQL_Workbench_Connectins.png" alt="MysQL_Workbench_Connectins" style="zoom:40%;" />

   You will get warnings about MySQL 8.4 being incompatible with MySQL Workbench 8.0, but you can ignore these.

2. Go to **Server** > **Users and Privileges**.

3. Click on **Add Account**.

4. Enter a username and password for the new user.

5. Set the account limits, roles, and schema privileges as needed.

6. Click **Apply** to create the new user.

### 2. Log In as the New User
1. Close the current session in MySQL Workbench.
2. On the home page, reconnect to the MySQL server using the new user credentials.

### 3. Connect to the Local MySQL Server
1. Click on the **+** button next to MySQL Connections in the home screen.
2. Enter a connection name, hostname (usually `localhost`), port (default is `3306`), username, and password.
3. Click **Store in Vault** to save the password securely.
4. Test the connection and click **OK** to establish it.

### 4. Create a New Database
1. Once connected, go to **Server** > **Data Import**.
2. Select **Import from Self-Contained Archive** and browse for the database file (if you have one) or **Import from Dump**.
3. Follow the prompts to create a new database.

## Determine the ADO.NET Connection String

1. The ADO.NET connection string typically looks like this:
   ```plaintext
   Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
   ```
   Replace `myServerAddress`, `myDataBase`, `myUsername`, and `myPassword` with your actual server address, database name, username, and password.

## Reference

[MySQL Community Edition](https://www.mysql.com/products/community/)&mdash;Oracle

[MySQL 8.4 Reference Manual](https://dev.mysql.com/doc/refman/8.4/en/)&mdash;Oracle

[MySQL Workbench Manual](https://dev.mysql.com/doc/workbench/en/)&mdash;Oracle

---

These instructions were written by Brian Bird in fall 2024 using Microsoft Copilot with GPT-4 for the first draft, revised in winter <time>2026</time>. 

---