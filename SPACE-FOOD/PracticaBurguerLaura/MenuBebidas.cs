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
    public partial class MenuBebidas : Form
    {
        //Switchss Controlers
        int SodascaseSwitchDerech = 0;
        int SodascaseSwitchIzq = 0;

        int WaterscaseSwitchDerech = 0;
        int WaterscaseSwitchIzq = 0;

        int BeerscaseSwitchDerech = 0;
        int BeerscaseSwitchIzq = 0;

        //Contadores Refrescos, Aguas, Cervezas
        int contadorRefrescos = 0;
        int contadorAguas = 0;
        int contadorCervezas = 0;

        //Atributos carrito

        //REFESCOS
        private String id_refresco;
        private String nombrerefresco;
        private String tamaniorefresco;
        private int cantidadrefresco;
        private double preciorefresco;

        //AGUA
        private String id_agua;
        private String nombreagua;
        private String tamanioagua;
        private int cantidadagua;
        private double precioagua;

        //CERVEZAS
        private String id_cerveza;
        private String nombrecerveza;
        private String tamaniocerveza;
        private int cantidadcerveza;
        private double preciocerveza;


        public MenuBebidas()
        {
            InitializeComponent();

            //Ajustes FUNCIONALIDAD de un solo click sobre los botones
            TamañoRefrescos.CheckOnClick = true;
            TamañoAguas.CheckOnClick = true;
            TamañoCervezas.CheckOnClick = true;

            CustomiceBEBIDAS();

        }

        private void CustomiceBEBIDAS()
        {
            //REFRESCOS
            cocaColas1.Visible = true;
            cocaColaZero1.Visible = false;   
            colaLight1.Visible = false;
            fantaLimon1.Visible = false;
            fantaNaranja1.Visible = false;
            PrecioRefrescos.Text = "1.00";
            id_refresco = "CC01";
            nombrerefresco = "CocaCola";
            preciorefresco = 1.00;


            //Bebidas
            bezoya1.Visible = true;
            lanjaron1.Visible = false;
            PrecioAguas.Text = "2.50";
            id_agua = "AB01";
            nombreagua = "Agua Bezoya";
            precioagua = 2.50;

            //Cervezas
            tropical1.Visible = true;
            alhambra1.Visible = false;
            amstel1.Visible = false;
            turia1.Visible = false;
            PrecioCervezas.Text = "2.50";
            id_cerveza = "CT01";
            nombrecerveza = "Cerveza Tropical";
            preciocerveza = 2.50;

        }

        // REFRESCOS

        private void TamañoRefrescos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TamañoRefrescos.GetItemChecked(0) == true)
            {

                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamaniorefresco = "Small";
                //Console.WriteLine(tamanio);

            }

            if (TamañoRefrescos.GetItemChecked(1) == true)
            {
                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamaniorefresco = "Medium";
                //Console.WriteLine(tamanio);
            }

            if (TamañoRefrescos.GetItemChecked(2) == true)
            {
                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamaniorefresco = "Big";
                //Console.WriteLine(tamanio);
            }
        }


        private void SodasDerech_Click(object sender, EventArgs e)
        {
            SodascaseSwitchIzq = 0;
            ContadorRefrescos.Text = "0";
            contadorRefrescos = 0;




            if (SodascaseSwitchDerech == 5)
                SodascaseSwitchDerech = 0;

            SodascaseSwitchDerech++;

            switch (SodascaseSwitchDerech)
            {
                case 1:
                    cocaColas1.Visible = true;
                    cocaColas1.BringToFront();
                    PrecioRefrescos.Text = "1.00";
                    id_refresco = "CC01";
                    nombrerefresco = "CocaCola";
                    preciorefresco = 1.00;


                    ;
                    break;
                case 2:
                    cocaColaZero1.Visible = true;
                    cocaColaZero1.BringToFront();
                    PrecioRefrescos.Text = "1.50";
                    id_refresco = "CZ02";
                    nombrerefresco = "Cola Zero";
                    preciorefresco = 1.50;
                    ;
                    break;
                case 3:
                    colaLight1.Visible = true;
                    colaLight1.BringToFront();
                    PrecioRefrescos.Text = "1.50";
                    id_refresco = "CL03";
                    nombrerefresco = "Cola Light";
                    preciorefresco = 1.50;
                    ;
                    break;

                case 4:
                    fantaLimon1.Visible = true;
                    fantaLimon1.BringToFront();
                    PrecioRefrescos.Text = "1.00";
                    id_refresco = "FL04";
                    nombrerefresco = "Fanta Limon";
                    preciorefresco = 1.00;
                    ;
                    break;
                case 5:
                    fantaNaranja1.Visible = true;
                    fantaNaranja1.BringToFront();
                    PrecioRefrescos.Text = "1.00";
                    id_refresco = "FN05";
                    nombrerefresco = "Fanta Naranja";
                    preciorefresco = 1.00;
                    ;
                    break;


            }

            
        }

        private void SodasIzq_Click(object sender, EventArgs e)
        {
            //Cuando pulsamos la flecha izq la derecha queda reinicilizada
            SodascaseSwitchDerech = 0;
            //Contadores reseteados cada vez que pulsemos la flecha para cambiar entre refrescos
            ContadorRefrescos.Text = "0";
            contadorRefrescos = 0;



            if (SodascaseSwitchIzq == 5)
                SodascaseSwitchIzq = 0;

            SodascaseSwitchIzq++;

            switch (SodascaseSwitchIzq)
            {
                case 1:
                   
                    fantaNaranja1.Visible = true;
                    fantaNaranja1.BringToFront();
                    PrecioRefrescos.Text = "1.00";
                    id_refresco = "FN05";
                    nombrerefresco = "Fanta Naranja";
                    preciorefresco = 1.00;
                    ;
                    break;
                case 2:
                   
                    fantaLimon1.Visible = true;
                    fantaLimon1.BringToFront();
                    PrecioRefrescos.Text = "1.00";
                    id_refresco = "FL04";
                    nombrerefresco = "Fanta Limon";
                    preciorefresco = 1.00;
          
                    ;
                    break;
                case 3:
                    colaLight1.Visible = true;
                    colaLight1.BringToFront();
                    PrecioRefrescos.Text = "1.50";
                    id_refresco = "CL03";
                    nombrerefresco = "Cola Light";
                    preciorefresco = 1.50;

                    ;
                    break;

                case 4:
                    cocaColaZero1.Visible = true;
                    cocaColaZero1.BringToFront();
                    PrecioRefrescos.Text = "1.50";
                    id_refresco = "CZ02";
                    nombrerefresco = "Cola Zero";
                    preciorefresco = 1.50;
                    ;
                    break;
                case 5:
                    cocaColas1.Visible = true;
                    cocaColas1.BringToFront();
                    PrecioRefrescos.Text = "1.00";
                    id_refresco = "CC01";
                    nombrerefresco = "CocaCola";
                    preciorefresco = 1.00;
                    ;
                    break;


            }
        }
     
        private void SodasbuttonRestar_Click(object sender, EventArgs e)
        {
            if (contadorRefrescos > 0)
            {
                contadorRefrescos--;
                ContadorRefrescos.Text = Convert.ToString(contadorRefrescos);
            }
        }

        private void SodasbuttonSumar_Click(object sender, EventArgs e)
        {
            contadorRefrescos++;
            ContadorRefrescos.Text = Convert.ToString(contadorRefrescos);
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
            if (tamaniorefresco == "Small" || tamaniorefresco == "Medium" || tamaniorefresco == "Big")
            {
                //ASIGNAMOS LA CANTIDAD PARA SABER SI SE HA PULSADO O NO
                cantidadrefresco = contadorRefrescos;

                if (cantidadrefresco > 0)//COMPROBAMOS..
                {


                    //AQUI CREAMOS EL OBJETO PLATO Y ALMACENAMOS EN EL ARRAY


                    Producto nuevo = new Producto(id_refresco, nombrerefresco, tamaniorefresco, cantidadrefresco, preciorefresco);

                    Carrito.Insertar_Bebida(nuevo);



                    //MOSTRAMOS MENSAJE DE QUE EL PEDIDO SE HA REALIZADO EXITOSAMENTE
                    Form mensajepedidoconfirmado = new MessajeboxPedidoRealizado();
                    resultado = mensajepedidoconfirmado.ShowDialog();

                    //PONEMOS LOS LABEL A 0 y el contador se reinicia cada vez
                    ContadorRefrescos.Text = "0";
                    contadorRefrescos = 0;
                    //RESETEAMOS el elemento checkedlistbox para eliminar la seleccion una vez añamos añadido el pedido
                    TamañoRefrescos.ClearSelected();

                    for (int i = 0; i < TamañoRefrescos.Items.Count; i++)
                    {
                        TamañoRefrescos.SetItemChecked(i, false);
                    }




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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // AGUAS

        private void TamañoAguas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TamañoAguas.GetItemChecked(0) == true)
            {

                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamanioagua = "Small";
                //Console.WriteLine(tamanio);

            }

            if (TamañoAguas.GetItemChecked(1) == true)
            {
                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamanioagua = "Medium";
                //Console.WriteLine(tamanio);
            }

            if (TamañoAguas.GetItemChecked(2) == true)
            {
                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamanioagua = "Big";
                //Console.WriteLine(tamanio);
            }
        }

        private void WatersDerech_Click(object sender, EventArgs e)
        {
            WaterscaseSwitchIzq = 0;
            ContadorAgua.Text = "0";
            contadorAguas = 0;

            if (WaterscaseSwitchDerech == 2)
                WaterscaseSwitchDerech = 0;

            WaterscaseSwitchDerech++;

            switch (WaterscaseSwitchDerech)
            {
                case 1:
                    bezoya1.Visible = true;
                    bezoya1.BringToFront();
                    PrecioAguas.Text = "2.50";
                    id_agua = "AB01";
                    nombreagua = "Agua Bezoya";
                    precioagua = 2.50;

                    ;
                    break;
                case 2:
                    lanjaron1.Visible = true;
                    lanjaron1.BringToFront();
                    PrecioAguas.Text = "1.50";
                    id_agua = "AL01";
                    nombreagua = "Agua Lanjaron";
                    precioagua = 1.50;

                    ;
                    break;
            }
        }

        private void WatersIzq_Click(object sender, EventArgs e)
        {
            WaterscaseSwitchDerech = 0;
            ContadorAgua.Text = "0";
            contadorAguas = 0;

            if (WaterscaseSwitchIzq == 2)
                WaterscaseSwitchIzq = 0;

            WaterscaseSwitchIzq++;

            switch (WaterscaseSwitchIzq)
            {
                case 1:
                    lanjaron1.Visible = true;
                    lanjaron1.BringToFront();
                    PrecioAguas.Text = "1.50";
                    id_agua = "AL01";
                    nombreagua = "Agua Lanjaron";
                    precioagua = 1.50;

                    ;
                    break;
                case 2:
                    
                    bezoya1.Visible = true;
                    bezoya1.BringToFront();
                    PrecioAguas.Text = "2.50";
                    id_agua = "AB01";
                    nombreagua = "Agua Bezoya";
                    precioagua = 2.50;
                    ;
                    break;
            }
        }

        private void WatersbuttonSumar_Click(object sender, EventArgs e)
        {
            contadorAguas++;
            ContadorAgua.Text = Convert.ToString(contadorAguas);
        }

        private void WatersbuttonRestar_Click(object sender, EventArgs e)
        {
            if (contadorAguas > 0)
            {
                contadorAguas--;
                ContadorAgua.Text = Convert.ToString(contadorAguas);
            }
        }

        private void BuyAguas_Click(object sender, EventArgs e)
        {
            //VARIABLES MENSAJES ERROS Y CONFIRMACION

            DialogResult mensajeerror = new DialogResult();
            DialogResult resultado = new DialogResult();

            /*
            Console.WriteLine(tamanio);
            Console.WriteLine(cantidad);
            */


            //COMPROBAR QUE TODOS LOS CAMPOS ESTEN COMPLETADOS NO SE PERMITEN ESPACIOS EN BLANCO
            if (tamanioagua == "Small" || tamanioagua == "Medium" || tamanioagua == "Big")
            {
                //ASIGNAMOS LA CANTIDAD PARA SABER SI SE HA PULSADO O NO
                cantidadagua = contadorAguas;

                if (cantidadagua > 0)//COMPROBAMOS..
                {


                    //AQUI CREAMOS EL OBJETO PLATO Y ALMACENAMOS EN EL ARRAY


                    Producto nuevo = new Producto(id_agua, nombreagua, tamanioagua, cantidadagua, precioagua);

                    Carrito.Insertar_Bebida(nuevo);



                    //MOSTRAMOS MENSAJE DE QUE EL PEDIDO SE HA REALIZADO EXITOSAMENTE
                    Form mensajepedidoconfirmado = new MessajeboxPedidoRealizado();
                    resultado = mensajepedidoconfirmado.ShowDialog();

                    //PONEMOS LOS LABEL A 0 y el contador se reinicia cada vez
                    ContadorAgua.Text = "0";
                    contadorAguas = 0;


                    //RESETEAMOS el elemento checkedlistbox para eliminar la seleccion una vez añamos añadido el pedido
                    TamañoAguas.ClearSelected();

                    for (int i = 0; i < TamañoAguas.Items.Count; i++)
                    {
                        TamañoAguas.SetItemChecked(i, false);
                    }




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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //CERVEZAS
        private void TamañoCervezas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TamañoCervezas.GetItemChecked(0) == true)
            {

                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamaniocerveza = "Small";
                //Console.WriteLine(tamanio);

            }

            if (TamañoCervezas.GetItemChecked(1) == true)
            {
                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamaniocerveza = "Medium";
                //Console.WriteLine(tamanio);
            }

            if (TamañoCervezas.GetItemChecked(2) == true)
            {
                //Asignamos el valor a la variable que le correspondera al objeto ("plato") de este form
                tamaniocerveza = "Big";
                //Console.WriteLine(tamanio);
            }
        }

        private void BeersDerech_Click(object sender, EventArgs e)
        {
            BeerscaseSwitchIzq = 0;
            ContadorCerveza.Text = "0";
            contadorCervezas = 0;

            if (BeerscaseSwitchDerech == 4)
                BeerscaseSwitchDerech = 0;

            BeerscaseSwitchDerech++;

            switch (BeerscaseSwitchDerech)
            {
                case 1:
                    tropical1.Visible = true;
                    tropical1.BringToFront();
                    PrecioCervezas.Text = "2.50";
                    id_cerveza = "CT01";
                    nombrecerveza = "Cerveza Tropical";
                    preciocerveza = 2.50;

                    ;
                    break;
                case 2:

                    //Porque se ve la imagen por detras y alfinal lo he hecho asi...
                    tropical1.Visible = false;
                    turia1.Visible = false;

                    //

                    alhambra1.Visible = true;
                    alhambra1.BringToFront();
                    PrecioCervezas.Text = "3.50";
                    id_cerveza = "CA02";
                    nombrecerveza = "Cerveza Alhambra";
                    preciocerveza = 3.50;


                    ;
                    break;
                case 3:

                    amstel1.Visible = true;
                    amstel1.BringToFront();
                    PrecioCervezas.Text = "1.50";
                    id_cerveza = "CAM03";
                    nombrecerveza = "Cerveza Amstel";
                    preciocerveza = 1.50;

                    ;
                    break;

                case 4:
                    turia1.Visible = true;
                    turia1.BringToFront();
                    PrecioCervezas.Text = "4.99";
                    id_cerveza = "CTU04";
                    nombrecerveza = "Cerveza Turia";
                    preciocerveza = 4.99;

                    ;
                    break;
               
            }
        }

        private void BeersIzq_Click(object sender, EventArgs e)
        {
            BeerscaseSwitchDerech = 0;

            if (BeerscaseSwitchIzq == 4)
                BeerscaseSwitchIzq = 0;

            BeerscaseSwitchIzq++;

            switch (BeerscaseSwitchIzq)
            {
                case 1:
                    
                    turia1.Visible = true;
                    turia1.BringToFront();
                    PrecioCervezas.Text = "4.99";
                    id_cerveza = "CTU04";
                    nombrecerveza = "Cerveza Turia";
                    preciocerveza = 4.99;

                    ;
                    break;
                case 2:

                    amstel1.Visible = true;
                    amstel1.BringToFront();
                    PrecioCervezas.Text = "1.50";
                    id_cerveza = "CAM03";
                    nombrecerveza = "Cerveza Amstel";
                    preciocerveza = 1.50;

                    ;
                    break;
                case 3:


                    //Porque se ve la imagen por detras y alfinal lo he hecho asi...
                    tropical1.Visible = false;
                    turia1.Visible = false;
                    //

                    alhambra1.Visible = true;
                    alhambra1.BringToFront();
                    PrecioCervezas.Text = "3.50";
                    id_cerveza = "CA02";
                    nombrecerveza = "Cerveza Alhambra";
                    preciocerveza = 3.50;

                    ;
                    break;

                case 4:
                    tropical1.Visible = true;
                    tropical1.BringToFront();
                    PrecioCervezas.Text = "2.50";
                    id_cerveza = "CT01";
                    nombrecerveza = "Cerveza Tropical";
                    preciocerveza = 2.50;
                    ;
                    break;

            }
        }

        private void BeersbuttonSumar_Click(object sender, EventArgs e)
        {
            contadorCervezas++;
            ContadorCerveza.Text = Convert.ToString(contadorCervezas);
        }

        private void BeersbuttonRestar_Click(object sender, EventArgs e)
        {
            if (contadorCervezas > 0)
            {
                contadorCervezas--;
                ContadorCerveza.Text = Convert.ToString(contadorCervezas);
            }
        }

        

        private void BuyCervezas_Click(object sender, EventArgs e)
        {
            //VARIABLES MENSAJES ERROS Y CONFIRMACION

            DialogResult mensajeerror = new DialogResult();
            DialogResult resultado = new DialogResult();

            /*
            Console.WriteLine(tamanio);
            Console.WriteLine(cantidad);
            */


            //COMPROBAR QUE TODOS LOS CAMPOS ESTEN COMPLETADOS NO SE PERMITEN ESPACIOS EN BLANCO
            if (tamaniocerveza == "Small" || tamaniocerveza == "Medium" || tamaniocerveza == "Big")
            {
                //ASIGNAMOS LA CANTIDAD PARA SABER SI SE HA PULSADO O NO
                cantidadcerveza = contadorCervezas;

                if (cantidadcerveza > 0)//COMPROBAMOS..
                {


                    //AQUI CREAMOS EL OBJETO PLATO Y ALMACENAMOS EN EL ARRAY


                    Producto nuevo = new Producto(id_cerveza, nombrecerveza, tamaniocerveza, cantidadcerveza, preciocerveza);

                    Carrito.Insertar_Bebida(nuevo);



                    //MOSTRAMOS MENSAJE DE QUE EL PEDIDO SE HA REALIZADO EXITOSAMENTE
                    Form mensajepedidoconfirmado = new MessajeboxPedidoRealizado();
                    resultado = mensajepedidoconfirmado.ShowDialog();

                    //PONEMOS LOS LABEL A 0 y el contador se reinicia cada vez
                    ContadorCerveza.Text = "0";
                    contadorCervezas = 0;


                    //RESETEAMOS el elemento checkedlistbox para eliminar la seleccion una vez añamos añadido el pedido
                    TamañoCervezas.ClearSelected();

                    for (int i = 0; i < TamañoCervezas.Items.Count; i++)
                    {
                        TamañoCervezas.SetItemChecked(i, false);
                    }




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
