using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.S
{
    internal class Soulation
    {
        FileLogger logger = new FileLogger();

        public void Add()
        {
            try
            {
                // add customer to database
            }
            catch (Exception ex)
            {
                logger.Log(ex.ToString());
            }
        }
    }
    public class FileLogger
    {
        public void Log(string content)
        {
            System.IO.File.WriteAllText("d:\\errors.txt", content);
        }
    }
}

