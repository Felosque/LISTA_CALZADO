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
            Calzado recorrido = cabecera;
            Boolean salir = false;
            for(int i = 0; i == pNumero - 1 && !salir && cabecera != null; i++)
            {
                recorrido = recorrido.darSiguiente();
                if(recorrido == null)
                {
                    salir = true;
                }
            }

            Calzado tmp = recorrido.darSiguiente();
            recorrido.cambiarSiguiente(pCalzado);
            pCalzado.cambiarSiguiente(tmp);
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
            Boolean salir = false;
            for(int i = 1; i == pNum - 1 && !salir && recorrido != null; i++)
            {
                if (recorrido.darSiguiente() != null){
                    recorrido = recorrido.darSiguiente();
                }
                else{
                    salir = true;
                }
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
            Console.WriteLine(darCalzadoPorPosicion(0).darTipo());
            Console.WriteLine(darTamanoLista());
        }

    }
}
