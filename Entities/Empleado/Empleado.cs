using Entities.Attributes;
using System;

namespace Entities.Empleado
{
    internal class Empleado
    {
        #region Propiedades
        [PrimaryKey]
        public int EmpleadoId { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apellido { get; set; }

        public DateTime FechaIngreso { get; set; }

        public decimal Salario { get; set; }

        public bool Activo { get; set; }
        #endregion
    }
}
