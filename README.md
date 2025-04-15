# PASSO A PASSO DA CRIAÇÃO DE UMA API

## 1. Criar um arquivo Interface na qual adiciona-se os métodos CRUD (importante se atentar que se deve escolher Interface no adicionar itens)
    ### Criação dos métodos a seguir:
        ### Listar;
        ### Buscar por ID;
        ### Cadastrar;
        ### Atualizar;
        ### Deletar.

## 2. Criar um arquivo Repository adicionando a herança entre o arquivo atual e o arquivo da Interface
        ### Criação do CRUD;
        ### Implementação do Contexto;
        ### Criação do Método Construtor;
        ### Implementação o método de listar;
        ### Implementação o método de cadastar
            #### Adicionar o método para salvar o dado.

## 3. No arquivo Program.cs, configurar a injeção de dependência

## 4. Criar o arquivo Controller
      ### Criação do Método Construtor;
      ### Implementar o [Http GET];
      ### Implementação do return com o verbo OK puxando todos os itens da lista no método ListarTodos;
      ### Implementação do Método IAction do método Cadastrar e adicionar o return com Created;
