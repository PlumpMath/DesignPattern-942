using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MysqlFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new MysqlDepartment();
        }
    }
}
