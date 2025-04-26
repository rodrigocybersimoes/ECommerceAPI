using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ECommerceAPI.Models;

public partial class ItemPedido
{
    public int IditemPedido { get; set; }

    public int? Quantidade { get; set; }

    public int? Idproduto { get; set; }

    public int? Idpedido { get; set; }
   
    [JsonIgnore]
    public virtual Pedido? IdpedidoNavigation { get; set; }

    public virtual Produto? IdprodutoNavigation { get; set; }
}
