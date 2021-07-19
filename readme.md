# HowTo- um Dotnet 4.8
11.07.2021


## 001-dotnet4xsimpleproject
* 1 [dotnet4xsimpleproject ](https://github.com/alexanderfontana/howtodotnet4x/tree/master/001-dotnet4xsimpleproject)




## 002-dotnet4xsimpleoracleproject
* 2 [dotnet4xsimpleoracleproject](https://github.com/alexanderfontana/howtodotnet4x/blob/master/002-dotnet4xsimpleoracleproject)
Basierend auf einem Docker-Container,
Einfacher Zugriff über Oracle-Treiber und den datareader



## 003-dotnet4xsimplemsoracleConnect
* 3 [dotnet4xsimplemsoracleConnect](https://github.com/alexanderfontana/howtodotnet4x/tree/master/003-dotnet4xsimplemsoracleprojekt)

## 011-dotnet4xefModelFirst
* 11 [dotnet4xefModelFirst](https://github.com/alexanderfontana/howtodotnet4x/tree/master/011-dotnet4xefModelFirst)

https://docs.oracle.com/cd/E56485_01/win.121/e55744/InstallEntityConfig.htm#ODPNT8266
Zugriff auf ORACLE via Entity Framework 6 - Model First- ohne Oracle Client Installationen.



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