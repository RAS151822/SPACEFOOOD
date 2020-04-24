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
    public partial class FormHotDog : Form
    {
        int contador;
        public FormHotDog()
        {
            InitializeComponent();
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

        private void buttonNEXT_Click(object sender, EventArgs e)
        {
            openChildForm(new MenuAmericano());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPizza());
        }

        private void buttonComprar_Click(object sender, EventArgs e)
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
