using Entities.Attributes;

namespace Entities.Cliente
{
    internal class Cliente
    {
        #region Propiedades
        [PrimaryKey]
        public int Id { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apellido { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Telefono { get; set; }

        public bool Activo { get; set; }
        #endregion
    }
}
