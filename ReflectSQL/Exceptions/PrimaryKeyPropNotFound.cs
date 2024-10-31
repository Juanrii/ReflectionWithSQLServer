using System;

namespace ReflectSQL.Exceptions
{
    internal class PrimaryKeyPropNotFound : Exception
    {
        public PrimaryKeyPropNotFound(string clase) : base($"No se encontró una clave primaria en la clase: {clase}.")
        {
            
        }
    }
}
