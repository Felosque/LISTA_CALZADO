using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalzadoProyecto.servicios
{
    class Servicios
    {
        private static Calzado cabecera;


        public static Calzado darCabecera()
        {
            return cabecera;
        }

        public static void adicionarCalzadoAlInicio(Calzado pCalzado)
        {
            if(cabecera == null){
                cabecera = pCalzado;
            }
            else{
                pCalzado.cambiarSiguiente(cabecera);
                cabecera = pCalzado;
            }
        }

        public static void adicionarCalzadoAlFinal(Calzado pCalzado)
        {
            if (cabecera == null){
                cabecera = pCalzado;
            }
            else{
                darUltimoCalzado().cambiarSiguiente(pCalzado);
            }
        }

        public static void adicionarCalzadoEnMedio(Calzado pCalzado, int pNumero)
        {
            Calzado recorrido = darCalzadoPorPosicion(pNumero);
            Calzado tmp = recorrido.darSiguiente();
            recorrido.cambiarSiguiente(pCalzado);
            pCalzado.cambiarSiguiente(tmp);
        }

        public static void eliminarCalzadoAlInicio()
        {
            if(cabecera != null)
            {
                cabecera = cabecera.darSiguiente();
            }
        }

        public static void eliminarCalzadoEnMedio(int pNum)
        {
            Calzado eliminar = darCalzadoPorPosicion(pNum);
            Calzado tmp = darCalzadoPorPosicion(pNum - 1);
            tmp.cambiarSiguiente(eliminar.darSiguiente());
            eliminar.cambiarSiguiente(null);
        }

        public static void eliminarCalzadoFinal()
        {
            Calzado eliminar = darCalzadoPorPosicion(darTamanoLista() - 2);
            eliminar.cambiarSiguiente(null);
        }

        public static Calzado darUltimoCalzado()
        {
            Calzado recorrido = cabecera;
            while(recorrido.darSiguiente() != null && recorrido != null){
                recorrido = recorrido.darSiguiente();
            }
            return recorrido;
        }

        public static int darTamanoLista()
        {
            Calzado recorrido = cabecera;
            int sumatoria = 0;
            while (recorrido != null)
            {
                sumatoria++;
                recorrido = recorrido.darSiguiente();
            }
            return sumatoria;
        }

        public static Calzado darCalzadoPorPosicion(int pNum)
        {
            Calzado recorrido = cabecera;
            while(recorrido != null && pNum > 0)
            {
                recorrido = recorrido.darSiguiente();
                pNum--;
            }
            return recorrido;
        }

        public static void verCalzados()
        {
            Calzado recorrido = cabecera;
            while (recorrido != null)
            {
                Console.WriteLine("Tipo: " + recorrido.darTipo() + " Talla: " + recorrido.darTalla() + " Precio: " + recorrido.darPrecio() + " Fecha: " + recorrido.darFechaDeCompra());
                recorrido = recorrido.darSiguiente();
            }
            Console.WriteLine(darTamanoLista());
        }

    }
}
