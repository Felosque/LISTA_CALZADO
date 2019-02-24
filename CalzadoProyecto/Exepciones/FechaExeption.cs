using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalzadoProyecto.Exepciones
{
    class FechaExeption : Exception
    {
        private String msg;

        public FechaExeption(string message)
        {
            msg = message;
            Console.WriteLine(msg);
        }

        public String darExepcion()
        {
            return msg;
        }
    }
}
