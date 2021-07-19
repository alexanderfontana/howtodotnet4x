
## 011-dotnet4xefModelFirst
Basierend auf einem Docker-Container, welcher OracleDB enthält.
Diese Verbindung ermöglicht Zugriff auf eine Tabelle: foo
die Tabelle foo hat eine Spalte id(int).
Das entscheidende ist die APP.Config mit den konfigurationseinstellungen für Oracle.


Model First:
https://docs.oracle.com/en/database/oracle/oracle-data-access-components/19.3/odpnt/entityCodeFirst.html#GUID-852AAB41-AFFA-4BDD-AC05-B5C771B3FCFE

Vorgehensweise
Dem Context Wurde die Klasse Personen hinzugefügt. (id int, vorname varchar(100))
Danach wurde das Model in die Datenbank übertragen. Danach existierten die Tabelle in Oracle.

1. Paket-Manager Konsole
Enable-Migrations 
Das Verzeichnis Migrations wurde durch dieses Komando angelegt.


2. Add-Migration mig1
Update-Database in the Package Manager Console
Die Dateien 
202107181948340_mig1.cs
202107181948340_mig1.resx
wurden durch dieses Komando angelegt.
In 202107181948340_mig1.cs wurde das Kommando zum erzeugen der Tabelle Foo ausgeremt. 
Es bleibt das Kommando um erzeugen der Tabelle Personen

Message:
>>The Designer Code for this migration file includes a snapshot of your current Code First model. 
>>This snapshot is used to calculate the changes to your model when you scaffold the next migration. 
>>If you make additional changes to your model that you want to include in this migration,
>>>then you can re-scaffold it by running 'Add-Migration mig1' again.

3. Update-Database

Die Tabelle Personen wurde erzeugt und mit programm.cs wurde auf die Tabelle zugegriffen.



https://docs.oracle.com/cd/E56485_01/win.121/e55744/InstallEntityConfig.htm#ODPNT8266



       


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


