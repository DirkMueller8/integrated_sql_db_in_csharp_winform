using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buch2020a
{
    public partial class frmBuch2020 : Form
    {
        public frmBuch2020()
        {
            InitializeComponent();
        }

        private void btnListenansicht_Click(object sender, EventArgs e)
        {
            frmListenansicht newForm = new frmListenansicht();
            newForm.ShowDialog();
        }

        private void Einzelansicht_Click(object sender, EventArgs e)
        {
            frmEinzelansicht newForm1 = new frmEinzelansicht();
            newForm1.ShowDialog();
        }

        private void frmMedienliste_Click(object sender, EventArgs e)
        {
            frmMedienliste newForm2 = new frmMedienliste();
            newForm2.ShowDialog();
        }

        private void frmMedieneinzel_Click(object sender, EventArgs e)
        {
            frmMedieneinzel newForm3 = new frmMedieneinzel();
            newForm3.ShowDialog();
        }
    }
}
