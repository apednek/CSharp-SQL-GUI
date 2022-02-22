# CSharp-SQL-GUI

## Pre-requisites
    1. Visual Studio
    2. Microsoft SQL Server Management Studio 18
    
## Steps to run application
1. Download or clone the repository.
2. Open 'Microsoft SQL Server Management Studio 18'. Select authentication as "Windows Authentication" and click on 'Connect'.
3. In the Object-Explorer right click on 'Databases' and click 'Import Data-tier Application'. When the popup window opens navigate where it asks to 'Specify the BACPAC to import'. In here import from local disk and navigate to 'temperatureDB.bacpac' inside the cloned repository. Click next till it finishes.
4. Next navigate to Hitachi-Energy-2/App.config and open it. Search for the 'Data Source' parameter and replace <YOUR-SERVER-NAME> with your SQL Server Name.
5. Next open the Hitachi-Energy-2.sln file in Visual Studio.
6. From the Server Explorer tab refresh the Data Connections folder.
7. Click on 'Start' to run the application.


## About
- The database is pre-loaded with few values for City, State, Temperature.
- Enter the City, State, Temperature in the form. 
- Click Save.
- Click Load
- The application plots the temperatures of the cities entered in the database.
- The values entered in the form are stored in the 'temperatureDB' database inside 'TempStatistics' table which can be seen in Microsoft SQL Server Management Studio by writing a new select query in it. 
