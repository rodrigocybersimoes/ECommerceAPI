
//Essas tres linhas nunca podem ser apagadas para rodar a API
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run();

// Scaffold --> Transformar BD em codigos
// Migration --> Transformas Codigos em BD

// Instalando o dotnet-ef no terminal para fazer Scaffold e Migration: abrir o terminal e digitar dotnet tool install --global dotnet-ef --> Instala as ferramentas de terminal do Entity Framework

//Instala as ferramentas de terminal do Entity Framework (executar em um terminal)
//QUANDO ESTIVER USANDO O SQL SERVER
//dotnet ef dbcontext scaffold "Data Source=NOME DO SERVIDOR DE SQL;Initial Catalog=NOME DO PROJETO EM SQL;User Id=USUARIO USADO NO SERVIDOR SQL;Password=SENHA DO SERVIDOR DE SQL;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer --context-dir Context --output-dir Models


//Caso de erro referente a design do Enitity, colocar essa linha dentro da pasta principal dando dois cliques nela
//GenerateRuntimeConfigurationFiles > True </ GenerateRuntimeConfigurationFiles >