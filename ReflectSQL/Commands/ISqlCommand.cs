using System;

namespace ReflectSQL.Commands
{
    internal interface ISqlCommand
    {
        string GenerateSql(Type classType);
    }
}
