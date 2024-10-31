using Entities.Attributes;
using ReflectSQL.Exceptions;
using ReflectSQL.Mappers;
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReflectSQL.Commands
{
    internal class CreateTableCommand : ISqlCommand
    {
        public string GenerateSql(Type classType)
        {
            string tableName = classType.Name;
            PropertyInfo[] properties = classType.GetProperties();

            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.AppendLine($"CREATE TABLE {tableName} (");

            var primaryKeyProp = properties.FirstOrDefault(p => p.GetCustomAttribute<PrimaryKeyAttribute>() != null);

            if (primaryKeyProp == null)
                throw new PrimaryKeyPropNotFound(tableName);

            string primaryKey = primaryKeyProp.Name;

            bool isFirstColumn = true;
            foreach (PropertyInfo prop in properties)
            {
                if (!isFirstColumn)
                    queryBuilder.AppendLine(",");

                string columnName = prop.Name;
                string sqlType = SqlTypeMapper.ConvertToSqlType(prop);

                string columnDefinition = columnName == primaryKey
                    ? $"{columnName} {sqlType} PRIMARY KEY IDENTITY(1,1)"
                    : $"{columnName} {sqlType}";

                queryBuilder.Append(columnDefinition);

                isFirstColumn = false;
            }

            queryBuilder.AppendLine(");");

            return queryBuilder.ToString();
        }
    }
}
