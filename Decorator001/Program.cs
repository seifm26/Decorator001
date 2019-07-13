using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator001
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake cc1 = new Cake();
            Console.WriteLine(cc1.Bake() + " ," + cc1.GetPrice());

            Type1 cd1 = new Type1(cc1);
            Console.WriteLine(cd1.Bake() + " ," + cd1.GetPrice());

            Type2 cd2 = new Type2(cc1);
            Console.WriteLine(cd2.Bake() + " ," + cd2.GetPrice());
            Console.ReadKey();
        }
    }
}
