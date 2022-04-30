-- Criar solução
dotnet new sln
-- Criar projecto webapi
dotnet new webapi -o API
-- adicionar projecto a solução
dotnet sln add API
-- listar todos os projectos da solução
dotnet sln list

-- Abrir o visual studio com a solução
code .

cd API
-- Abrir o browser com o projeto webapi
dotnet watch run ou dotnet run

-- Adicionar ao projecto caso seja sqlite
Microsoft.entityframeworkcore
Microsoft.entityframeworkcore.sqlite
Microsoft.entityframeworkcore.design


-- criar projecto do tipo classlib
dotnet new classlib -o Core
dotnet new classlib -o Infrastructure

-- Adicionar o projeto core a solução
dotnet sln add Core
dotnet sln add Infrastructure

cd API
-- Adicionar a referencia do projecto Infrastructure ao projeto API
dotnet add reference ../Infrastructure

cd Infrastructure
-- Adicionar a referencia do projecto Core ao projeto Infrastructure
dotnet add reference ../Core

dotnet restore

-- Criar as classes para inicializar a base de dados
dotnet ef migrations add InitialCreate -o Migrations
-- Criar a base de dados
dotnet ef database update

dotnet tool install --global dotnet-ef
PS C:\Users\mjsan\Documents\Microservices.Tests> dotnet ef migrations add InitialCreate -p Infrastructure -s API -o Data/Migrations
cd API
dotnet ef database update

-- Base de dados Identity
PS C:\Users\mjsan\Documents\Microservices.Tests> dotnet ef migrations add IdentityInitial -p Infrastructure -s API -c AppIdentityContext -o Identity/Migrations

-- Base de dados AdventureWorksContext
PS C:\Users\mjsan\Documents\Microservices.Tests> dotnet ef migrations add IdentityInitial -p Infrastructure -s API -c AdventureWorksContext -o Data/AdventureWorks/Migrations
PS C:\Users\mjsan\Documents\Microservices.Tests\API> dotnet ef database update -c AdventureWorksContext

dotnet dev-certs https
dotnet dev-certs https -t







