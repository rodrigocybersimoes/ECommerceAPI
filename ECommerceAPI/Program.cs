
//Essas tres linhas nunca podem ser apagadas para rodar a API
using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Repositories;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddSwaggerGen(); // DEPOIS QUE INSTALAR O SWASHEBUCKLE E SWASHEBUCLEUI

// O .NET vai criar os OBJETOS (Injecao de Dependencia)
// FORMAS DE CONFIGURAR:
    // 1. AddTransient - O C# cria uma instancia nova toda vez que um metodo e chamado.
    // 2. AddScoped - O C# cria uma instancia nova toda vez que criar um Controller.
    // 3. AddSingleton - 

builder.Services.AddScoped<EcommerceContext, EcommerceContext>();

//Injecao de dependencia
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IPagamentoRepository, PagamentoRepository>();
builder.Services.AddTransient<IItemPedidoRepository, ItemPedidoRepository>();
builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();


var app = builder.Build();

app.UseSwagger(); // ESCREVER DEPOIS QUE INSTALAR O SWASHEBUCKLE E SWASHEBUCLEUI

app.UseSwaggerUI(); // ESCREVER DEPOIS QUE INSTALAR O SWASHEBUCKLE E SWASHEBUCLEUI

app.MapControllers(); // ESCREVER DEPOIS QUE INSTALAR O SWASHEBUCKLE E SWASHEBUCLEUI

app.Run();

// Scaffold --> Transformar BD em codigos
// Migration --> Transformas Codigos em BD

// Instalando o dotnet-ef no terminal para fazer Scaffold e Migration: abrir o terminal e digitar dotnet tool install --global dotnet-ef --> Instala as ferramentas de terminal do Entity Framework

//Instala as ferramentas de terminal do Entity Framework (executar em um terminal)
//QUANDO ESTIVER USANDO O SQL SERVER
// PARA CRIAR AS PASTAS Context (REPRESENTACAO DO BANCO DE DADOS) e Models (ENTIDADES: COLUNAS DO BD):
//dotnet ef dbcontext scaffold "Data Source=NOME DO SERVIDOR DE SQL;Initial Catalog=NOME DO PROJETO EM SQL;User Id=USUARIO USADO NO SERVIDOR SQL;Password=SENHA DO SERVIDOR DE SQL;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer --context-dir Context --output-dir Models


//Caso de erro referente a design do Enitity, colocar essa linha dentro da pasta principal dando dois cliques nela
//GenerateRuntimeConfigurationFiles > True </ GenerateRuntimeConfigurationFiles >
// Ordem de criacao:
// 1. INTERFACE
// 2. REPOSITORY
// 3. CONTROLLER

// COMECANDO A FAZER O CRUD (CREATE; READ; UPDATE; DELETE) - IMPORTANTISSIMO SABER!!!!!!

// ORDEM UNIVERSAL PARA FAZER UMA API
// 1. CONTEXT E MODELS
// 2. INTERFACES
// 3. REPOSITORYS
// 4. CONTROLLERS

// METODO CONSTRUTOR E UM METODO QUE TEM O MESMO NOME DA CLASSE.

// O NAVEGADOR SO EXECUTA GET.

// SWAGGER - DOCUMENTACAO DE APIs QUE DA PRA TESTAR O QUE NAO E GET (COMO O POST, DELETE E UPDATE)

