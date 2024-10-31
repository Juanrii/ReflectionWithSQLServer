using System;

namespace Entities.Attributes
{
    // Atributo personalizado
    [AttributeUsage(AttributeTargets.Property)]
    public class StringLengthAttribute : Attribute
    {
        public int Length { get; }

        public StringLengthAttribute(int length)
        {
            Length = length;
        }
    }
}
