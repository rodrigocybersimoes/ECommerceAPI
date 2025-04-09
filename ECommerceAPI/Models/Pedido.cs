using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models;

public partial class Pedido
{
    public int Idpedido { get; set; }

    public DateOnly? DataPedido { get; set; }

    public string? Status { get; set; }

    public decimal? ValorTotal { get; set; }

    public int? Idcliente { get; set; }

    public virtual Cliente? IdclienteNavigation { get; set; }

    public virtual ICollection<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();

    public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}
