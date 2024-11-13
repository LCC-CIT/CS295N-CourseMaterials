<h1>How to Set Up a Local MySQL Database</h1>



These instructions assume you have installed a MySQL Server and MySQL Workbench.

### 1. Create a New User
1. Open MySQL Workbench and connect to your MySQL server using the root user.
2. Go to **Server** > **Users and Privileges**.
3. Click on **Add Account**.
4. Enter a username and password for the new user.
5. Set the account limits, roles, and schema privileges as needed.
6. Click **Apply** to create the new user.

### 2. Log In as the New User
1. Close the current session in MySQL Workbench.
2. Reconnect to the MySQL server using the new user credentials.

### 3. Connect to the Local MySQL Server
1. Click on the **+** button next to MySQL Connections in the home screen.
2. Enter a connection name, hostname (usually `localhost`), port (default is `3306`), username, and password.
3. Click **Store in Vault** to save the password securely.
4. Test the connection and click **OK** to establish it.

### 4. Create a New Database
1. Once connected, go to **Server** > **Data Import**.
2. Select **Import from Self-Contained Archive** and browse for the database file (if you have one) or **Import from Dump**.
3. Follow the prompts to create a new database.

### 5. Determine the ADO.NET Connection String
1. The ADO.NET connection string typically looks like this:
   ```plaintext
   Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
   ```
   Replace `myServerAddress`, `myDataBase`, `myUsername`, and `myPassword` with your actual server address, database name, username, and password.

## Reference

[MySQL Workbench Manual](https://dev.mysql.com/doc/workbench/en/)&mdash;Oracle

---

These instructions were written by Brian Bird using Microsoft Copilot with GPT-4.

---