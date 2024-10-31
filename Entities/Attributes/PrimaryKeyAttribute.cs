using System;

namespace Entities.Attributes
{
    // Atributo personalizado
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKeyAttribute : Attribute
    {
    }
}
