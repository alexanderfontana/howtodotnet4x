# HowTo- um Dotnet 4.8
11.07.2021


## 01 dotnet4xsimpleproject
einfaches Hallo World
Visual Studio->Neues Projekt -> dotnet Konsole->Version 4.8 ->fertig



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