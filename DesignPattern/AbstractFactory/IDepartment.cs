using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(string id);
    }
}
