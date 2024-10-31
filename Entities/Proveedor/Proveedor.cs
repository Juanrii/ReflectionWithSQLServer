using Entities.Attributes;
using System;

namespace Entities.Proveedor
{
    internal class Proveedor
    {
        #region Propiedades
        [PrimaryKey]
        public int ProveedorId { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Telefono { get; set; }

        public DateTime FechaRegistro { get; set; }

        public bool Activo { get; set; }
        #endregion
    }
}
