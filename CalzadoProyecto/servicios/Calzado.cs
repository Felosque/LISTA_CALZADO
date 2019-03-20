using CalzadoProyecto.Exepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalzadoProyecto.servicios
{
    class Calzado
    {
        private String estado;

        private String tipo;

        private int talla;

        private int id;

        private double precio;

        private DateTime fechaCompra;

        private Calzado sgte;

        public Calzado(int pId, String pTipo, int pTalla, double pPrecio, DateTime pFecha, String pEstado)
        {
            cambiarTipo(pTipo);
            cambiarTalla(pTalla);
            cambiarPrecio(pPrecio);
            cambiarFechaDeCompra(pFecha);
            estado = pEstado;
            id = pId;
            sgte = null;
        }

        public String darTipo()
        {
            return tipo;
        }

        public void cambiarEstado(String pEstado)
        {
            estado = pEstado;
        }

        public String darEstado()
        {
            return estado;
        }

        public void cambiarId(int pIde)
        {
            id = pIde;
        }

        public int darId()
        {
            return id;
        }

        public void cambiarTipo(String pTipo)
        {
            if (pTipo != null && pTipo.Length != 0)
            {
                tipo = pTipo;
            }
            else{
                throw new MensajeExepcion("¡Debe haber algún tipo de calzado especificado!");
            }
        }

        public int darTalla()
        {
            return talla;
        }

        public void cambiarTalla(int pTalla)
        {
            if(pTalla >= 20 && pTalla <= 50)
            {
                talla = pTalla;
            }
            else
            {
                throw new MensajeExepcion("¡La talla no puede ser mayor a 50 y menor a 20!");
            }
            
        }

        public double darPrecio()
        {
            return precio;
        }

        public void cambiarPrecio(double pPrecio)
        {
            if (pPrecio >= 1 && pPrecio <= 100000000)
            {
                precio = pPrecio;
            }
            else
            {
                throw new MensajeExepcion("¡El precio del calzado debe ser coherente!");
            }
        }

        public DateTime darFechaDeCompra()
        {
            return fechaCompra;
        }

        public void cambiarFechaDeCompra(DateTime pFechaCompra)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine("L: " + localDate.ToString() + " - F:" + localDate.ToString());
            if (pFechaCompra.CompareTo(localDate) <= 0)
            {
                fechaCompra = pFechaCompra;
            }
            else
            {
                throw new FechaExeption("¡No se puede comprar un calzado un día después al de hoy!");
            }
        }

        public Calzado darSiguiente()
        {
            return sgte;
        }

        public void cambiarSiguiente(Calzado pSgte)
        {
            sgte = pSgte;
        }

    }
}
