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
    public partial class frmEinzelansicht : Form
    {
        public frmEinzelansicht()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                // This does not work properly yet:
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

        private void frmEinzelansicht_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
        }

        private void kNameTextBox_Leave(object sender, EventArgs e)
        {
            if (kNameTextBox.Text == "")
            {
                // Lasse den Benutzer die TextBox nicht verlassen ohne einen Eintrag vorzunehmen:
                MessageBox.Show("Feld für Nachname darf nicht leer bleiben!");
                // Belasse den Cursor in der TextBox:
                kNameTextBox.Focus();
            }
            else
            {
                if (kNameTextBox.Text.Length > 50)
                {
                    // Lasse den Benutzer die TextBox nicht verlassen ohne einen Eintrag vorzunehmen:
                    MessageBox.Show("Feld für Nachname darf nicht mehr als 50 Zeichen haben!");
                    // Belasse den Cursor in der TextBox:
                    kNameTextBox.Focus();
                }
            }
        }

        private void vornameTextBox_Leave(object sender, EventArgs e)
        {
            if (vornameTextBox.Text == "")
            {
                // Lasse den Benutzer die TextBox nicht verlassen ohne einen Eintrag vorzunehmen:
                MessageBox.Show("Feld für Vorname darf nicht leer bleiben!");
                // Belasse den Cursor in der TextBox:
                vornameTextBox.Focus();
            }
            else
            {
                if (vornameTextBox.Text.Length > 50)
                {
                    // Lasse den Benutzer die TextBox nicht verlassen ohne einen Eintrag vorzunehmen:
                    MessageBox.Show("Feld für Vorname darf nicht mehr als 50 Zeichen haben!");
                    // Belasse den Cursor in der TextBox:
                    vornameTextBox.Focus();
                }
            }
        }

        private void strasseTextBox_Leave(object sender, EventArgs e)
        {
            if (strasseTextBox.Text == "")
            {
                // Lasse den Benutzer die TextBox nicht verlassen ohne einen Eintrag vorzunehmen:
                MessageBox.Show("Feld für Strasse darf nicht leer bleiben!");
                // Belasse den Cursor in der TextBox:
                strasseTextBox.Focus();
            }
            else
            {
                if (strasseTextBox.Text.Length > 50)
                {
                    // Lasse den Benutzer die TextBox nicht verlassen ohne einen Eintrag vorzunehmen:
                    MessageBox.Show("Feld für Strasse darf nicht mehr als 50 Zeichen haben!");
                    // Belasse den Cursor in der TextBox:
                    strasseTextBox.Focus();
                }
            }
        }

        private void postleitzahlTextBox_Leave(object sender, EventArgs e)
        {
            int plz;
            bool resultat;
            if (postleitzahlTextBox.Text == "")
            {
                // Lasse den Benutzer die TextBox nicht verlassen ohne einen Eintrag vorzunehmen:
                MessageBox.Show("Feld für PLZ darf nicht leer bleiben!");
                // Belasse den Cursor in der TextBox:
                postleitzahlTextBox.Focus();
            }
            else
            {
                if (postleitzahlTextBox.Text.Length > 5)
                {
                    // Lasse den Benutzer die TextBox nicht verlassen wenn Eingabe zu lang:
                    MessageBox.Show("Feld für PLZ darf nicht mehr als 5 Zeichen haben!");
                    // Belasse den Cursor in der TextBox:
                    postleitzahlTextBox.Focus();
                }
                else if (postleitzahlTextBox.Text.Length < 5)
                {
                    // Lasse den Benutzer die TextBox nicht verlassen ohne genau 5 Zahlen einzugeben:
                    MessageBox.Show("Feld für PLZ muss 5 Zeichen haben!");
                    // Belasse den Cursor in der TextBox:
                    postleitzahlTextBox.Focus();
                }
                resultat = Int32.TryParse(postleitzahlTextBox.Text, out plz);
                if (!resultat)
                {
                    // Lasse den Benutzer die TextBox nicht verlassen ohne genau 5 Zahlen einzugeben:
                    MessageBox.Show("Feld für PLZ enthält nicht ausnahmslos Zahlen!");
                    // Belasse den Cursor in der TextBox:
                    postleitzahlTextBox.Focus();
                }
            }
        }

        private void ortTextBox_Leave(object sender, EventArgs e)
        {
            if (ortTextBox.Text == "")
            {
                // Lasse den Benutzer die TextBox nicht verlassen ohne einen Eintrag vorzunehmen:
                MessageBox.Show("Feld für Ort darf nicht leer bleiben!");
                // Belasse den Cursor in der TextBox:
                ortTextBox.Focus();
            }
            else
            {
                if (ortTextBox.Text.Length > 50)
                {
                    // Lasse den Benutzer die TextBox nicht verlassen ohne einen Eintrag vorzunehmen:
                    MessageBox.Show("Feld für Ort darf nicht mehr als 50 Zeichen haben!");
                    // Belasse den Cursor in der TextBox:
                    ortTextBox.Focus();
                }
            }
        }

        private void telefon1TextBox_Leave(object sender, EventArgs e)
        {
            if (telefon1TextBox.Text.Length > 20)
            {
                // Lasse den Benutzer die TextBox nicht verlassen ohne einen Eintrag vorzunehmen:
                MessageBox.Show("Feld für Telefonnummer darf nicht mehr als 20 Zeichen haben!");
                // Belasse den Cursor in der TextBox:
                ortTextBox.Focus();
            }
        }
    }
}
