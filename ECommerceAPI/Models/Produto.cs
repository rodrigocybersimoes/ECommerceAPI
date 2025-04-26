using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ECommerceAPI.Models;

public partial class Produto
{
    public int Idproduto { get; set; }

    public string? NomeProduto { get; set; }

    public string? Descricao { get; set; }

    public decimal? Preco { get; set; }

    public int? EstoqueDisponivel { get; set; }

    public string? CategoriaProduto { get; set; }

    public string? Imagem { get; set; }

    [JsonIgnore]
    public virtual ICollection<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();

}
