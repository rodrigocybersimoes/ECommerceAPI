using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models;

public partial class ItemPedido
{
    public int IditemPedido { get; set; }

    public int? Quantidade { get; set; }

    public int? Idproduto { get; set; }

    public int? Idpedido { get; set; }

    public virtual Pedido? IdpedidoNavigation { get; set; }

    public virtual Produto? IdprodutoNavigation { get; set; }
}
