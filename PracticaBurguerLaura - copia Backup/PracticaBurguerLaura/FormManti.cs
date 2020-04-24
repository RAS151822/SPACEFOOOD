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
    public partial class FormManti : Form
    {
        int contador;
        public FormManti()
        {
            InitializeComponent();
        }

        private void buttonNEXT_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuTurkia());
        }

        //METODO PARA ABRIR LOS FORMS DE CADA MENU

        private void openChildForm(Form childForm)
        {

            //activeForm.Close();


            if (childForm != null)
            {



                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel1.Controls.Add(childForm);
                panel1.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();


            }
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            contador++;
            labelContador.Text = Convert.ToString(contador);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            openChildForm(new FormKofte());
        }

        private void buttonComprar_Click_1(object sender, EventArgs e)
        {
            contador++;
            labelContador.Text = Convert.ToString(contador);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                contador--;
                labelContador.Text = Convert.ToString(contador);
            }
        }
    }
}
