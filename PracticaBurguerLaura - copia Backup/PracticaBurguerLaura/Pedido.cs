using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaBurguerLaura
{
     class Pedido
    {
        //ATRIBUTOS

        private String nombreproducto;
        private String tamanio;
        private int cantidad;
        private double precio;

        //ARRAYS
        private ArrayList ArrayComida;

        public Pedido()
        {
        }

        //METODOS CONSTRUCTOR PARAMETROS

        public Pedido(string nombreproducto, string tamanio, int cantidad, double precio)
        {
            this.nombreproducto = nombreproducto;
            this.tamanio = tamanio;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        //METODOS COMIDA
        
        public void IniciarArrayComida()
        {
            ArrayComida = new ArrayList();
        }

        public void AñadirComida(Pedido nuevoplato)
        {
            ArrayComida.Add(nuevoplato);
        }

        public void ImprimirComida()
        {
            foreach (var Pedido in ArrayComida)
            {
                Console.WriteLine(Pedido);
            }
        }
    }
}
