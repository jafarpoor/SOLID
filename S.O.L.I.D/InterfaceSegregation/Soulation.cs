using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.I
{
    internal class Soulation
    {
        public interface IDatabaseManager
        {
            void Add();
            void Remove(int id);
            void Persisit();
        }

        public interface IDbBatchOperations : IDatabaseManager
        {
            void RemoveBatch(params int[] ids);
        }
    }
}
