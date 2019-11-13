using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Singleton
{
    public class Logging
    {
        private static Logging _logging;

        public static Logging GetInstance()
        {
            if(_logging == null)
            {
                _logging = new Logging();
            }

            return _logging;
        }
        private Logging()
        { }
    }
}
