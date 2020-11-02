namespace Buch2020a
{
    partial class frmMedieneinzel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mNummerLabel;
            System.Windows.Forms.Label titelLabel;
            System.Windows.Forms.Label typLabel;
            System.Windows.Forms.Label standortLabel;
            System.Windows.Forms.Label ausgeliehenLabel;
            System.Windows.Forms.Label bestandLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedieneinzel));
            this.buch2020DataSet = new Buch2020a.buch2020DataSet();
            this.mediumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediumTableAdapter = new Buch2020a.buch2020DataSetTableAdapters.MediumTableAdapter();
            this.tableAdapterManager = new Buch2020a.buch2020DataSetTableAdapters.TableAdapterManager();
            this.mediumBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.mNummerTextBox = new System.Windows.Forms.TextBox();
            this.titelTextBox = new System.Windows.Forms.TextBox();
            this.typTextBox = new System.Windows.Forms.TextBox();
            this.standortTextBox = new System.Windows.Forms.TextBox();
            this.ausgeliehenCheckBox = new System.Windows.Forms.CheckBox();
            this.bestandCheckBox = new System.Windows.Forms.CheckBox();
            mNummerLabel = new System.Windows.Forms.Label();
            titelLabel = new System.Windows.Forms.Label();
            typLabel = new System.Windows.Forms.Label();
            standortLabel = new System.Windows.Forms.Label();
            ausgeliehenLabel = new System.Windows.Forms.Label();
            bestandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingNavigator)).BeginInit();
            this.mediumBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mNummerLabel
            // 
            mNummerLabel.AutoSize = true;
            mNummerLabel.Location = new System.Drawing.Point(15, 37);
            mNummerLabel.Name = "mNummerLabel";
            mNummerLabel.Size = new System.Drawing.Size(62, 13);
            mNummerLabel.TabIndex = 1;
            mNummerLabel.Text = "Medien-Nr.:";
            // 
            // titelLabel
            // 
            titelLabel.AutoSize = true;
            titelLabel.Location = new System.Drawing.Point(15, 63);
            titelLabel.Name = "titelLabel";
            titelLabel.Size = new System.Drawing.Size(30, 13);
            titelLabel.TabIndex = 3;
            titelLabel.Text = "Titel:";
            // 
            // typLabel
            // 
            typLabel.AutoSize = true;
            typLabel.Location = new System.Drawing.Point(15, 89);
            typLabel.Name = "typLabel";
            typLabel.Size = new System.Drawing.Size(28, 13);
            typLabel.TabIndex = 5;
            typLabel.Text = "Typ:";
            // 
            // standortLabel
            // 
            standortLabel.AutoSize = true;
            standortLabel.Location = new System.Drawing.Point(15, 115);
            standortLabel.Name = "standortLabel";
            standortLabel.Size = new System.Drawing.Size(50, 13);
            standortLabel.TabIndex = 7;
            standortLabel.Text = "Standort:";
            // 
            // ausgeliehenLabel
            // 
            ausgeliehenLabel.AutoSize = true;
            ausgeliehenLabel.Location = new System.Drawing.Point(15, 143);
            ausgeliehenLabel.Name = "ausgeliehenLabel";
            ausgeliehenLabel.Size = new System.Drawing.Size(68, 13);
            ausgeliehenLabel.TabIndex = 9;
            ausgeliehenLabel.Text = "Ausgeliehen:";
            // 
            // bestandLabel
            // 
            bestandLabel.AutoSize = true;
            bestandLabel.Location = new System.Drawing.Point(15, 173);
            bestandLabel.Name = "bestandLabel";
            bestandLabel.Size = new System.Drawing.Size(49, 13);
            bestandLabel.TabIndex = 11;
            bestandLabel.Text = "Bestand:";
            // 
            // buch2020DataSet
            // 
            this.buch2020DataSet.DataSetName = "buch2020DataSet";
            this.buch2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediumBindingSource
            // 
            this.mediumBindingSource.DataMember = "Medium";
            this.mediumBindingSource.DataSource = this.buch2020DataSet;
            // 
            // mediumTableAdapter
            // 
            this.mediumTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = null;
            this.tableAdapterManager.MediumTableAdapter = this.mediumTableAdapter;
            this.tableAdapterManager.UpdateOrder = Buch2020a.buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mediumBindingNavigator
            // 
            this.mediumBindingNavigator.AddNewItem = null;
            this.mediumBindingNavigator.BindingSource = this.mediumBindingSource;
            this.mediumBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mediumBindingNavigator.DeleteItem = null;
            this.mediumBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.mediumBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mediumBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mediumBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mediumBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mediumBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mediumBindingNavigator.Name = "mediumBindingNavigator";
            this.mediumBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mediumBindingNavigator.Size = new System.Drawing.Size(308, 25);
            this.mediumBindingNavigator.TabIndex = 0;
            this.mediumBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // mNummerTextBox
            // 
            this.mNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "mNummer", true));
            this.mNummerTextBox.Location = new System.Drawing.Point(88, 34);
            this.mNummerTextBox.Name = "mNummerTextBox";
            this.mNummerTextBox.ReadOnly = true;
            this.mNummerTextBox.Size = new System.Drawing.Size(208, 20);
            this.mNummerTextBox.TabIndex = 2;
            // 
            // titelTextBox
            // 
            this.titelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "titel", true));
            this.titelTextBox.Location = new System.Drawing.Point(88, 60);
            this.titelTextBox.Name = "titelTextBox";
            this.titelTextBox.ReadOnly = true;
            this.titelTextBox.Size = new System.Drawing.Size(208, 20);
            this.titelTextBox.TabIndex = 4;
            // 
            // typTextBox
            // 
            this.typTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "typ", true));
            this.typTextBox.Location = new System.Drawing.Point(88, 86);
            this.typTextBox.Name = "typTextBox";
            this.typTextBox.ReadOnly = true;
            this.typTextBox.Size = new System.Drawing.Size(208, 20);
            this.typTextBox.TabIndex = 6;
            // 
            // standortTextBox
            // 
            this.standortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "standort", true));
            this.standortTextBox.Location = new System.Drawing.Point(88, 112);
            this.standortTextBox.Name = "standortTextBox";
            this.standortTextBox.ReadOnly = true;
            this.standortTextBox.Size = new System.Drawing.Size(208, 20);
            this.standortTextBox.TabIndex = 8;
            // 
            // ausgeliehenCheckBox
            // 
            this.ausgeliehenCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mediumBindingSource, "ausgeliehen", true));
            this.ausgeliehenCheckBox.Enabled = false;
            this.ausgeliehenCheckBox.Location = new System.Drawing.Point(88, 138);
            this.ausgeliehenCheckBox.Name = "ausgeliehenCheckBox";
            this.ausgeliehenCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ausgeliehenCheckBox.TabIndex = 10;
            this.ausgeliehenCheckBox.UseVisualStyleBackColor = true;
            // 
            // bestandCheckBox
            // 
            this.bestandCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mediumBindingSource, "bestand", true));
            this.bestandCheckBox.Enabled = false;
            this.bestandCheckBox.Location = new System.Drawing.Point(88, 168);
            this.bestandCheckBox.Name = "bestandCheckBox";
            this.bestandCheckBox.Size = new System.Drawing.Size(104, 24);
            this.bestandCheckBox.TabIndex = 12;
            this.bestandCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmMedieneinzel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(mNummerLabel);
            this.Controls.Add(this.mNummerTextBox);
            this.Controls.Add(titelLabel);
            this.Controls.Add(this.titelTextBox);
            this.Controls.Add(typLabel);
            this.Controls.Add(this.typTextBox);
            this.Controls.Add(standortLabel);
            this.Controls.Add(this.standortTextBox);
            this.Controls.Add(ausgeliehenLabel);
            this.Controls.Add(this.ausgeliehenCheckBox);
            this.Controls.Add(bestandLabel);
            this.Controls.Add(this.bestandCheckBox);
            this.Controls.Add(this.mediumBindingNavigator);
            this.Name = "frmMedieneinzel";
            this.Text = "Medien-Einzelanzeige";
            this.Load += new System.EventHandler(this.frmMedieneinzel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingNavigator)).EndInit();
            this.mediumBindingNavigator.ResumeLayout(false);
            this.mediumBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource mediumBindingSource;
        private buch2020DataSetTableAdapters.MediumTableAdapter mediumTableAdapter;
        private buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mediumBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.TextBox mNummerTextBox;
        private System.Windows.Forms.TextBox titelTextBox;
        private System.Windows.Forms.TextBox typTextBox;
        private System.Windows.Forms.TextBox standortTextBox;
        private System.Windows.Forms.CheckBox ausgeliehenCheckBox;
        private System.Windows.Forms.CheckBox bestandCheckBox;
    }
}