using Entities.Attributes;
using System;

namespace Entities.Usuario
{
    internal class Usuario
    {
        #region Propiedades
        [PrimaryKey]
        public int Id { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellido { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Contrasena { get; set; }

        public DateTime FechaIngreso { get; set; }

        public bool Activo { get; set; }
        #endregion
    }
}
