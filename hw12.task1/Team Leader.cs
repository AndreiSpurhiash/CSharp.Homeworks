using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12.task1
{
    internal class Team_Leader : Engineer
    {
        public override void Salary()
        {
            salary *= 8 + 500;
            Console.WriteLine(salary);
        }
    }
}
