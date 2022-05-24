# UT-proj-Industrial-Informatics
C# Windows Form application for industrial informatics

The project should work out of the box when cloned on a local computer (at least we hope it does).

You must first run the `DB_Script.sql` file to create the database and fill it with some mockup data.

The only issues that might appear after restoring the database from `DB_Script.sql` are issues with the connection string. 
If there are any issues, please check if your SSMS Server Name is "(LocalDB)\MSSQLLocalDB". If not, you will need to replace "(LocalDB)\\MSSQLLocalDB" with your server name in the following files:
- App.config
- II_ProjectDataSet.Designer.cs

Beware! If your server name contains backslashes, you must escape them (i.e. use "\\", instead of a simple "\")

That should fix the database-related errors.
