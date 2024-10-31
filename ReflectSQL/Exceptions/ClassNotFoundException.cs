using System;

namespace ReflectSQL.Exceptions
{
    internal class ClassNotFoundException : Exception
    {
        public ClassNotFoundException() : base("Clase no encontrada en el ensamblado.")
        {

        }
    }
}
