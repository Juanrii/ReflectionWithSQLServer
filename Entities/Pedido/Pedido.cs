using Entities.Attributes;
using System;

namespace Entities.Pedido
{
    internal class Pedido
    {
        #region Propiedades

        [PrimaryKey]
        public int PedidoId { get; set; }

        public DateTime FechaPedido { get; set; }

        public int Cantidad { get; set; }

        public decimal Total { get; set; }

        [StringLength(255)]
        public string Cliente { get; set; }
        #endregion
    }
}
