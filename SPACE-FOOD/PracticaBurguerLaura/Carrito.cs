using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaBurguerLaura
{
    static public class Carrito
    {

        static public Producto[] Comida { set; get; }
        static public int Total_dimension_comida = 0;
        static public Producto[] Bebida { set; get; }
        static public int Total_dimension_bebida = 0;
        static public Producto[] Postre { set; get; }
        static public int Total_dimension_postre = 0;
        static public Producto[] TotalPedido { set; get; }
        static public int Total_dimension_pedido = 0;

        static public void Inicializar_Peido() {

            Comida = new Producto[Total_dimension_comida];
            Bebida = new Producto[Total_dimension_bebida];
            Postre = new Producto[Total_dimension_postre];
            TotalPedido = new Producto[Total_dimension_pedido];
        }

        //RESIZES AUMENTAR ARRAYS OBJETOS
/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        //RESIZEAUMCOMIDA
        static public void Resize_Aum_Comida()
        {
            int nueva_dim = Total_dimension_comida +1;
            Producto[] nuevo_vector = new Producto[nueva_dim];

            //Console.WriteLine(nueva_dim);

            //Copio el contenido del vector de comentarios actual en el nuevo vector.
            for (int i = 0; i < Total_dimension_comida; i++)
            {

                    
                    nuevo_vector[i] = Comida[i];
            }
            

            Comida = nuevo_vector;//Guardo el nuevo vector en el vector de comentarios que contiene el objet

            Total_dimension_comida = nueva_dim;
            nueva_dim = 0;

        }

        //RESIZEAUMBEBIDA
        static public void Resize_Aum_Bebida()
        {
            int nueva_dim = Total_dimension_bebida + 1;
            Producto[] nuevo_vector = new Producto[nueva_dim];


            //Copio el contenido del vector de comentarios actual en el nuevo vector.
            for (int i = 0; i < Total_dimension_bebida; i++)
            {

                //cout << DEBUG << "Entra bUCKLE RESIZE " <<  RESTORE << endl;
                nuevo_vector[i] = Bebida[i];
            }

            Bebida = nuevo_vector;//Guardo el nuevo vector en el vector de comentarios que contiene el objet

            Total_dimension_bebida = nueva_dim;
            nueva_dim = 0;

        }

        //RESIZEAUMPOSTRE
        static public void Resize_Aum_Postre()
        {
            int nueva_dim = Total_dimension_postre + 1;
            Producto[] nuevo_vector = new Producto[nueva_dim];


            //Copio el contenido del vector de comentarios actual en el nuevo vector.
            for (int i = 0; i < Total_dimension_postre; i++)
            {

                //cout << DEBUG << "Entra bUCKLE RESIZE " <<  RESTORE << endl;
                nuevo_vector[i] = Postre[i];
            }

            Postre = nuevo_vector;//Guardo el nuevo vector en el vector de comentarios que contiene el objet

            Total_dimension_postre = nueva_dim;
            nueva_dim = 0;

        }

        //RESIZEAUMPOSTRE
        static public void Resize_Aum_Pedido()
        {
            int nueva_dim = Total_dimension_pedido + 1;
            Producto[] nuevo_vector = new Producto[nueva_dim];


            //Copio el contenido del vector de comentarios actual en el nuevo vector.
            for (int i = 0; i < Total_dimension_pedido; i++)
            {

                //cout << DEBUG << "Entra bUCKLE RESIZE " <<  RESTORE << endl;
                nuevo_vector[i] = TotalPedido[i];
            }

            TotalPedido = nuevo_vector;//Guardo el nuevo vector en el vector de comentarios que contiene el objet

            Total_dimension_pedido = nueva_dim;
            nueva_dim = 0;

        }

//RESIZESS DISMINUIR ARRAY
/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //RESIZEDISMCOMIDA
        static public void Resize_Dism_Comida()
        {
            int nueva_dim = Total_dimension_comida-1;
            Producto[] nuevo_vector = new Producto[nueva_dim];


            //Copio el contenido del vector de comentarios actual en el nuevo vector.
            for (int i = 0; i < nueva_dim; i++)
            {
                nuevo_vector[i] = Comida[i];
            }


            Comida = nuevo_vector;//Guardo el nuevo vector en el vector de comentarios que contiene el objet

            Total_dimension_comida = nueva_dim;
            nueva_dim = 0;

        }

    
        //RESIZEDISMBEBIDA
        static public void Resize_Dism_Bebida()
        {
            int nueva_dim = Total_dimension_bebida - 1;
            Producto[] nuevo_vector = new Producto[nueva_dim];


            //Copio el contenido del vector de comentarios actual en el nuevo vector.
            for (int i = 0; i < nueva_dim; i++)
            {
                nuevo_vector[i] = Bebida[i];
            }

            Comida = nuevo_vector;//Guardo el nuevo vector en el vector de comentarios que contiene el objet

            Total_dimension_bebida = nueva_dim;
            nueva_dim = 0;

        }

        //RESIZEDISMPOSTRES
        static public void Resize_Dism_Postre()
        {
            int nueva_dim = Total_dimension_postre - 1;
            Producto[] nuevo_vector = new Producto[nueva_dim];


            //Copio el contenido del vector de comentarios actual en el nuevo vector.
            for (int i = 0; i < nueva_dim; i++)
            {
                nuevo_vector[i] = Postre[i];
            }





            Postre = nuevo_vector;//Guardo el nuevo vector en el vector de comentarios que contiene el objet

            Total_dimension_postre = nueva_dim;
            nueva_dim = 0;

        }

        //RESIZEDISMPOSTRES
        static public void Resize_Dism_Pedido()
        {
            int nueva_dim = Total_dimension_pedido - 1;
            Producto[] nuevo_vector = new Producto[nueva_dim];


            //Copio el contenido del vector de comentarios actual en el nuevo vector.
            for (int i = 0; i < nueva_dim; i++)
            {
                nuevo_vector[i] = TotalPedido[i];
            }





            TotalPedido = nuevo_vector;//Guardo el nuevo vector en el vector de comentarios que contiene el objet

            Total_dimension_pedido = nueva_dim;
            nueva_dim = 0;

        }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //INSERTAR COMIDA CARRITO

        static public void Insertar_Plato(Producto n) {

            Resize_Aum_Comida();
            Comida[Total_dimension_comida -1] = n;
            

        }

        //INSERTAR BEBIDA CARRITO
        static public void Insertar_Bebida(Producto n)
        {
                Resize_Aum_Bebida();
                Bebida[Total_dimension_bebida -1] = n;
               
        }

        //INSERTAR POSTRE CARRITO
        static public void Insertar_Postre(Producto n)
        {
            Resize_Aum_Postre();
            Postre[Total_dimension_postre - 1] = n;

        }

        //INSERTAR PRODUCTO TOTAL PEDIDOS
        static public void Insertar_Producto(Producto n)
        {
            Resize_Aum_Pedido();
            TotalPedido[Total_dimension_pedido - 1] = n;

        }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //ELIMINAR COMIDA
        static public int BuscarComida(string id)
        {
            bool encontrado = false;
            int posicion = 0;


            for (int i = 0; i < Total_dimension_comida && encontrado == false; i++)
            {

                if (Comida[i].Id_producto.Equals(id))
                {

                    encontrado = true;
                    posicion = i;
                }
            }

            return posicion;
        }

        static public void IntercambiarComida(int posicion)
        {

            Producto aux;
            //cout << "posicion" << posicion << endl;

            if (Total_dimension_comida > 2)
            {
                aux = Comida[Total_dimension_comida - 1];
                Comida[Total_dimension_comida - 1] = Comida[posicion];
                Comida[posicion] = aux;
            }

        }

        static public void EliminarComida(string id)
        {

            if (Total_dimension_comida > 0)
            {
                IntercambiarComida(BuscarComida(id));
                Resize_Dism_Comida();
            }
            else
            {
                
            }

        }

/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //ELIMINAR BEBIDA
        static public int BuscarBebida(string id)
        {
            bool encontrado = false;
            int posicion = 0;


            for (int i = 0; i < Total_dimension_bebida && encontrado == false; i++)
            {

                if (Bebida[i].Id_producto.Equals(id))
                {

                    encontrado = true;
                    posicion = i;
                }
            }

            return posicion;
        }

        static public void IntercambiarBebida(int posicion)
        {

            Producto aux;
            //cout << "posicion" << posicion << endl;

            if (Total_dimension_bebida > 2)
            {
                aux = Bebida[Total_dimension_bebida - 1];
                Bebida[Total_dimension_bebida - 1] = Comida[posicion];
                Bebida[posicion] = aux;
            }

        }

        static public void EliminarBebida(string id)
        {

            if (Total_dimension_bebida > 0)
            {
                IntercambiarBebida(BuscarBebida(id));
                Resize_Dism_Bebida();
            }
            else
            {

            }

        }

/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //ELIMINAR POSTRE
        static public int BuscarPostre(string id)
        {
            bool encontrado = false;
            int posicion = 0;


            for (int i = 0; i < Total_dimension_postre && encontrado == false; i++)
            {

                if (Postre[i].Id_producto.Equals(id))
                {

                    encontrado = true;
                    posicion = i;
                }
            }

            return posicion;
        }

        static public void IntercambiarPostre(int posicion)
        {

            Producto aux;
            //cout << "posicion" << posicion << endl;

            if (Total_dimension_postre > 2)
            {
                aux = Postre[Total_dimension_postre - 1];
                Postre[Total_dimension_postre - 1] = Postre[posicion];
                Postre[posicion] = aux;
            }

        }

        static public void EliminarPostre(string id)
        {

            if (Total_dimension_postre > 0)
            {
                IntercambiarPostre(BuscarPostre(id));
                Resize_Dism_Postre();
            }
            else
            {

            }

        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //ELIMINAR PEDIDO
        static public int BuscarPedido(string id)
        {
            bool encontrado = false;
            int posicion = 0;


            for (int i = 0; i < Total_dimension_pedido && encontrado == false; i++)
            {

                if (TotalPedido[i].Id_producto.Equals(id))
                {

                    encontrado = true;
                    posicion = i;
                }
            }

            return posicion;
        }

        static public void IntercambiarPedido(int posicion)
        {

            Producto aux;
            //cout << "posicion" << posicion << endl;

            if (Total_dimension_pedido > 2)
            {
                aux = TotalPedido[Total_dimension_pedido - 1];
                TotalPedido[Total_dimension_pedido - 1] = TotalPedido[posicion];
                TotalPedido[posicion] = aux;
            }

        }

        static public void EliminarPedido(string id)
        {

            if (Total_dimension_pedido > 0)
            {
                IntercambiarPedido(BuscarPedido(id));
                Resize_Dism_Pedido();
            }
            else
            {

            }

        }

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //MOSTAR LISTA COMIDA CARRITO
        static public void Mostrar_Pedido_Comida() {
        
            foreach (Producto n in Comida){
               
                n.MostrarProducto();
            }
        }

        //MOSTAR LISTA BEBIDA CARRITO
        static public void Mostrar_Pedido_Bebida()
        {

            foreach (Producto n in Bebida)
            {

                n.MostrarProducto();
            }
        }


        //MOSTAR LISTA POSTRE CARRITO
        static public void Mostrar_Pedido_Postre()
        {

            foreach (Producto n in Postre)
            {

                n.MostrarProducto();
            }
        }

        //MOSTAR LISTA PEDIDO CARRITO
        static public void Mostrar_Pedido_Total()
        {

            foreach (Producto n in TotalPedido)
            {

                n.MostrarProducto();
            }
        }
/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static public void SumarPedido()
        {


            if (Total_dimension_comida > 0)
            {
                for (int i = 0; i < Total_dimension_comida; i++)
                {

                    Insertar_Producto(Comida[i]);
                }
            }

            if (Total_dimension_bebida > 0)
            {
                for (int i = 0; i < Total_dimension_bebida; i++)
                {
                    Insertar_Producto(Bebida[i]);
                }
            }

            if (Total_dimension_postre > 0)
            {
                for (int i = 0; i < Total_dimension_postre; i++)
                {

                    Insertar_Producto(Postre[i]);
                }
            }

        }

        static public void EliminarPedido()
        {
            //Console.WriteLine(Total_dimension_pedido);

            for (int i = 0; i < Total_dimension_pedido; i++)
            {
                //Console.WriteLine(i);
                //Console.WriteLine(TotalPedido[i]);
                EliminarPedido(TotalPedido[i].Id_producto);
            }

        }

    }
   
}
