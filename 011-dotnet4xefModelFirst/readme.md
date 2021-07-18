
## 011-dotnet4xefModelFirst
Basierend auf einem Docker-Container, welcher OracleDB enthält.
Diese Verbindung ermöglicht Zugriff auf eine Tabelle: foo
die Tabelle foo hat eine Spalte id(int)


https://docs.oracle.com/cd/E56485_01/win.121/e55744/InstallEntityConfig.htm#ODPNT8266



     string conString = "User Id=dummy;Password=dummy;Data Source=localhost:1521/ORCLCDB.localdomain";
       


Datenbankcontext in FooContext
using Oracle.ManagedDataAccess.EntityFramework;

Install-Package EntityFramework
Install-Package Oracle.ManagedDataAccess.EntityFramework -Version 19.7.0
Install-Package Z.EntityFramework.Extensions

Configdatei-Beispiel:
https://entityframework-extensions.net/oracle-provider


Oracle Beispiel:
https://www.oracle.com/webfolder/technetwork/tutorials/obe/db/dotnet/CodeFirst/index.html#section1




ConnectionString
ODP.NET, Managed Driver
<provider invariantName="Oracle.ManagedDataAccess.Client" 
type="Oracle.ManagedDataAccess.EntityFramework.EFOracleProviderServices
, Oracle.ManagedDataAccess.EntityFramework, Version=6.121.2.0, Culture=neutral, PublicKeyToken=89b483f429c47342" />


ODP.NET, Managed Driver

<provider invariantName="Oracle.ManagedDataAccess.Client" 
type="Oracle.ManagedDataAccess.EntityFramework.EFOracleProviderServices
, Oracle.ManagedDataAccess.EntityFr





https://docs.microsoft.com/de-de/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

