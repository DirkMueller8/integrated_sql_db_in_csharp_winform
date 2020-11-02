namespace Buch2020a
{
    partial class frmEinzelansicht
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
            System.Windows.Forms.Label kNummerLabel;
            System.Windows.Forms.Label kNameLabel;
            System.Windows.Forms.Label vornameLabel;
            System.Windows.Forms.Label strasseLabel;
            System.Windows.Forms.Label postleitzahlLabel;
            System.Windows.Forms.Label ortLabel;
            System.Windows.Forms.Label telefon1Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEinzelansicht));
            this.buch2020DataSet = new Buch2020a.buch2020DataSet();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new Buch2020a.buch2020DataSetTableAdapters.KundeTableAdapter();
            this.tableAdapterManager = new Buch2020a.buch2020DataSetTableAdapters.TableAdapterManager();
            this.kundeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kundeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kNummerTextBox = new System.Windows.Forms.TextBox();
            this.kNameTextBox = new System.Windows.Forms.TextBox();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.strasseTextBox = new System.Windows.Forms.TextBox();
            this.postleitzahlTextBox = new System.Windows.Forms.TextBox();
            this.ortTextBox = new System.Windows.Forms.TextBox();
            this.telefon1TextBox = new System.Windows.Forms.TextBox();
            kNummerLabel = new System.Windows.Forms.Label();
            kNameLabel = new System.Windows.Forms.Label();
            vornameLabel = new System.Windows.Forms.Label();
            strasseLabel = new System.Windows.Forms.Label();
            postleitzahlLabel = new System.Windows.Forms.Label();
            ortLabel = new System.Windows.Forms.Label();
            telefon1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingNavigator)).BeginInit();
            this.kundeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kNummerLabel
            // 
            kNummerLabel.AutoSize = true;
            kNummerLabel.Location = new System.Drawing.Point(16, 38);
            kNummerLabel.Name = "kNummerLabel";
            kNummerLabel.Size = new System.Drawing.Size(84, 13);
            kNummerLabel.TabIndex = 1;
            kNummerLabel.Text = "Kundennummer:";
            // 
            // kNameLabel
            // 
            kNameLabel.AutoSize = true;
            kNameLabel.Location = new System.Drawing.Point(16, 64);
            kNameLabel.Name = "kNameLabel";
            kNameLabel.Size = new System.Drawing.Size(62, 13);
            kNameLabel.TabIndex = 3;
            kNameLabel.Text = "Nachname:";
            // 
            // vornameLabel
            // 
            vornameLabel.AutoSize = true;
            vornameLabel.Location = new System.Drawing.Point(16, 90);
            vornameLabel.Name = "vornameLabel";
            vornameLabel.Size = new System.Drawing.Size(52, 13);
            vornameLabel.TabIndex = 5;
            vornameLabel.Text = "Vorname:";
            // 
            // strasseLabel
            // 
            strasseLabel.AutoSize = true;
            strasseLabel.Location = new System.Drawing.Point(16, 116);
            strasseLabel.Name = "strasseLabel";
            strasseLabel.Size = new System.Drawing.Size(91, 13);
            strasseLabel.TabIndex = 7;
            strasseLabel.Text = "Strasse + Hausnr:";
            // 
            // postleitzahlLabel
            // 
            postleitzahlLabel.AutoSize = true;
            postleitzahlLabel.Location = new System.Drawing.Point(16, 142);
            postleitzahlLabel.Name = "postleitzahlLabel";
            postleitzahlLabel.Size = new System.Drawing.Size(30, 13);
            postleitzahlLabel.TabIndex = 9;
            postleitzahlLabel.Text = "PLZ:";
            // 
            // ortLabel
            // 
            ortLabel.AutoSize = true;
            ortLabel.Location = new System.Drawing.Point(16, 168);
            ortLabel.Name = "ortLabel";
            ortLabel.Size = new System.Drawing.Size(24, 13);
            ortLabel.TabIndex = 11;
            ortLabel.Text = "Ort:";
            // 
            // telefon1Label
            // 
            telefon1Label.AutoSize = true;
            telefon1Label.Location = new System.Drawing.Point(16, 194);
            telefon1Label.Name = "telefon1Label";
            telefon1Label.Size = new System.Drawing.Size(46, 13);
            telefon1Label.TabIndex = 13;
            telefon1Label.Text = "Telefon:";
            // 
            // buch2020DataSet
            // 
            this.buch2020DataSet.DataSetName = "buch2020DataSet";
            this.buch2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            this.kundeBindingSource.DataSource = this.buch2020DataSet;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = this.kundeTableAdapter;
            this.tableAdapterManager.MediumTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Buch2020a.buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kundeBindingNavigator
            // 
            this.kundeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kundeBindingNavigator.BindingSource = this.kundeBindingSource;
            this.kundeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kundeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kundeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kundeBindingNavigatorSaveItem});
            this.kundeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kundeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kundeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kundeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kundeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kundeBindingNavigator.Name = "kundeBindingNavigator";
            this.kundeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kundeBindingNavigator.Size = new System.Drawing.Size(295, 25);
            this.kundeBindingNavigator.TabIndex = 0;
            this.kundeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // kundeBindingNavigatorSaveItem
            // 
            this.kundeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kundeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kundeBindingNavigatorSaveItem.Image")));
            this.kundeBindingNavigatorSaveItem.Name = "kundeBindingNavigatorSaveItem";
            this.kundeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kundeBindingNavigatorSaveItem.Text = "Daten speichern";
            this.kundeBindingNavigatorSaveItem.Click += new System.EventHandler(this.kundeBindingNavigatorSaveItem_Click);
            // 
            // kNummerTextBox
            // 
            this.kNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "kNummer", true));
            this.kNummerTextBox.Location = new System.Drawing.Point(116, 35);
            this.kNummerTextBox.Name = "kNummerTextBox";
            this.kNummerTextBox.ReadOnly = true;
            this.kNummerTextBox.Size = new System.Drawing.Size(167, 20);
            this.kNummerTextBox.TabIndex = 2;
            // 
            // kNameTextBox
            // 
            this.kNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "kName", true));
            this.kNameTextBox.Location = new System.Drawing.Point(116, 61);
            this.kNameTextBox.Name = "kNameTextBox";
            this.kNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.kNameTextBox.TabIndex = 4;
            this.kNameTextBox.Leave += new System.EventHandler(this.kNameTextBox_Leave);
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "vorname", true));
            this.vornameTextBox.Location = new System.Drawing.Point(116, 87);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(167, 20);
            this.vornameTextBox.TabIndex = 6;
            this.vornameTextBox.Leave += new System.EventHandler(this.vornameTextBox_Leave);
            // 
            // strasseTextBox
            // 
            this.strasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "strasse", true));
            this.strasseTextBox.Location = new System.Drawing.Point(116, 113);
            this.strasseTextBox.Name = "strasseTextBox";
            this.strasseTextBox.Size = new System.Drawing.Size(167, 20);
            this.strasseTextBox.TabIndex = 8;
            this.strasseTextBox.Leave += new System.EventHandler(this.strasseTextBox_Leave);
            // 
            // postleitzahlTextBox
            // 
            this.postleitzahlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "postleitzahl", true));
            this.postleitzahlTextBox.Location = new System.Drawing.Point(116, 139);
            this.postleitzahlTextBox.Name = "postleitzahlTextBox";
            this.postleitzahlTextBox.Size = new System.Drawing.Size(167, 20);
            this.postleitzahlTextBox.TabIndex = 10;
            this.postleitzahlTextBox.Leave += new System.EventHandler(this.postleitzahlTextBox_Leave);
            // 
            // ortTextBox
            // 
            this.ortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "ort", true));
            this.ortTextBox.Location = new System.Drawing.Point(116, 165);
            this.ortTextBox.Name = "ortTextBox";
            this.ortTextBox.Size = new System.Drawing.Size(167, 20);
            this.ortTextBox.TabIndex = 12;
            this.ortTextBox.Leave += new System.EventHandler(this.ortTextBox_Leave);
            // 
            // telefon1TextBox
            // 
            this.telefon1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "telefon1", true));
            this.telefon1TextBox.Location = new System.Drawing.Point(116, 191);
            this.telefon1TextBox.Name = "telefon1TextBox";
            this.telefon1TextBox.Size = new System.Drawing.Size(167, 20);
            this.telefon1TextBox.TabIndex = 14;
            this.telefon1TextBox.Leave += new System.EventHandler(this.telefon1TextBox_Leave);
            // 
            // frmEinzelansicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 234);
            this.Controls.Add(kNummerLabel);
            this.Controls.Add(this.kNummerTextBox);
            this.Controls.Add(kNameLabel);
            this.Controls.Add(this.kNameTextBox);
            this.Controls.Add(vornameLabel);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(strasseLabel);
            this.Controls.Add(this.strasseTextBox);
            this.Controls.Add(postleitzahlLabel);
            this.Controls.Add(this.postleitzahlTextBox);
            this.Controls.Add(ortLabel);
            this.Controls.Add(this.ortTextBox);
            this.Controls.Add(telefon1Label);
            this.Controls.Add(this.telefon1TextBox);
            this.Controls.Add(this.kundeBindingNavigator);
            this.Name = "frmEinzelansicht";
            this.Text = "Kunden-Einzelansicht";
            this.Load += new System.EventHandler(this.frmEinzelansicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingNavigator)).EndInit();
            this.kundeBindingNavigator.ResumeLayout(false);
            this.kundeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private buch2020DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kundeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kundeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kNummerTextBox;
        private System.Windows.Forms.TextBox kNameTextBox;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.TextBox strasseTextBox;
        private System.Windows.Forms.TextBox postleitzahlTextBox;
        private System.Windows.Forms.TextBox ortTextBox;
        private System.Windows.Forms.TextBox telefon1TextBox;
    }
}