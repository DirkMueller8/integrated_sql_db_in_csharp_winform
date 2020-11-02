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
    public partial class frmMedienliste : Form
    {
        public frmMedienliste()
        {
            InitializeComponent();
        }

        private void mediumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mediumBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.buch2020DataSet);
            }
            catch
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\nBitte überprüfen Sie Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMedienliste_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". 
            // Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);
        }

        private void mediumDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            {
                bool fehlerKeinEintrag = false;
                if ((e.ColumnIndex > 0) && (e.ColumnIndex < 4))
                {
                    if (e.FormattedValue.ToString() == string.Empty)
                    {
                        MessageBox.Show("Sie müssen einen Wert für " + mediumDataGridView.Columns[e.ColumnIndex].HeaderText + " eingeben.");
                        mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Die Zelle darf nicht leer sein.";
                        e.Cancel = true;
                        fehlerKeinEintrag = true;
                    }
                }
                if ((e.ColumnIndex == 2) && (fehlerKeinEintrag == false))
                {
                    if (e.FormattedValue.ToString().Length != 1)
                    {
                        MessageBox.Show("Der Medientyp muss einen Buchstaben beinhalten.");
                        e.Cancel = true;
                    }
                    if (e.FormattedValue.ToString().ToLower().Contains('b') == false && e.FormattedValue.ToString().ToLower().Contains('z') == false && e.FormattedValue.ToString().ToLower().Contains('m') == false && e.FormattedValue.ToString().ToLower().Contains('f') == false) 
                    {
                        MessageBox.Show("Input ist nicht b, z, m oder f. Bitte nochmal versuchen!");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void mediumDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText != string.Empty)
                mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
        }

        private void mediumDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\nBitte überprüfen Sie Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
