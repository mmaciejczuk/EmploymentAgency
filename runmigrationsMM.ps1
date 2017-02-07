#Author; Mariusz Maciejczuk
#Wykonuje migracjê.

function Log($text){
    echo ("[INFO]****** {0}" -f $text)
}

#####Parametry konfiguracyjne#####
#kierunek migracji: up/down.
$Direction = "migrate:up"
#$Direction = "rollback:toversion --version 24407"

#connection string do bazy danych, podany jawnie, lub jego nazwa z pliku .config
#$Conn = "Data Source=.;Initial Catalog=Repository.Models.EAContext;Integrated Security=True"
$Conn = "data source=localhost;initial catalog=Repository.Models.EAContext;Integrated Security=True"

#Tagi
$Tag = ""

#Dodatkowy profil migracji do wykonania na koniec: Dev/Test/Prod
$Profile = ""

#konfiguracja msbuild'a: Relese/Debug/...
$Configuration = "Debug"

#œcie¿ka do folderu z projektem migracji.
$ProjectFolder = "D:\code\EmploymentAgency\EmploymentAgency.Migrations"

#œcie¿ka do pliku Migrator.exe.
$MigratorPath = "D:\code\EmploymentAgency\packages\FluentMigrator.1.6.2\tools\Migrate.exe"

#œcie¿ka do pliku .csproj projektu z migracjami.
$ProjectPath = "D:\code\EmploymentAgency\EmploymentAgency.Migrations\EmploymentAgency.Migrations.csproj"

#silnik bazodanowy : sqlserver2000/sqlserver2005/sqlserver2008/sqlserver2012/sqlserverce/sqlserver/mysql/postgres/oracle/sqlite/jet
$DatabaseEngine = "SqlServer2014"

$dll = "EmploymentAgency.Migrations.dll"

#####Skrypt#####
cls
Log("Building migrations project...")
C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe $ProjectPath /v:m /nologo /p:Configuration=$Configuration
Log("Starting migration...")
$Params = ("-a {0}\bin\{1}\{2} -db {3} -conn '{4}' -t {5} --profile '{6}' --workingdirectory {7}\Bin\{8}\Sql {9}" -f $ProjectFolder, $Configuration, $dll, $DatabaseEngine, $Conn, $Direction, $Profile, $ProjectFolder, $Configuration, $Tag)
Log("Migration parameters...")
echo $params
Invoke-Expression ("{0} {1}" -f $MigratorPath, $Params)