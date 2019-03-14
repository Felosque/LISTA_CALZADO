using CalzadoProyecto.Exepciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalzadoProyecto.servicios
{
    class Servicios
    {
        private static Calzado cabecera;

        private static String rutaArchivo = "";

        public static Calzado darCabecera()
        {
            return cabecera;
        }
        
        public static String darPath()
        {
            return rutaArchivo;
        }

        public static void cambiarPath(String pPath)
        {
            rutaArchivo = pPath;
        }

        /**
         * SISTEMA DE LISTA DE CALZADO
         */
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


        /**
         * SISTEMA DE ARCHIVOS DEL CALZADO
         */

        public static void guardarCalzados(String pRuta)
        {

            if (pRuta != null && pRuta.Length != 0)
            {
                Calzado recorrido = cabecera;
                if (recorrido != null)
                {
                    FileStream archivo;
                    archivo = new FileStream(pRuta, FileMode.Append);
                    BinaryWriter br = new BinaryWriter(archivo, Encoding.UTF8);

                    while (recorrido != null)
                    {
                        br.Write(recorrido.darTipo());
                        br.Write(recorrido.darPrecio());
                        br.Write(recorrido.darTalla());
                        br.Write(Convert.ToString(recorrido.darFechaDeCompra()));
                        br.Write(recorrido.darEstado());
                        recorrido = recorrido.darSiguiente();
                    }

                    br.Close();
                    archivo.Close();
                }
                else
                {
                    throw new MensajeExepcion("¡La lista de calzado esta vacía!\n\nPrimero debe insertar para poder ver el ultimo calzado.");
                }
                
            }
            else
            {
                throw new MensajeExepcion("No se selecciono ningún archivo.");
            }
        }

        public static void adicionarCalzadoArchivo(Calzado pCalzado) {

            FileStream archivo;
            archivo = new FileStream(darPath(), FileMode.Append);
            BinaryWriter br = new BinaryWriter(archivo, Encoding.UTF8);

            br.Write(pCalzado.darTipo());
            br.Write(pCalzado.darPrecio());
            br.Write(pCalzado.darTalla());
            br.Write(Convert.ToString(pCalzado.darFechaDeCompra()));
            br.Write(pCalzado.darEstado());

            br.Close();
            archivo.Close();

        }

        public static ArrayList leerCalzadoArchivo(String pRuta)
        {
            if (pRuta != null && pRuta.Length != 0)
            {
                int talla;
                double precio;
                String tipo, estado, fecha, cad = "";
                ArrayList calzados = new ArrayList();

                FileStream archivo;
                BinaryReader binaryReader;
                archivo = new FileStream(pRuta, FileMode.Open);
                binaryReader = new BinaryReader(archivo, Encoding.UTF8);

                while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
                {
                    tipo = binaryReader.ReadString();
                    precio = binaryReader.ReadDouble();
                    talla = binaryReader.ReadInt32();
                    fecha = binaryReader.ReadString();
                    estado = binaryReader.ReadString();
                    if (estado != Constantes.ELIMINADO)
                    {
                        cad = cad + Environment.NewLine + tipo + " , " + precio + " , " + talla + " , " + fecha + " , " + estado + ".";
                        calzados.Add(new Calzado(tipo, talla, precio, DateTime.Parse(fecha), estado));
                    }
                }

                binaryReader.Close();
                archivo.Close();
                Console.WriteLine(cad);
                return calzados;
            }
            else
            {
                throw new MensajeExepcion("No se selecciono ningún archivo en el cual leer los calzados.");
            }
        }

        public static Calzado buscarEnAchivoPorPosicion(String pRuta, int pPosicion)
        {

            int talla = 0;
            double precio = 0.0;
            String tipo = "", estado = "", fecha = "", cad = "";
            Boolean noEncontro = false;
            Calzado nodoEncontrado = null;

            FileStream archivo;
            BinaryReader binaryReader;
            archivo = new FileStream(pRuta, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);

            for (int i = 1; i <= pPosicion + 1 && !noEncontro; i++)
            {
                if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
                {
                    tipo = binaryReader.ReadString();
                    precio = binaryReader.ReadDouble();
                    talla = binaryReader.ReadInt32();
                    fecha = binaryReader.ReadString();
                    estado = binaryReader.ReadString();
                    if(estado == Constantes.ELIMINADO || estado == Constantes.INACTIVO)
                    {
                        i--;
                    }
                }else
                {
                    noEncontro = true;
                    binaryReader.Close();
                    archivo.Close();
                    throw new MensajeExepcion("¡No existe el calzado especificado dentro del archivo!");
                }
            }

            if(noEncontro == false)
            {
                DateTime fechaF = DateTime.Parse(fecha);
                nodoEncontrado = new Calzado(tipo, talla, precio, fechaF, estado);
                Console.WriteLine("Fecha: " + nodoEncontrado.darFechaDeCompra());
            }

            binaryReader.Close();
            archivo.Close();
            Console.WriteLine(cad);
            return nodoEncontrado;
        }

        public static Calzado buscarEnAchivoPorTalla(String pRuta, int pTalla)
        {

            int talla = 0;
            double precio = 0.0;
            String tipo = "", estado = "", fecha = "";
            Boolean encontro = false;
            Calzado nodoEncontrado = null;

            FileStream archivo;
            BinaryReader binaryReader;
            archivo = new FileStream(pRuta, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);

            while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length && !encontro)
            {
                tipo = binaryReader.ReadString();
                precio = binaryReader.ReadDouble();
                talla = binaryReader.ReadInt32();
                fecha = binaryReader.ReadString();
                estado = binaryReader.ReadString();

                if (estado != Constantes.ELIMINADO)
                {
                    if (talla == pTalla)
                    {
                        encontro = true;
                    }
                }
            }

            if (encontro == true)
            {
                DateTime fechaF = DateTime.Parse(fecha);
                nodoEncontrado = new Calzado(tipo, talla, precio, fechaF, estado);
            }
            else
            {
                binaryReader.Close();
                archivo.Close();
                throw new MensajeExepcion("¡No se encontro el calzado por la talla especificada!");
            }

            binaryReader.Close();
            archivo.Close();

            return nodoEncontrado;
        }

        public static Calzado buscarEnAchivoPorTipo(String pRuta, String pTipo)
        {

            int talla = 0;
            double precio = 0.0;
            String tipo = "", estado = "", fecha = "";
            Boolean encontro = false;
            Calzado nodoEncontrado = null;

            FileStream archivo;
            BinaryReader binaryReader;
            archivo = new FileStream(pRuta, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);

            while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length && !encontro)
            {
                tipo = binaryReader.ReadString();
                precio = binaryReader.ReadDouble();
                talla = binaryReader.ReadInt32();
                fecha = binaryReader.ReadString();
                estado = binaryReader.ReadString();
                if (estado != Constantes.ELIMINADO)
                {
                    if (tipo == pTipo)
                    {
                        encontro = true;
                    }
                }
            }

            if (encontro == true)
            {
                DateTime fechaF = DateTime.Parse(fecha);
                nodoEncontrado = new Calzado(tipo, talla, precio, fechaF, estado);
            }
            else
            {
                binaryReader.Close();
                archivo.Close();
                throw new MensajeExepcion("¡No se encontro el calzado por el tipo especificado!");
            }

            binaryReader.Close();
            archivo.Close();

            return nodoEncontrado;
        }

        public static Calzado buscarEnAchivoPorPrecio(String pRuta, double pPrecio)
        {

            int talla = 0;
            double precio = 0.0;
            String tipo = "", estado = "", fecha = "";
            Boolean encontro = false;
            Calzado nodoEncontrado = null;

            FileStream archivo;
            BinaryReader binaryReader;
            archivo = new FileStream(pRuta, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);

            while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length && !encontro)
            {
                tipo = binaryReader.ReadString();
                precio = binaryReader.ReadDouble();
                talla = binaryReader.ReadInt32();
                fecha = binaryReader.ReadString();
                estado = binaryReader.ReadString();

                if (estado != Constantes.ELIMINADO)
                {
                    if (precio == pPrecio)
                    {
                        encontro = true;
                    }
                }
            }

            if (encontro == true)
            {
                DateTime fechaF = DateTime.Parse(fecha);
                nodoEncontrado = new Calzado(tipo, talla, precio, fechaF, estado);
            }
            else
            {
                binaryReader.Close();
                archivo.Close();
                throw new MensajeExepcion("¡No se encontro el calzado por el precio especificado!");
            }

            binaryReader.Close();
            archivo.Close();

            return nodoEncontrado;
        }

        public static Calzado buscarEnAchivoPorFecha(String pRuta, DateTime pFecha)
        {

            int talla = 0;
            double precio = 0.0;
            String tipo = "", estado = "";
            DateTime fecha = DateTime.Now;
            Boolean encontro = false;
            Calzado nodoEncontrado = null;

            FileStream archivo;
            BinaryReader binaryReader;
            archivo = new FileStream(pRuta, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);

            while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length && !encontro)
            {
                tipo = binaryReader.ReadString();
                precio = binaryReader.ReadDouble();
                talla = binaryReader.ReadInt32();
                fecha = DateTime.Parse(binaryReader.ReadString());
                
                estado = binaryReader.ReadString();

                if (estado != Constantes.ELIMINADO)
                {
                    if (fecha.Day == pFecha.Day && fecha.Month == pFecha.Month && fecha.Year == pFecha.Year)
                    {
                        encontro = true;
                    }
                }
            }

            if (encontro == true)
            {
                nodoEncontrado = new Calzado(tipo, talla, precio, fecha, estado);
            }
            else
            {
                binaryReader.Close();
                archivo.Close();
                throw new MensajeExepcion("¡No se encontro el calzado por la fecha especificada!");
            }

            binaryReader.Close();
            archivo.Close();

            return nodoEncontrado;
        }

    }
}
