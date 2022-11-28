*Paquetes para EntityFramwork a instalar con el nugetPackage (La version tiene que ser con la version que trabaje tu proyecto de .netcore)
-Microsoft.EntityFramworkCore 
-Microsoft.EntityFramworkCore.Tools
-Microsoft.EntityFramworkCore.Design
-Npgsql.EntityFramworkCore.PostgreSQL
*Cadena de conexion para el appsettings.json:
"ConectionDataBase": "Server=127.0.0.1;Database=DB_PPO;Port=5432;User Id=postgres; Password=Doteros.com1"
*Instalar dotnet tool en cmd admi
dotnet tool install --global dotnet-ef --version 5.0.0
Comando para crear la carpeta de migracion en el proyecto
dotnet ef migrations add MigrationPostgres --project NombreDelProyecto (WebService_PPO)
Comando para crear las tablas en Postgres
dotnet ef database update --project NombreDelProyecto (WebService_PPO)
