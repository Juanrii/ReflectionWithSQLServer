using ReflectSQL.Commands;
using ReflectSQL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ReflectSQL
{
    public class ReflectionService
    {
        private static string _ensamblado = "Entities";

        private static Assembly _assembly = Assembly.Load(_ensamblado);

        public static List<string> ListarClases()
        {
            return _assembly.GetTypes().Where(t => t.IsClass && t.Namespace != "Entities.Attributes").Select(t => t.Name).ToList();
        }

        public static List<string> ListarPropiedades(string className)
        {
            Type classType = _assembly.GetType($"{_ensamblado}.{className}.{className}");

            if (classType == null)
                throw new ClassNotFoundException();

            return classType.GetProperties().Select(prop => $"{prop.PropertyType.Name} {prop.Name}").ToList();
        }

        public static Dictionary<string, string> GenerarSQL(string className)
        {
            Type classType = _assembly.GetType($"{_ensamblado}.{className}.{className}");

            if (classType == null)
                throw new ClassNotFoundException();

            return SqlCommandFactory.GenerateSqlCommands(classType);
        }
    }

}
