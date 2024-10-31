using Entities.Attributes;
using ReflectSQL.Exceptions;
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReflectSQL.Commands
{
    internal class UpdateCommand : ISqlCommand
    {
        public string GenerateSql(Type classType)
        {
            string tableName = classType.Name;
            PropertyInfo[] properties = classType.GetProperties();

            var primaryKeyProp = properties.FirstOrDefault(p => p.GetCustomAttribute<PrimaryKeyAttribute>() != null);

            if (primaryKeyProp == null)
                throw new PrimaryKeyPropNotFound(tableName);

            string primaryKey = primaryKeyProp.Name;

            var propertiesToUpdate = properties.Where(p => p.Name != primaryKey);
            string setClause = string.Join(", ", propertiesToUpdate.Select(p => $"{p.Name} = @{p.Name}"));

            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.AppendLine($"UPDATE {tableName} SET {setClause}");
            queryBuilder.AppendLine($"WHERE {primaryKey} = @{primaryKey};");

            return queryBuilder.ToString();
        }
    }
}
