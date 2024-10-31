using System;
using System.Collections.Generic;

namespace ReflectSQL.Commands
{
    internal class SqlCommandFactory
    {
        public static Dictionary<string, string> GenerateSqlCommands(Type classType)
        {
            return new Dictionary<string, string> {
                { "Insert", new InsertCommand().GenerateSql(classType) },
                { "Update", new UpdateCommand().GenerateSql(classType) },
                { "Delete", new DeleteCommand().GenerateSql(classType) },
                { "Select", new SelectCommand().GenerateSql(classType) },
                { "CreateTable", new CreateTableCommand().GenerateSql(classType) }
            };
        }
    }
}
