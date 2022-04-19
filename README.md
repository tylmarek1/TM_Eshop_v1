Stažení:

+ https://visualstudio.microsoft.com/cs/
Visual Studio Comunity 2022

+ https://www.microsoft.com/en-us/sql-server/sql-server-downloads
SQL Server Express

+ https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15
SQL Server Managment Studio

_____________

Instalace:

+ Visual Studio + rozšíření
> Vývoj pro ASP.NET a web

+ SQL Server Express
> Basic

+ SQL Server Managment Studio

_____________

Další postup:

+ Po otevření projektu může nastat chyba v NuGetPackage Manageru (chybí mu složka)
&rarr; vytvořit nový projekt (Blazor WebAssembly) a pak ho smazat

+ Potom naistalovat Entity Framework ve Visual Studiu v Package Manager Console \(Tools \> NuGet Package Manager \> Package Manager Console\)
> PM\> dotnet tool install \-\-global dotnet\-ef

+ Potom stáhnou a nahrát databázy ve SQLSMS \(pravím tlačítkem na databases \> Import Data\-tier Application... \)
> EshopDB_v1.bacpac
