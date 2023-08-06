## Apply Database migrations

Run terminal in StarterKit.Blazor.WebAssembly.DataAccessLayer folder to execute following commands.

### Installing and updating Entity Framework Core tools
```powershell
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
```
#### Creating and Destroying Migrations

```powershell
dotnet ef migrations add MeaningfullName --startup-project ..\StarterKit.Blazor.WebAssembly.Server\StarterKit.Blazor.WebAssembly.Server.csproj
```

Will look at the current state of our model and generate migration for any changes from the previous migration.

```powershell
dotnet ef migrations remove MeaningfullName --startup-project ..\StarterKit.Blazor.WebAssembly.Server\StarterKit.Blazor.WebAssembly.Server.csproj
```

Will attempt to remove the migration from the project.

#### Applying Migrations to Database

```powershell
dotnet ef database update --startup-project ..\StarterKit.Blazor.WebAssembly.Server\StarterKit.Blazor.WebAssembly.Server.csproj
```

Will connect to the database and apply any migrations that have not already been applied.
