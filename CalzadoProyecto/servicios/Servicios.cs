using CalzadoProyecto.Exepciones;
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
            if (cabecera != null)
            {
                Calzado recorrido = buscarCalzadoPorPosicion(pNumero);
                Calzado tmp = recorrido.darSiguiente();
                recorrido.cambiarSiguiente(pCalzado);
                pCalzado.cambiarSiguiente(tmp);
            }
            else
            {
                throw new MensajeExepcion("¡La lista de calzado esta vacía!\n\nPrimero debe insertar uno en el inicio para poder adicionar en el medio");
            }
        }

        public static void eliminarCalzadoAlInicio()
        {
            if(cabecera != null)
            {
                cabecera = cabecera.darSiguiente();
            }
            else
            {
                throw new MensajeExepcion("¡La lista de calzado esta vacía!\n\nPrimero debe insertar para poder eliminar al inicio.");
            }
        }

        public static void eliminarCalzadoEnMedio(int pNum)
        {
            if (cabecera != null)
            {
                Calzado eliminar = buscarCalzadoPorPosicion(pNum);
                Calzado tmp = buscarCalzadoPorPosicion(pNum - 1);
                tmp.cambiarSiguiente(eliminar.darSiguiente());
                eliminar.cambiarSiguiente(null);
            }
            else
            {
                throw new MensajeExepcion("¡La lista de calzado esta vacía!\n\nPrimero debe insertar para poder eliminar al final.");
            }
        }

        public static void eliminarCalzadoFinal()
        {
            if (cabecera != null)
            {
                if(cabecera.darSiguiente() == null)
                {
                    cabecera = null;
                }
                Calzado eliminar = buscarCalzadoPorPosicion(darTamanoLista() - 2);
                eliminar.cambiarSiguiente(null);
            }
            else
            {
                throw new MensajeExepcion("¡La lista de calzado esta vacía!\n\nPrimero debe insertar para poder eliminar al final.");
            }
        }

        public static Calzado darUltimoCalzado()
        {
            Calzado recorrido = cabecera;
            if (recorrido != null)
            {
                while (recorrido.darSiguiente() != null && recorrido != null)
                {
                    recorrido = recorrido.darSiguiente();
                }
            }
            else
            {
                throw new MensajeExepcion("¡La lista de calzado esta vacía!\n\nPrimero debe insertar para poder ver el ultimo calzado.");
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

        public static Calzado buscarCalzadoPorPosicion(int pNum)
        {
            Calzado recorrido = cabecera;
            while(recorrido != null && pNum > 0)
            {
                recorrido = recorrido.darSiguiente();
                pNum--;
            }
            if(recorrido == null)
            {
                throw new MensajeExepcion("¡No se pudo encontrar el calzado en la posición especificada!");
            }
            return recorrido;
        }

        public static Calzado buscarCalzadoPorTipo(string pTipo)
        {
            Calzado recorrido = cabecera;
            
            if (recorrido != null)
            {
                Boolean existe = false;
                while (recorrido != null && !existe)
                {
                    if (recorrido.darTipo().Equals(pTipo)){
                        existe = true;
                    }
                    else{
                        recorrido = recorrido.darSiguiente();
                    }
                }
            }
            else{
                throw new MensajeExepcion("¡La lista de calzado esta vacía!\n\nPrimero debe insertar para poder buscar algun calzado.");
            }
            if(recorrido == null)
            {
                throw new MensajeExepcion("¡No se pudo encontrar el calzado por el tipo asignado!");
            }
            return recorrido;
        }

        public static Calzado buscarCalzadoPorTalla(int pTalla)
        {
            Calzado recorrido = cabecera;

            if (recorrido != null)
            {
                Boolean existe = false;
                while (recorrido != null && !existe)
                {
                    if (recorrido.darTalla() == pTalla)
                    {
                        existe = true;
                    }
                    else
                    {
                        recorrido = recorrido.darSiguiente();
                    }
                }
            }
            else
            {
                throw new MensajeExepcion("¡La lista de calzado esta vacía!\n\nPrimero debe insertar para poder buscar algun calzado.");
            }
            if (recorrido == null)
            {
                throw new MensajeExepcion("¡No se pudo encontrar el calzado por la talla asignada!");
            }
            return recorrido;
        }

        public static Calzado buscarCalzadoPorPrecio(int pPrecio)
        {
            Calzado recorrido = cabecera;

            if (recorrido != null)
            {
                Boolean existe = false;
                while (recorrido != null && !existe)
                {
                    if (recorrido.darPrecio() == pPrecio)
                    {
                        existe = true;
                    }
                    else
                    {
                        recorrido = recorrido.darSiguiente();
                    }
                }
            }
            else
            {
                throw new MensajeExepcion("¡La lista de calzado esta vacía!\n\nPrimero debe insertar para poder buscar algun calzado.");
            }
            if (recorrido == null)
            {
                throw new MensajeExepcion("¡No se pudo encontrar el calzado por la precio asignado!");
            }
            return recorrido;
        }

        public static Calzado buscarCalzadoPorFecha(DateTime pFecha)
        {
            Calzado recorrido = cabecera;

            if (recorrido != null)
            {
                Boolean existe = false;
                while (recorrido != null && !existe)
                {
                    if (recorrido.darFechaDeCompra().Day == pFecha.Day && 
                        recorrido.darFechaDeCompra().Month == pFecha.Month
                        && recorrido.darFechaDeCompra().Year == pFecha.Year)
                    {
                        existe = true;
                    }
                    else
                    {
                        recorrido = recorrido.darSiguiente();
                    }
                }
            }
            else
            {
                throw new MensajeExepcion("¡La lista de calzado esta vacía!\n\nPrimero debe insertar para poder buscar algun calzado.");
            }
            if (recorrido == null)
            {
                throw new MensajeExepcion("¡No se pudo encontrar el calzado por la fecha asignada!");
            }
            return recorrido;
        }

        public static void modificarCalzados(Calzado CalzadoModificar, Calzado pCalzado)
        {
            CalzadoModificar.cambiarFechaDeCompra(pCalzado.darFechaDeCompra());
            CalzadoModificar.cambiarPrecio(pCalzado.darPrecio());
            CalzadoModificar.cambiarTalla(pCalzado.darTalla());
            CalzadoModificar.cambiarTipo(pCalzado.darTipo());
        }

        public static void verCalzados()
        {
            Calzado recorrido = cabecera;
            while (recorrido != null)
            {
                Console.WriteLine("Tipo: " + recorrido.darTipo() + " Talla: " + recorrido.darTalla() + " Precio: " + recorrido.darPrecio() + " Fecha: " + recorrido.darFechaDeCompra());
                recorrido = recorrido.darSiguiente();
            }
        }

    }
}
