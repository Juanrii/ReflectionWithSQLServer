using Entities.Attributes;
using ReflectSQL.Exceptions;
using System;
using System.Reflection;

namespace ReflectSQL.Mappers
{
    internal static class SqlTypeMapper
    {
        public const string IntType = "INT";
        public const string BoolType = "BIT";
        public const string DateTimeType = "DATETIME";
        public const string DecimalType = "DECIMAL(18, 2)";
        public const string FloatType = "FLOAT";

        public static string ConvertToSqlType(PropertyInfo prop)
        {
            Type type = prop.PropertyType;
            int stringLength = 255;

            var stringLengthAttr = prop.GetCustomAttribute<StringLengthAttribute>();

            if (stringLengthAttr != null)
                stringLength = stringLengthAttr.Length;

            if (type == typeof(int)) return IntType;
            if (type == typeof(bool)) return BoolType;
            if (type == typeof(DateTime)) return DateTimeType;
            if (type == typeof(decimal)) return DecimalType;
            if (type == typeof(double)) return FloatType;
            if (type == typeof(string)) return $"VARCHAR({stringLength})";

            throw new TypeNotDefinedException(prop);
        }
    }
}
