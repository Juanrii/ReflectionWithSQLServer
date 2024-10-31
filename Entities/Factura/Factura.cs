using Entities.Attributes;
using System;

namespace Entities.Factura
{
    internal class Factura
    {
        #region Propiedades
        [PrimaryKey]
        public int FacturaId { get; set; }

        public DateTime FechaEmision { get; set; }

        public decimal MontoTotal { get; set; }

        [StringLength(150)]
        public string RazonSocial { get; set; }

        [StringLength(20)]
        public string NroFactura { get; set; }
        #endregion
    }
}
