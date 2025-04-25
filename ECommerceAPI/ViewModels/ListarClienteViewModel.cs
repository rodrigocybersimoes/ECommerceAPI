namespace ECommerceAPI.ViewModels
{
    public class ListarClienteViewModel
    {
        public int Idcliente { get; set; }

        public string? NomeCompleto { get; set; }

        public string? Email { get; set; }

        public string? Telefone { get; set; }

        public string? Endereco { get; set; }

        public DateOnly? DataCadastro { get; set; }
    }
}
