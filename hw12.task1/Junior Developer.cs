using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12.task1
{
    internal class Junior_Developer : Engineer
    {
        public override void Salary()
        {
            base.Salary();
            Console.WriteLine(salary);
        }
    }
}
