using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator001
{
    public interface IBakery
    {
        string Bake();
        double GetPrice();
    }
    public class Cake : IBakery
    {
        public string Bake() { return "Cake baked"; }
        public double GetPrice() { return 2000; }
    }
    public class Bread : IBakery
    {
        public string Bake() { return "Bread baked"; }
        public double GetPrice() { return 100; }
    }
}
