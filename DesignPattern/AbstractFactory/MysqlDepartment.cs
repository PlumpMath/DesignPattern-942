using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MysqlDepartment : IDepartment
    {
        public Department GetDepartment(string id)
        {
            Console.WriteLine("在Mysql中根据ID获取Department");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在Mysql中新增一个Department");
        }
    }
}
