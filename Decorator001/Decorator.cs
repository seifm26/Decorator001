using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator001
{
    public abstract class Decorator: IBakery
    {
        private readonly IBakery _bakery;
        protected string bake = "N/A";
        protected double price = -1;

        protected Decorator(IBakery bakery)
        {
            _bakery = bakery;
        }

        public virtual string Bake()
        {
            return _bakery.Bake() + "/" + bake;
        }

        public double GetPrice()
        {
            return _bakery.GetPrice() + price;
        }
    }
    public class Type1 : Decorator
    {
        public Type1(IBakery bakery) : base(bakery)
        {
            bake = "Type 1"; price = 1;
        }
    }
    public class Type2 : Decorator
    {
        private const string bakeType = "special baked";

        public Type2(IBakery bakery) : base(bakery)
        {
            bake = "Type 2"; price = 2;
        }

        public override string Bake()
        {
            return base.Bake() + bakeType;
        }
    }
}
