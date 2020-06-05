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
    public partial class MenuOrders : Form
    {
        static int posicion = 0;
        private double TotalComida=0;
        private double TotalBebida = 0;
        private double TotalPostre = 0;

        public MenuOrders()
        {
            InitializeComponent();
            Carrito.SumarPedido();
            //Carrito.Mostrar_Pedido_Total();
            Inicializar_Pedido();
            CleanTotalPedido();

        }

        public void Inicializar_Pedido()
        {

            //dataGridComida.DataSource = Carrito.Comida;
            //dataGridBebida.DataSource = Carrito.Bebida;
            //dataGridPostre.DataSource = Carrito.Postre;
            dataGridPedido.ColumnCount = 4;
            dataGridPedido.Columns[0].Name = "Name";
            dataGridPedido.Columns[1].Name = "Quantity";
            dataGridPedido.Columns[2].Name = "Size";
            dataGridPedido.Columns[3].Name = "$";

            dataGridPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //CALCULO DEL PRECIO DE LOS PRODUCTOS TOTALES

            if (Carrito.Total_dimension_comida > 0)
            {
                for (int i = 0; i < Carrito.Total_dimension_comida; i++)
                {
                    TotalComida += Carrito.Comida[i].Precio * Carrito.Comida[i].Cantidad;
                }
            }

           
            if (Carrito.Total_dimension_bebida > 0)
            {
                for (int i = 0; i < Carrito.Total_dimension_bebida; i++)
                {
                    TotalBebida += Carrito.Bebida[i].Precio * Carrito.Bebida[i].Cantidad;
                }
            }

           


            if (Carrito.Total_dimension_postre > 0)
            {
                for (int i = 0; i < Carrito.Total_dimension_postre; i++)
                {

                   
                    TotalPostre = Carrito.Postre[i].Precio * Carrito.Postre[i].Cantidad;
                }
            }

            //IMPRIMO EN EL DATAGRIDVIEW 

           

            if (Carrito.Total_dimension_pedido > 0) {

                for(int i=0; i<Carrito.Total_dimension_pedido; i++)
                {
                    dataGridPedido.Rows.Add(Carrito.TotalPedido[i].Nombreproducto, Carrito.TotalPedido[i].Cantidad, Carrito.TotalPedido[i].Tamanio, Carrito.TotalPedido[i].Precio);
                }
                   
            }

            //AÑADO COLUMNA EN BLANCO COMO SEPARADORA Y OTRA CON EL TOTAL
            //dataGridPedido.Rows.Add("TOTAL FOOD:", TotalComida);
            //dataGridPedido.Rows.Add("TOTAL DRINK:", TotalBebida);
            //dataGridPedido.Rows.Add("TOTAL DESSERT:", TotalPostre);
            dataGridPedido.Rows.Add();
            dataGridPedido.Rows.Add("TOTAL:", TotalComida + TotalBebida + TotalPostre);

            
        }

       

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Dimension Pedido" + Carrito.Total_dimension_pedido);
            Console.WriteLine("Dimension Comida" + Carrito.Total_dimension_comida);

            if (Carrito.Total_dimension_pedido > 0) {
              
               //Carrito.Mostrar_Pedido_Total();

               int seleccion =  dataGridPedido.CurrentRow.Index ;
                

                Carrito.EliminarPedido(Carrito.TotalPedido[seleccion].Id_producto);
                dataGridPedido.Rows.Remove(dataGridPedido.CurrentRow);
                

            }

        }

        private void CleanTotalPedido()
        {

            if (Carrito.Total_dimension_pedido > 0)
            {
                for(int k=0; k < Carrito.Total_dimension_pedido;k++)
                {
                    //Console.WriteLine("Id_producto" + Carrito.TotalPedido[k].Id_producto);
                    Carrito.EliminarPedido(Carrito.TotalPedido[k].Id_producto);
                    
                }

            }

        }

        private void dataGridPedido_MouseClick(object sender, MouseEventArgs e)
        {
            posicion = dataGridPedido.CurrentRow.Index;
            Console.WriteLine(posicion);
        }
    }
}
