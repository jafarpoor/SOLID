using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.L
{
    internal class Soulation
    {
        public interface IList
        {
            void Add(object item);
        }

        public class CollectionBase
        {
            public int Count { get; set; }
        }

        public class List : CollectionBase, IList
        {
            public void Add(object item)
            {
                // add item to list
            }
        }

        public class Array : CollectionBase
        {
        }
    }
}
