using Entities.Attributes;
using ReflectSQL.Exceptions;
using System;
using System.Linq;
using System.Reflection;

namespace ReflectSQL.Commands
{
    internal class SelectCommand : ISqlCommand
    {
        public string GenerateSql(Type classType)
        {
            string tableName = classType.Name;
            PropertyInfo[] properties = classType.GetProperties();

            string columns = string.Join(", ", properties.Select(p => p.Name));

            var primaryKeyProp = properties.FirstOrDefault(p => p.GetCustomAttribute<PrimaryKeyAttribute>() != null);

            if (primaryKeyProp == null)
                throw new PrimaryKeyPropNotFound(tableName);

            string primaryKey = primaryKeyProp.Name;

            return $"SELECT {columns} FROM {tableName} WHERE {primaryKey} = @{primaryKey};";
        }
    }
}
