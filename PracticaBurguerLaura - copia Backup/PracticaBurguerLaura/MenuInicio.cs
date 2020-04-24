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
    
    

    public partial class MenuInicio : Form
    {

        private Form activeForm = null;
        private Pedido n;

        public MenuInicio()
        {
            InitializeComponent();
            CustomizeDesign();

            //DOTAMOS DE MEMORIA al objeto pedido para poder dar memoria desde el inicio del programa a los arrays comida,bebida,....
            n = new Pedido();

            //INICIALIZO ARRAYS donde almacenare los datos del pedido
            IniciarArrayPedido();

        }

        private void CustomizeDesign() {

            panelAreaPersonalSubmenu.Visible = false;
            panelCartaSubMenu.Visible = false;
        }

        //METODOS PARA ABRIR Y CERRAR SUBMENUS

        private void HideSubMenu() {

            if (panelAreaPersonalSubmenu.Visible = true) {

                panelAreaPersonalSubmenu.Visible = false;
            }

            if(panelCartaSubMenu.Visible = true)
            {
                panelCartaSubMenu.Visible = false;
            }
        }

        private void ShowSubMenu(Panel submenu) {

            if (submenu.Visible = true) {

                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        


        //METODO PARA ABRIR  LOS CHILDREN FORMS

        private void openChildForm(Form childForm)
        {
            activeForm = childForm ;
            //activeForm.Close();


            if (activeForm != null)
            {
               // Console.WriteLine("EntraMEDITERRANEO");
              
               
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelFormulariosHijos.Controls.Add(childForm);
                panelFormulariosHijos.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
               

            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////

        //INICIO DE ARRAYS
        private void IniciarArrayPedido(){

            n.IniciarArrayComida();
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////

        //BOTON MENU AREA PERSONAL
        private void buttonAreaPersonal_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAreaPersonalSubmenu); 
        }

      
        private void buttonMiperfil_Click(object sender, EventArgs e)
        {
           
            HideSubMenu();
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void buttonCarrito_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuCarrito());
            HideSubMenu();
        }


        ////////////////////////////////////////////////////////////////////////////


        //BOTON MENU CARTAS
        private void buttonCarta_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCartaSubMenu);
           
        }



        //COMIDA
        private void buttonCartaComida_Click(object sender, EventArgs e)
        {

            openChildForm(new MenuComida());
            HideSubMenu();

            //Doy memoria al array de Comida (para no perder los datos al abrir y cerrar form o al darle nueva memoria..)

        }


        //BEBIDA
        private void buttonCartaBebida_Click(object sender, EventArgs e)
        {
            openChildForm(new BEBIDAS());
            HideSubMenu();
        }

        //POSTRES
        private void buttonCartaPostres_Click(object sender, EventArgs e)
        {
            openChildForm(new Postres());
            HideSubMenu();
        }

        private void panelFormulariosHijos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
