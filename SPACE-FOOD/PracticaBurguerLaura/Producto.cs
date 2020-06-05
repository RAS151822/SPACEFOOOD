using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaBurguerLaura
{
    public class Producto
    {
        //ATRIBUTOS Producto

        private String id_producto;
        private String nombreproducto;
        private String tamanio;
        private int cantidad;
        private double precio;

        public Producto()
        {
        }

        public Producto(string id_producto, string nombreproducto, string tamanio, int cantidad, double precio)
        {
            this.id_producto = id_producto;
            this.nombreproducto = nombreproducto;
            this.tamanio = tamanio;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public string Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombreproducto { get => nombreproducto; set => nombreproducto = value; }
        public string Tamanio { get => tamanio; set => tamanio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }

        public void  MostrarProducto()
        {
            Console.WriteLine("id_producto: " + id_producto);
            Console.WriteLine("nombreproducto: " + nombreproducto);
            Console.WriteLine("tamanio: " + tamanio);
            Console.WriteLine("cantidad: " + cantidad);
            Console.WriteLine("precio: " + precio);

        }


    }
}
