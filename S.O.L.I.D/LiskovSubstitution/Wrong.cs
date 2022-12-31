using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.L
{
    internal class Wrong
    {
        public class CollectionBase
        {
            public int Count { get; set; }

            public virtual void Add(object item)
            {

            }
        }

        public class List : CollectionBase
        {
            public override void Add(object item)
            {
                // add item to list
            }
        }

        public class Array : CollectionBase
        {
            //It is wrong Because Arry have static lenth and it cannot override function Add
            public override void Add(object item)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
