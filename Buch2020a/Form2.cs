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
    public partial class frmListenansicht : Form
    {
        private Color alteFarbe;

        public frmListenansicht()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kundeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.buch2020DataSet);
            }
            catch
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\nBitte überprüfen Sie i" +
                    "Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListenansicht_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
        }

        private void kundeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            bool fehlerKeinEintrag = false;
            int postleitzahltemp = 0;
            if ((e.ColumnIndex > 0) && (e.ColumnIndex < 6))
            {
                if (e.FormattedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Sie müssen einen Wert für " + kundeDataGridView.Columns[e.ColumnIndex].HeaderText + " eingeben.");
                    kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Die Zelle darf nicht leer sein.";
                    e.Cancel = true;
                    fehlerKeinEintrag = true;
                }
            }
            if ((e.ColumnIndex == 4) && (fehlerKeinEintrag == false))
            {
                if (e.FormattedValue.ToString().Length != 5)
                {
                    MessageBox.Show("Die PLZ muss fünf Ziffern beinhalten.");
                    e.Cancel = true;
                }
                else
                    if (Int32.TryParse(e.FormattedValue.ToString(), out postleitzahltemp) == false)
                {
                    MessageBox.Show("Das Format der PLZ ist ungültig!");
                    e.Cancel = true;
                }
            }
        }

        private void kundeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText != string.Empty)
                kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
        }

        private void kundeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.Validate();
                this.kundeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.buch2020DataSet);
            }
            catch
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\nBitte überprüfen Sie i" +
                    "Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void kundeDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                DataGridViewCell zelle = kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                alteFarbe = zelle.Style.BackColor;
                zelle.Style.BackColor = Color.LightBlue;
            }
        }

        private void kundeDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                DataGridViewCell zelle = kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                zelle.Style.BackColor = alteFarbe;
            }
        }
    }
}
