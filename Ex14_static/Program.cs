using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_static
{

    public class AirPlane
    {
        static int total;
        string airname;
        int airnum;

        public AirPlane(string airname, int airnum)
        {
            this.airname = airname;
            this.airnum = airnum;
            total++;
        }


        public void Air()
        {
            Console.WriteLine($"이름 : {this.airname}, 번호 : {this.airnum}");
        }

        public void Total_Count()
        {
           Console.WriteLine(total);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            AirPlane airplane = new AirPlane("아시아나", 37);
            AirPlane airplane1 = new AirPlane("아시아나", 55);
            AirPlane airplane2 = new AirPlane("아시아나", 65);
            airplane.Air();
            airplane1.Air();
            airplane2.Air();
            airplane2.Total_Count();

        }
    }
}
