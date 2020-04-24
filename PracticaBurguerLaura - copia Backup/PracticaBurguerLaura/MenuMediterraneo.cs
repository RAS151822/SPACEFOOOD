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
    public partial class MenuMediterraneo : Form
    {


        private int contador;

        //ATRIBUTOS PLATO

        private String nombreproducto;
        private String tamanio;
        private int cantidad;
        private double precio;




        public MenuMediterraneo()
        {
            InitializeComponent();

            //Modificamos la seleccion de un doble click a UN SOLO CLICK
            TamañoSpagueti.CheckOnClick = true;
            
        }

    

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //METODO PARA ABRIR LOS FORMS DE CADA MENU

        private void openChildForm(Form childForm)
        {
            
            //activeForm.Close();


            if (childForm != null)
            {
                //Console.WriteLine("Entra3");


                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel1.Controls.Add(childForm);
                panel1.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();


            }
        }

        private void buttonNEXT_Click(object sender, EventArgs e)
        {

        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {

        }

        private void buttonNEXT_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormOllica());

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonComprar_Click_1(object sender, EventArgs e)
        {
            contador++;
            labelContador.Text = Convert.ToString(contador);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRellenos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                contador--;
                labelContador.Text = Convert.ToString(contador);
            }

        }

        private void labelContador_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //METODOOS

        private void TamañoSpagueti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TamañoSpagueti.GetItemChecked(0) == true)
            {
                
                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamanio = "Small";
               // Console.WriteLine(tamanio);

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

        private void BuyButton_Click(object sender, EventArgs e)
        {
            //VARIABLES
            cantidad = contador;
            DialogResult mensajeerror = new DialogResult();
            DialogResult resultado = new DialogResult();

            /*
            Console.WriteLine(tamanio);
            Console.WriteLine(cantidad);
            */

            //COMPROBAR QUE TODOS LOS CAMPOS ESTEN COMPLETADOS NO SE PERMITEN ESPACIOS EN BLANCO
            if (tamanio == "Small" || tamanio == "Medium" || tamanio == "Big")
            {
                if (cantidad > 0)//MAS DE LO MISMO
                {
                    Form mensajepedidoconfirmado = new MessajeboxPedidoRealizado();
                    resultado = mensajepedidoconfirmado.ShowDialog();

                    //AQUI CREAMOS EL OBJETO PLATO Y ALMACENAMOS EN EL ARRAY
                    nombreproducto = "ASTRAL SPAGUETTI";
                    precio = 35;

                    Pedido nuevo = new Pedido(nombreproducto, tamanio, cantidad, precio);
                    

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
    }
}
