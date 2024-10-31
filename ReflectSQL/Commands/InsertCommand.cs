using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReflectSQL.Commands
{
    internal class InsertCommand : ISqlCommand
    {
        public string GenerateSql(Type classType)
        {
            string tableName = classType.Name;

            PropertyInfo[] properties = classType.GetProperties();

            string columns = string.Join(", ", properties.Select(p => p.Name));
            string parameters = string.Join(", ", properties.Select(p => $"@{p.Name}"));

            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.AppendLine($"INSERT INTO {tableName} ({columns})");
            queryBuilder.AppendLine($"VALUES ({parameters});");

            return queryBuilder.ToString();
        }
    }
}
