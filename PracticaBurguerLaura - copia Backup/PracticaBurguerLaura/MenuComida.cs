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
    public partial class MenuComida : Form
    {
        private Form activeForm = null;
        private bool MediterraneoActivado = false;
        private bool AsiaActivado = false;
        private bool TurkiaActivado = false;
        private bool AmericaActivado = false;

        public MenuComida()
        {
           
            InitializeComponent();
            
           
        }

        //METODO PARA ABRIR LOS FORMS DE CADA MENU

        private void openChildForm(Form childForm)
        {
            activeForm = childForm;
            //activeForm.Close();


            if (activeForm != null)
            {
               


                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelFormulariosHijos.Controls.Add(childForm);
                panelFormulariosHijos.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();


            }
        }

        private void buttonMEDITERRANEO_Click(object sender, EventArgs e)
        {
            MediterraneoActivado = true;

            if (AsiaActivado == true)
            {
                activeForm.Close();
                AsiaActivado = false;
            }

            if (TurkiaActivado == true)
            {
                activeForm.Close();
                TurkiaActivado = false;
            }

            if (AmericaActivado == true)
            {
                activeForm.Close();
                AmericaActivado = false;
            }

            openChildForm(new MenuMediterraneo());
            
        }

        private void buttonAsia_Click(object sender, EventArgs e)
        {
            AsiaActivado = true;

           if (MediterraneoActivado == true)
            {
                activeForm.Close();
                MediterraneoActivado = false;
            }

            if (TurkiaActivado == true)
            {
                activeForm.Close();
                TurkiaActivado = false;
            }

            if (AmericaActivado == true)
            {
                activeForm.Close();
                AmericaActivado = false;
            }

            openChildForm(new MenuAsia());
            
        }

        private void buttonTURCA_Click(object sender, EventArgs e)
        {
            TurkiaActivado = true;

            if (MediterraneoActivado == true)
            {
                activeForm.Close();
                MediterraneoActivado = false;
            }

            if (AsiaActivado == true)
            {
                activeForm.Close();
                AsiaActivado = false;
            }

            if (AmericaActivado == true)
            {
                activeForm.Close();
                AmericaActivado = false;
            }

            openChildForm(new MenuTurkia());
        }

        private void buttonAmerica_Click(object sender, EventArgs e)
        {
            AmericaActivado = true;

            if (MediterraneoActivado == true)
            {
                activeForm.Close();
                MediterraneoActivado = false;
            }

            if (AsiaActivado == true)
            {
                activeForm.Close();
                AsiaActivado = false;
            }

            if (TurkiaActivado == true)
            {
                activeForm.Close();
                TurkiaActivado = false;
            }

            openChildForm(new MenuAmericano());
        }
    }
}
