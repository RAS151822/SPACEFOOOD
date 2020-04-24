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
    public partial class BEBIDAS : Form
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



        public BEBIDAS()
        {
            InitializeComponent();
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

            //Bebidas
            bezoya1.Visible = true;
            lanjaron1.Visible = false;

            //Cervezas
            tropical1.Visible = true;
            alhambra1.Visible = false;
            amstel1.Visible = false;
            turia1.Visible = false;

        }

        // REFRESCOS

        private void SodasDerech_Click(object sender, EventArgs e)
        {
            SodascaseSwitchIzq = 0;

            if (SodascaseSwitchDerech == 5)
                SodascaseSwitchDerech = 0;

            SodascaseSwitchDerech++;

            switch (SodascaseSwitchDerech)
            {
                case 1:
                    cocaColas1.Visible = true;
                    cocaColas1.BringToFront();


                    ;
                    break;
                case 2:
                    cocaColaZero1.Visible = true;
                    cocaColaZero1.BringToFront();


                    ;
                    break;
                case 3:
                    colaLight1.Visible = true;
                    colaLight1.BringToFront();


                    ;
                    break;

                case 4:
                    fantaLimon1.Visible = true;
                    fantaLimon1.BringToFront();

                    ;
                    break;
                case 5:
                    fantaNaranja1.Visible = true;
                    fantaNaranja1.BringToFront();
                    ;
                    break;


            }

            
        }

        private void SodasIzq_Click(object sender, EventArgs e)
        {
            SodascaseSwitchDerech = 0;

            if (SodascaseSwitchIzq == 5)
                SodascaseSwitchIzq = 0;

            SodascaseSwitchIzq++;

            switch (SodascaseSwitchIzq)
            {
                case 1:
                   
                    fantaNaranja1.Visible = true;
                    fantaNaranja1.BringToFront();

                    ;
                    break;
                case 2:
                   
                    fantaLimon1.Visible = true;
                    fantaLimon1.BringToFront();


                    ;
                    break;
                case 3:
                    colaLight1.Visible = true;
                    colaLight1.BringToFront();


                    ;
                    break;

                case 4:
                    cocaColaZero1.Visible = true;
                    cocaColaZero1.BringToFront();

                    ;
                    break;
                case 5:
                    cocaColas1.Visible = true;
                    cocaColas1.BringToFront();
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

        // AGUAS

        private void WatersDerech_Click(object sender, EventArgs e)
        {
            WaterscaseSwitchIzq = 0;

            if (WaterscaseSwitchDerech == 2)
                WaterscaseSwitchDerech = 0;

            WaterscaseSwitchDerech++;

            switch (WaterscaseSwitchDerech)
            {
                case 1:
                    bezoya1.Visible = true;
                    bezoya1.BringToFront();


                    ;
                    break;
                case 2:
                    lanjaron1.Visible = true;
                    lanjaron1.BringToFront();


                    ;
                    break;
            }
        }

        private void WatersIzq_Click(object sender, EventArgs e)
        {
            WaterscaseSwitchDerech = 0;

            if (WaterscaseSwitchIzq == 2)
                WaterscaseSwitchIzq = 0;

            WaterscaseSwitchIzq++;

            switch (WaterscaseSwitchIzq)
            {
                case 1:
                    lanjaron1.Visible = true;
                    lanjaron1.BringToFront();


                    ;
                    break;
                case 2:
                    
                    bezoya1.Visible = true;
                    bezoya1.BringToFront();

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

        //CERVEZAS

        private void BeersDerech_Click(object sender, EventArgs e)
        {
            BeerscaseSwitchIzq = 0;

            if (BeerscaseSwitchDerech == 4)
                BeerscaseSwitchDerech = 0;

            BeerscaseSwitchDerech++;

            switch (BeerscaseSwitchDerech)
            {
                case 1:
                    tropical1.Visible = true;
                    tropical1.BringToFront();


                    ;
                    break;
                case 2:

                    //Porque se ve la imagen por detras y alfinal lo he hecho asi...
                    tropical1.Visible = false;
                    turia1.Visible = false;
                    //

                    alhambra1.Visible = true;
                    alhambra1.BringToFront();


                    ;
                    break;
                case 3:
                    amstel1.Visible = true;
                    amstel1.BringToFront();


                    ;
                    break;

                case 4:
                    turia1.Visible = true;
                    turia1.BringToFront();

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

                    ;
                    break;
                case 2:

                    amstel1.Visible = true;
                    amstel1.BringToFront();

                    ;
                    break;
                case 3:


                    //Porque se ve la imagen por detras y alfinal lo he hecho asi...
                    tropical1.Visible = false;
                    turia1.Visible = false;
                    //

                    alhambra1.Visible = true;
                    alhambra1.BringToFront();

                    ;
                    break;

                case 4:
                    tropical1.Visible = true;
                    tropical1.BringToFront();

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
    }
}
