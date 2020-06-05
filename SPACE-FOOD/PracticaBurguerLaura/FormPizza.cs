using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaBurguerLaura
{
    public partial class FormPizza : Form
    {
        int contador_pedidos;


        private String id_producto;
        private String nombreproducto;
        private String tamanio;
        private int cantidad;
        private double precio;

        public FormPizza()
        {
            InitializeComponent();
            TamañoSpagueti.CheckOnClick = true;
        }

        private void buttonNEXT_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHotDog());
        }

        private void openChildForm(Form childForm)
        {

            //activeForm.Close();


            if (childForm != null)
            {
                Console.WriteLine("Entra3");


                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel1.Controls.Add(childForm);
                panel1.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuAmericano());
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            contador_pedidos++;
            labelContador.Text = Convert.ToString(contador_pedidos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contador_pedidos > 0)
            {
                contador_pedidos--;
                labelContador.Text = Convert.ToString(contador_pedidos);
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            //VARIABLES MENSAJES ERROS Y CONFIRMACION

            DialogResult mensajeerror = new DialogResult();
            DialogResult resultado = new DialogResult();

            /*
            Console.WriteLine(tamanio);
            Console.WriteLine(cantidad);
            */


            //COMPROBAR QUE TODOS LOS CAMPOS ESTEN COMPLETADOS NO SE PERMITEN ESPACIOS EN BLANCO
            if (tamanio == "Small" || tamanio == "Medium" || tamanio == "Big")
            {
                //ASIGNAMOS LA CANTIDAD PARA SABER SI SE HA PULSADO O NO
                cantidad = contador_pedidos;

                if (cantidad > 0)//COMPROBAMOS..
                {


                    //AQUI CREAMOS EL OBJETO PLATO Y ALMACENAMOS EN EL ARRAY
                    id_producto = "MP11";
                    nombreproducto = "Marte Pizza";
                    precio = 10;


                    Producto nuevo = new Producto(id_producto, nombreproducto, tamanio, cantidad, precio);

                    Carrito.Insertar_Plato(nuevo);



                    //MOSTRAMOS MENSAJE DE QUE EL PEDIDO SE HA REALIZADO EXITOSAMENTE
                    Form mensajepedidoconfirmado = new MessajeboxPedidoRealizado();
                    resultado = mensajepedidoconfirmado.ShowDialog();

                }
                else
                {

                    Form mensajeerrorcamposvacios = new Error_Empty_Fields();
                    mensajeerror = mensajeerrorcamposvacios.ShowDialog();

                }
            }
            else
            {

                Form mensajeerrorcamposvacios = new Error_Empty_Fields();
                mensajeerror = mensajeerrorcamposvacios.ShowDialog();

            }
        }

        private void TamañoSpagueti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TamañoSpagueti.GetItemChecked(0) == true)
            {

                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamanio = "Small";
                //Console.WriteLine(tamanio);

            }

            if (TamañoSpagueti.GetItemChecked(1) == true)
            {
                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamanio = "Medium";
                //Console.WriteLine(tamanio);
            }

            if (TamañoSpagueti.GetItemChecked(2) == true)
            {
                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamanio = "Big";
                //Console.WriteLine(tamanio);
            }
        }
    }
}
