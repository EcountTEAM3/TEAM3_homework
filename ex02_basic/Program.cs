using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex03_Emplib;

namespace ex02_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Emp emp = new Emp(7788,"안재영",1000);
            Console.WriteLine(emp.GetHashCode());
            emp.EmpPring();
            Console.WriteLine(emp.Empno);
        }
    }
}
