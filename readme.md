﻿# HowTo- um Dotnet 4.8
11.07.2021


## 001-dotnet4xsimpleproject




## 002-dotnet4xsimpleoracleproject
* 2 [dotnet4xsimpleprojectNetCore ](https://github.com/alexanderfontana/howtodotnet4x/blob/master/002-dotnet4xsimpleoracleproject/readme.md)
einfaches Hallo World
Visual Studio->Neues Projekt -> dotnet Konsole->Version 4.8 ->fertig

Basierend auf einem Docker-Container, welcher OracleDB enthält.
Diese Verbidung hat Zugriff auf eine Tabelle: foo
foo hat eine Spalte id(int)
Einfacher Zugriff über Oracle-Treiber und den datareader

Oracle Infos:
https://github.com/oracle/dotnet-db-samples
https://www.oracle.com/tools/technologies/quickstart-dotnet-for-oracle-database.html#fourth-option-tab
Bei Oracle Account einrichten
Download
Open the downloaded zip file and extract the ODTforVS2019_193200.vsix file to a temporary location. Double click the vsix file to run the installer.
Install:
ODTforVS2019



Vorgehen:
1. Erweiterung installieren -> VS-> extension->hinzufügen :Oracle Developer Tools For Visual Studio

Install Oracle Developer Tools For Visual Studio
Install Visual Studio 2019 if you do not already have it.
Download Oracle Developer Tools for Visual Studio 19.3.2.
Open the downloaded zip file and extract the ODTforVS2019_193200.vsix file to a temporary location. Double click the vsix file to run the installer.
Once the installation is complete, launch Visual Studio 2019.
A dialog may appear stating that Oracle Developer Tools for Visual Studio
needs to perform additional configuration.
If it does, close Visual Studio then follow the prompts in the dialog. 
Once the dialog finishes, launch Visual Studio 2019 again.


2. der Oracle Treiber muss mit der hand in die Verweise dazu gefügt werden.
aus dem Package-Verzeichnis

https://docs.oracle.com/database/121/ODPNT/installODPmd.htm#ODPNT8149
Installing Oracle Data Provider for .NET, Managed Driver
You can get started with ODP.NET Managed Driver by either using the Oracle Universal Installer (OUI), XCopy, or NuGet.


Braucht 2 Nuget Pakete:
    <PackageReference Include="ODP.NetCore" Version="2.0.12" />
    <PackageReference Include="Oracle.ManagedDataAccess" Version="19.11.0" />
      <HintPath>packages\Oracle.ManagedDataAccess.19.11.0\lib\net40\Oracle.ManagedDataAccess.dll</HintPath>





ToDO
## 003-dotnet4xsimplemsoracleConnect
Oracle Zugriff mit MS Bordmitteln
https://docs.microsoft.com/de-de/dotnet/api/system.data.oracleclient?view=netframework-4.8
Alt und Oracle Client nötig.
  // System.Data.OracleClient erfordert version 8.1.7 oder höher der Oracle-Clientsoftware.
             




Just Access a Oracle Db- in Docker Container- with EF Core 
Model First = DBContext.CS written by Hand.
Model took and Tables will created by EFCore

## About
Without any other (Oracle) Client Software Installation.
No Dependency to TNSNames, 
No Dependency to ODBC DataSource.
Just Import an Access.


## NuGet
   2 Nuget Package need
* 1 [ODP.NetCore ](https://www.nuget.org/packages/ODP.NetCore/)
* 2 [Oracle Managed Access ](https://www.nuget.org/packages/Oracle.ManagedDataAccess.Core)
 

The Oracle Database must be available on Port 1521 with user dummy. Containing a Table name foo(id int) with 3 Rows in this table.


Press F5 to start
Time : 450 ms - 20.06.2021 

## Contributing
Just a howTo. Sorry

## License
[MIT](https://choosealicense.com/licenses/mit/)