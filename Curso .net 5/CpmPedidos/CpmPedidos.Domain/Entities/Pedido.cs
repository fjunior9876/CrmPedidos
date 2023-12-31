﻿using CpmPedidos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain
{
    public class Pedido : BaseDomain
    {    
        public string Nunero { get; set; }
        public decimal ValorTotal { get; set; }

        public TimeSpan Entrega { get; set; }

        public int IdCliente { get; set; }  
        public virtual Cliente Cliente { get; set; }

        public virtual List<ProdutoPedido> Produtos { get; set; }
      
    }
}
