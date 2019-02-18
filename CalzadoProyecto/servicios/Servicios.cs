using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalzadoProyecto.servicios
{
    class Servicios
    {
        private Calzado cabecera;


        public void adicionarCalzadoAlInicio(Calzado pCalzado)
        {
            if(cabecera == null){
                cabecera = pCalzado;
            }
            else{
                pCalzado.cambiarSiguiente(cabecera);
                cabecera = pCalzado;
            }
        }

        public void adicionarCalzadoAlFinal(Calzado pCalzado)
        {
            if (cabecera == null){
                cabecera = pCalzado;
            }
            else{
                darUltimoCalzado().cambiarSiguiente(pCalzado);
            }
        }

        public void adicionarCalzadoEnMedio(Calzado pCalzado, int pNumero)
        {
            Calzado recorrido = cabecera;
            Boolean salir = false;
            for(int i = 1; i == pNumero - 1 && !salir && cabecera != null; i++)
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

        public Calzado darUltimoCalzado()
        {
            Calzado recorrido = cabecera;
            while(recorrido.darSiguiente() != null){
                recorrido = recorrido.darSiguiente();
            }
            return recorrido;
        }

    }
}
