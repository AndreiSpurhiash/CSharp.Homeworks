using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12.task1
{
    internal class Senior_Developer : Engineer
    {
        public override void Salary()
        {
            salary = salary*5 + 300;
            Console.WriteLine(salary);
        }
    }
}
