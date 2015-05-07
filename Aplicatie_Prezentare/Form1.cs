using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Prezentare
{
    public partial class frmAplicatiaLuViorel : Form
    {
        public frmAplicatiaLuViorel()
        {
            InitializeComponent();
        }

        // Eveniment pentru txtNume
        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            if (txtNume.Text != string.Empty)
            {
                // Activam
                txtPrenume.Enabled = true;
            }
            else
            {
                // Dezactivam
                txtPrenume.Enabled = false;
            }
        }

        // Eveniment pentru txtPrenume
        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {
            if (txtPrenume.Text != string.Empty)
            {
                // Activam
                btnCiocCioc.Enabled = true;
            }
            else
            {
                // Dezactivam
                btnCiocCioc.Enabled = false;
            }
        }

        // Eveniment pentru btnCiocCioc
        private void btnCiocCioc_Click(object sender, EventArgs e)
        {
            string textAfisat = "Utilizatorul " + txtNume.Text + " " + txtPrenume.Text + " a ramas fara idei...";
            MessageBox.Show(textAfisat, "Uite cum sta treaba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        // Eveniment pentru btnIesire
        private void btnIesire_Click(object sender, EventArgs e)
        {
            // Inchidem formularul
            Close();
        }
    }
}
