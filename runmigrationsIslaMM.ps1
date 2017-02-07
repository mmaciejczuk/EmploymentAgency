#C:\Users\Edyta\Source\Repos\Isla\Isla\packages\FluentMigrator.1.6.2\tools\Migrate.exe -a C:\Users\Edyta\Source\Repos\Isla\Isla\Isla.Data.Migrations\bin\Debug\Isla.Data.Migrations.dll -db SqlServer2014 -conn "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Isla;Integrated Security=True;" -t migrate:up -verbose=true

#C:\Users\PrzemekS\Source\Repos\Isla\Isla\packages\FluentMigrator.1.6.2\tools\Migrate.exe -a C:\Users\PrzemekS\Source\Repos\Isla\Isla\Isla.Data.Migrations\bin\Debug\Isla.Data.Migrations.dll -db SqlServer2014 -conn "Data Source=DESKTOP-NM0I8FH\MSSQLSERVER2016;Initial Catalog=IslaDB;Integrated Security=True;" -t migrate:up -profile "Development" -verbose=true
#$fluentMigratorPath = "D:\Git\Isla\Isla\packages\FluentMigrator.1.6.2\tools\Migrate.exe";
#$projectLocation ="D:\Git\Isla\Isla\Isla.Data.Migrations" 

function BuildProject([string]$projectName, [string]$projectLocation, [string]$configuration)
{
    [string]$projectFile = [string]::Format("{0}.csproj", $projectName);
        
    MSBuild ([System.IO.Path]::Combine($projectLocation, $projectFile)) ([string]::Format("/p:Configuration={0}", $configuration));
    
    if($LastExitCode -ne 0)
    {
        break;
    }
}

function Migrate([string]$migrateMode, [string]$migratorPath, [string]$dbType, [string]$connectionString, [string]$projectName, [string]$projectLocation, [string]$configuration)
{    
    $targetDll = [string]::Format("{0}.dll", $projectName);
    $targetDllPath = [System.IO.Path]::Combine($projectLocation, "Bin", $configuration, $targetDll);        
    &$migratorPath -a $targetDllPath -db $dbType -conn $connectionString -t $migrateMode -verbose=true;
}

function MigrateWithProfile([string]$migrateMode, [string]$migratorPath, [string]$dbType, [string]$connectionString, [string]$projectName, [string]$projectLocation, [string]$configuration, [string]$profileName)
{
    $targetDll = [string]::Format("{0}.dll", $projectName);
    $targetDllPath = [System.IO.Path]::Combine($projectLocation, "Bin", $configuration, $targetDll);        
    &$migratorPath -a $targetDllPath -db $dbType -conn $connectionString -t $migrateMode -profile $profileName -verbose=true;
}

function MigrateUp([string]$migratorPath, [string]$dbType, [string]$connectionString, [string]$projectName, [string]$projectLocation, [string]$configuration)
{
   # BuildProject $projectName $projectLocation $configuration;
    Migrate "migrate:up" $migratorPath $dbType $connectionString $projectName $projectLocation $configuration       
}

function MigrateDown([string]$migratorPath, [string]$dbType, [string]$connectionString, [string]$projectName, [string]$projectLocation, [string]$configuration)
{
    #BuildProject $projectName $projectLocation $configuration;
    Migrate "migrate:down" $migratorPath $dbType $connectionString $projectName $projectLocation $configuration
}

function ReCreateWithProfile([string]$migratorPath, [string]$dbType, [string]$connectionString, [string]$projectName, [string]$projectLocation, [string]$configuration, [string]$profileName)
{
    #BuildProject $projectName $projectLocation $configuration;
    Migrate "migrate:down" $migratorPath $dbType $connectionString $projectName $projectLocation $configuration
    MigrateWithProfile "migrate:up" $migratorPath $dbType $connectionString $projectName $projectLocation $configuration $profileName
}

$databaseType = "SqlServer2014"
$connectionString="Data Source=localhost;initial catalog=Isla;Integrated Security=True;";
#$connectionString="Data Source=isla-db-server.database.windows.net,1433;Initial Catalog=IslaUnitTests;User ID=IslaDbUser;Password=qPbsk23z;";
$buildConfiguration = "Debug";
$projectName = "Isla.Data.Migrations"; 
$fluentMigratorPath = "D:\code\Isla_front_end\Isla\packages\FluentMigrator.1.6.2\tools\Migrate.exe";
$projectLocation ="D:\code\Isla_front_end\Isla\Isla.Data.Migrations" 


#MigrateDown $fluentMigratorPath $databaseType $connectionString $projectName $projectLocation $buildConfiguration
#MigrateUp $fluentMigratorPath $databaseType $connectionString $projectName $projectLocation $buildConfiguration
#ReCreateWithProfile $fluentMigratorPath $databaseType $connectionString $projectName $projectLocation $buildConfiguration "Development"