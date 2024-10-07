Steps to run DB migrations:
1. install-package EntityFramework
2. dotnet tool install --global dotnet-ef
3. cd .\MSADBMigrations (If not present in the existing dir)
4. dotnet ef migrations add InitialMigration
5. dotnet ef database update