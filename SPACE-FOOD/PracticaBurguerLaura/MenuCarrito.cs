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
    public partial class MenuCarrito : Form
    {
       

       

        public MenuCarrito()
        {
            InitializeComponent();

            Inicializar_Pedido_Comida();
            Inicializar_Pedido_Bebida();
            Inicializar_Pedido_Postre();
            //Carrito.Mostrar_Pedido_Postre();
            //Carrito.Mostrar_Pedido_Bebida();

        }

        //CREAR COLUMNAS Y CARGAR DATOS EN DATAGRIDVIEW

        public void Inicializar_Pedido_Comida()
        {

            //dataGridComida.DataSource = Carrito.Comida;
            //dataGridBebida.DataSource = Carrito.Bebida;
            //dataGridPostre.DataSource = Carrito.Postre;
            dataGridComida.ColumnCount = 4;
            dataGridComida.Columns[0].Name = "Name";
            dataGridComida.Columns[1].Name = "Quantity";
            dataGridComida.Columns[2].Name = "Size";
            dataGridComida.Columns[3].Name = "$";

            dataGridComida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            if (Carrito.Total_dimension_comida > 0)
            {
                for (int i = 0; i < Carrito.Total_dimension_comida; i++)
                {

                    dataGridComida.Rows.Add(Carrito.Comida[i].Nombreproducto, Carrito.Comida[i].Cantidad, Carrito.Comida[i].Tamanio, Carrito.Comida[i].Precio);
                    
                }
            }

        }

        public void Inicializar_Pedido_Bebida()
        {

            //dataGridComida.DataSource = Carrito.Comida;
            //dataGridBebida.DataSource = Carrito.Bebida;
            //dataGridPostre.DataSource = Carrito.Postre;
            dataGridBebida.ColumnCount = 4;
            dataGridBebida.Columns[0].Name = "Name";
            dataGridBebida.Columns[1].Name = "Quantity";
            dataGridBebida.Columns[2].Name = "Size";
            dataGridBebida.Columns[3].Name = "$";

            dataGridBebida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            if (Carrito.Total_dimension_bebida > 0)
            {
                for (int i = 0; i < Carrito.Total_dimension_bebida; i++)
                {

                    dataGridBebida.Rows.Add(Carrito.Bebida[i].Nombreproducto, Carrito.Bebida[i].Cantidad, Carrito.Bebida[i].Tamanio, Carrito.Bebida[i].Precio);

                }
            }

        }

        public void Inicializar_Pedido_Postre()
        {

            //dataGridComida.DataSource = Carrito.Comida;
            //dataGridBebida.DataSource = Carrito.Bebida;
            //dataGridPostre.DataSource = Carrito.Postre;
            dataGridPostre.ColumnCount = 4;
            dataGridPostre.Columns[0].Name = "Name";
            dataGridPostre.Columns[1].Name = "Quantity";
            dataGridPostre.Columns[2].Name = "Size";
            dataGridPostre.Columns[3].Name = "$";

            dataGridPostre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            if (Carrito.Total_dimension_postre > 0)
            {
                for (int i = 0; i < Carrito.Total_dimension_postre; i++)
                {

                    dataGridPostre.Rows.Add(Carrito.Postre[i].Nombreproducto, Carrito.Postre[i].Cantidad, Carrito.Postre[i].Tamanio, Carrito.Postre[i].Precio);

                }
            }

        }

        ///////////////////////METODO PARA ABRIR LOS FORMS DE CADA MENU

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



       
        private void BottonPagar_Click_1(object sender, EventArgs e)
        {
            openChildForm(new MenuOrders());
        }
    }    
}
