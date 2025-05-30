﻿using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models;

public partial class Pagamento
{
    public int Idpagamento { get; set; }

    public string? FormaPagamento { get; set; }

    public string? StatusPagamento { get; set; }

    public DateTime? DataPagamento { get; set; }

    public int? Idpedido { get; set; }


    //Quando escrever o navigation, seguir o padrao <nome da tabela> Id
    public virtual Pedido? IdpedidoNavigation { get; set; }
}
