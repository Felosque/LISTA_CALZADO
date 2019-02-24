using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalzadoProyecto.Exepciones
{
    class MensajeExepcion : Exception
    {
        private String msg;

        public MensajeExepcion(String e)
        {
            msg = e;
        }

        public String darExepcion()
        {
            return msg;
        }

    }
}
