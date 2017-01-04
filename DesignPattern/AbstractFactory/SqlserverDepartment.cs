using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SqlserverDepartment : IDepartment
    {
        public Department GetDepartment(string id)
        {
            Console.WriteLine("在SQL Server中根据ID获取单个Department");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在SQL Server中新增一个Department");
        }
    }
}
