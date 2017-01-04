using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class DataAccess
    {
        private static readonly string AssemblyName= ConfigurationManager.AppSettings["程序集名称"];
        private static readonly string db = ConfigurationManager.AppSettings["DB"];

        public static IDepartment CreateDepartment()
        {
            //IDepartment result = null;
            //switch (db)
            //{
            //    case "Sqlserver":
            //        result = new SqlserverDepartment();
            //        break;
            //    case "Mysql":
            //        result = new MysqlDepartment();
            //        break; 
            //}
            //return result;

            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
