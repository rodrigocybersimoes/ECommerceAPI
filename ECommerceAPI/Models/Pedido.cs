using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ECommerceAPI.Models;

public partial class Pedido
{
    public int Idpedido { get; set; }

    public DateOnly? DataPedido { get; set; }

    public string? Status { get; set; }

    public decimal? ValorTotal { get; set; }

    public int? Idcliente { get; set; }

    public int? Idproduto { get; set; }

    public virtual Cliente? IdclienteNavigation { get; set; }

    public virtual ICollection<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();

    [JsonIgnore]
    public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}
