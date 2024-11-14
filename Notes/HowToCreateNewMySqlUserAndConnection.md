<h1>How to Create a New MySQL User</h1>



These instructions assume you have installed a MySQL Server and MySQL Workbench.

## Create a New User
1. Log into MySQL Server via MySQL Workbench with a root user account. 
2. Under the ‘MANAGEMENT’ menu, click on ‘Users and Privileges’ to open the ‘Users and Privileges’ window.

![CreateNewMySqlUser1](Images\CreateNewMySqlUser1.png)

3. Click on the Add Account button.

![CreateNewMySqlUser2](Images\CreateNewMySqlUser2.png)

4. Enter the Login Name for the new user, set Authentication Type to "caching_sha2_password", for Limit to Hosts Matching enter "localhost", then enter a password and confirm it. When you're done click "Apply"

![CreateNewMySqlUser3](Images\CreateNewMySqlUser3.png)

5. Click on the "Account Limit" tab and set all account limits to 1000.

![CreateNewMySqlUser4](Images\CreateNewMySqlUser4.png)

6. Click on the "Administrative Roles" tab and select the "DBmanager", "DBDesigner", and "BackupAdmin" check boxes.

![CreateNewMySqlUser5](Images\CreateNewMySqlUser5.png)

7. Click on "Apply", then close the tab for the root connection.

![CreateNewMySqlUser6](Images\CreateNewMySqlUser6.png)

## Add a Connection for the New User

1. On the MySQL Workbench home screen, click on the + to add a new connection.

![CreateNewMySqlUser7](Images\CreateNewMySqlUser7.png)

2. Enter a connection name and the username and leave everything else set to the defaults.

![CreateNewMySqlUser8](D:\Repos\CS295N-CourseMaterials\Notes\Images\CreateNewMySqlUser8.png)

3. Click on "Test Connection". A dialog will pop up. In the dialog box, enter the password for the new user, check the check box to "Save password in vault", and click "OK".

![CreateNewMySqlUser9](Images\CreateNewMySqlUser9.png)

If the connection succeeded, you will see a dialog box like the one below.

![CreateNewMySqlUser10](Images\CreateNewMySqlUser10.png)

## Reference

[MySQL Workbench Manual](https://dev.mysql.com/doc/workbench/en/)&mdash;Oracle

---

These instructions were written by Brian Bird, 2024

---