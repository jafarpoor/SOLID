using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.O
{
    internal class Wrong
    {
        public int ProductType { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }

        public double GetDiscount()
        {
            if (ProductType == 1)
            {
                return (Price / 100) * 5;
            }
            if (ProductType == 2)
            {
                return (Price / 100) * 10;
            }
            if (ProductType == 3)
            {
                return (Price / 100) * 15;
            }
            return 0;
        }
    }
}
