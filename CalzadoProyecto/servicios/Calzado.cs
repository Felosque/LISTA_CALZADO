using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalzadoProyecto.servicios
{
    class Calzado
    {

        private String tipo;

        private int talla;

        private double precio;

        private DateTime fechaCompra;

        private Calzado sgte;

        public Calzado(String pTipo, int pTalla, double pPrecio, DateTime pFecha)
        {
            tipo = pTipo;
            talla = pTalla;
            precio = pPrecio;
            fechaCompra = pFecha;
            sgte = null;
        }

        public String darTipo()
        {
            return tipo;
        }

        public void cambiarTipo(String pTipo)
        {
            tipo = pTipo;
        }

        public int darTalla()
        {
            return talla;
        }

        public void cambiarTalla(int pTalla)
        {
            talla = pTalla;
        }

        public double darPrecio()
        {
            return precio;
        }

        public void cambiarPrecio(double pPrecio)
        {
            precio = pPrecio;
        }

        public DateTime darFechaDeCompra()
        {
            return fechaCompra;
        }

        public void cambiarFechaDeCompra(DateTime pFechaCompra)
        {
            fechaCompra = pFechaCompra;
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
