using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12.task1
{
    internal class Architect : Engineer
    {
        public override void Salary()
        {
            salary = salary*12 + 1000;
            Console.WriteLine(salary);
        }
    }
}
