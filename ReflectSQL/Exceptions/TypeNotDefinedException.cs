using System;
using System.Reflection;

namespace ReflectSQL.Exceptions
{
    internal class TypeNotDefinedException : Exception
    {
        public TypeNotDefinedException(PropertyInfo propiedad) : base($"No se encontró un tipo SQL asociado a la propiedad: {propiedad.Name}.")
        {

        }
    }
}
