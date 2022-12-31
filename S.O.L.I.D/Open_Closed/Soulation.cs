using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.O
{
    internal class Soulation
    {
        public class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public virtual double GetDiscount()
            {
                return 0;
            }
        }

        public class ProductType1 : Product
        {
            public override double GetDiscount()
            {
                return (Price / 100) * 10;
            }
        }

        public class ProductType2 : Product
        {
            public override double GetDiscount()
            {
                return (Price / 100) * 15;
            }
        }
    }
}
