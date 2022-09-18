
namespace JeniMobley
{
    partial class AddProduct
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productInStockLabel;
            System.Windows.Forms.Label productMaxLabel;
            System.Windows.Forms.Label productMinLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productPriceLabel;
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.labelAddProdTitle = new System.Windows.Forms.Label();
            this.labelAllPartsTitle = new System.Windows.Forms.Label();
            this.labelAssociatedPartsTitle = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.searchBxAllParts = new System.Windows.Forms.TextBox();
            this.btnSearchAllParts = new System.Windows.Forms.Button();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productInStockTextBox = new System.Windows.Forms.TextBox();
            this.productMaxTextBox = new System.Windows.Forms.TextBox();
            this.productMinTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.dgvAssocParts = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.toolTipAddProductTextFields = new System.Windows.Forms.ToolTip(this.components);
            productIDLabel = new System.Windows.Forms.Label();
            productInStockLabel = new System.Windows.Forms.Label();
            productMaxLabel = new System.Windows.Forms.Label();
            productMinLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssocParts)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(58, 205);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(21, 13);
            productIDLabel.TabIndex = 13;
            productIDLabel.Text = "ID:";
            // 
            // productInStockLabel
            // 
            productInStockLabel.AutoSize = true;
            productInStockLabel.Location = new System.Drawing.Point(29, 258);
            productInStockLabel.Name = "productInStockLabel";
            productInStockLabel.Size = new System.Drawing.Size(54, 13);
            productInStockLabel.TabIndex = 15;
            productInStockLabel.Text = "Inventory:";
            // 
            // productMaxLabel
            // 
            productMaxLabel.AutoSize = true;
            productMaxLabel.Location = new System.Drawing.Point(184, 310);
            productMaxLabel.Name = "productMaxLabel";
            productMaxLabel.Size = new System.Drawing.Size(30, 13);
            productMaxLabel.TabIndex = 17;
            productMaxLabel.Text = "Max:";
            // 
            // productMinLabel
            // 
            productMinLabel.AutoSize = true;
            productMinLabel.Location = new System.Drawing.Point(41, 307);
            productMinLabel.Name = "productMinLabel";
            productMinLabel.Size = new System.Drawing.Size(30, 13);
            productMinLabel.TabIndex = 19;
            productMinLabel.Text = " Min:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(41, 231);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(38, 13);
            productNameLabel.TabIndex = 21;
            productNameLabel.Text = "Name:";
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Location = new System.Drawing.Point(45, 281);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new System.Drawing.Size(34, 13);
            productPriceLabel.TabIndex = 23;
            productPriceLabel.Text = "Price:";
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.AllowUserToAddRows = false;
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(343, 66);
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.ReadOnly = true;
            this.dgvAllParts.RowHeadersVisible = false;
            this.dgvAllParts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllParts.Size = new System.Drawing.Size(598, 209);
            this.dgvAllParts.TabIndex = 0;
            this.dgvAllParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAllParts_DataBindingComplete);
            // 
            // labelAddProdTitle
            // 
            this.labelAddProdTitle.AutoSize = true;
            this.labelAddProdTitle.Location = new System.Drawing.Point(13, 13);
            this.labelAddProdTitle.Name = "labelAddProdTitle";
            this.labelAddProdTitle.Size = new System.Drawing.Size(66, 13);
            this.labelAddProdTitle.TabIndex = 2;
            this.labelAddProdTitle.Text = "Add Product";
            // 
            // labelAllPartsTitle
            // 
            this.labelAllPartsTitle.AutoSize = true;
            this.labelAllPartsTitle.Location = new System.Drawing.Point(343, 47);
            this.labelAllPartsTitle.Name = "labelAllPartsTitle";
            this.labelAllPartsTitle.Size = new System.Drawing.Size(96, 13);
            this.labelAllPartsTitle.TabIndex = 3;
            this.labelAllPartsTitle.Text = "All Candidate Parts";
            // 
            // labelAssociatedPartsTitle
            // 
            this.labelAssociatedPartsTitle.AutoSize = true;
            this.labelAssociatedPartsTitle.Location = new System.Drawing.Point(343, 311);
            this.labelAssociatedPartsTitle.Name = "labelAssociatedPartsTitle";
            this.labelAssociatedPartsTitle.Size = new System.Drawing.Size(174, 13);
            this.labelAssociatedPartsTitle.TabIndex = 4;
            this.labelAssociatedPartsTitle.Text = "Parts Associated With This Product";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(866, 542);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(784, 592);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(866, 592);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // searchBxAllParts
            // 
            this.searchBxAllParts.Location = new System.Drawing.Point(738, 28);
            this.searchBxAllParts.Name = "searchBxAllParts";
            this.searchBxAllParts.Size = new System.Drawing.Size(203, 20);
            this.searchBxAllParts.TabIndex = 7;
            // 
            // btnSearchAllParts
            // 
            this.btnSearchAllParts.Location = new System.Drawing.Point(656, 26);
            this.btnSearchAllParts.Name = "btnSearchAllParts";
            this.btnSearchAllParts.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAllParts.TabIndex = 8;
            this.btnSearchAllParts.Text = "Search";
            this.btnSearchAllParts.UseVisualStyleBackColor = true;
            this.btnSearchAllParts.Click += new System.EventHandler(this.btnSearchAllParts_Click);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(105, 203);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(138, 20);
            this.productIDTextBox.TabIndex = 1;
            // 
            // productInStockTextBox
            // 
            this.productInStockTextBox.Location = new System.Drawing.Point(105, 255);
            this.productInStockTextBox.Name = "productInStockTextBox";
            this.productInStockTextBox.Size = new System.Drawing.Size(138, 20);
            this.productInStockTextBox.TabIndex = 3;
            this.toolTipAddProductTextFields.SetToolTip(this.productInStockTextBox, "Please enter a number value.");
            this.productInStockTextBox.TextChanged += new System.EventHandler(this.productInStockTextBox_TextChanged);
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Location = new System.Drawing.Point(244, 307);
            this.productMaxTextBox.Name = "productMaxTextBox";
            this.productMaxTextBox.Size = new System.Drawing.Size(58, 20);
            this.productMaxTextBox.TabIndex = 6;
            this.toolTipAddProductTextFields.SetToolTip(this.productMaxTextBox, "Please enter a number value.");
            this.productMaxTextBox.TextChanged += new System.EventHandler(this.productMaxTextBox_TextChanged);
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Location = new System.Drawing.Point(105, 306);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(55, 20);
            this.productMinTextBox.TabIndex = 5;
            this.toolTipAddProductTextFields.SetToolTip(this.productMinTextBox, "Please enter a number value.");
            this.productMinTextBox.TextChanged += new System.EventHandler(this.productMinTextBox_TextChanged);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(105, 229);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.productNameTextBox.TabIndex = 2;
            this.toolTipAddProductTextFields.SetToolTip(this.productNameTextBox, "Please enter a product name.");
            this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged);
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(105, 279);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(138, 20);
            this.productPriceTextBox.TabIndex = 4;
            this.toolTipAddProductTextFields.SetToolTip(this.productPriceTextBox, "Please enter a dollar value.");
            this.productPriceTextBox.TextChanged += new System.EventHandler(this.productPriceTextBox_TextChanged);
            // 
            // dgvAssocParts
            // 
            this.dgvAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssocParts.Location = new System.Drawing.Point(346, 328);
            this.dgvAssocParts.Name = "dgvAssocParts";
            this.dgvAssocParts.RowHeadersVisible = false;
            this.dgvAssocParts.RowTemplate.ReadOnly = true;
            this.dgvAssocParts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssocParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAssocParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssocParts.Size = new System.Drawing.Size(595, 208);
            this.dgvAssocParts.TabIndex = 25;
            this.dgvAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssocParts_CellClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(866, 281);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 629);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgvAssocParts);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(productInStockLabel);
            this.Controls.Add(this.productInStockTextBox);
            this.Controls.Add(productMaxLabel);
            this.Controls.Add(this.productMaxTextBox);
            this.Controls.Add(productMinLabel);
            this.Controls.Add(this.productMinTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(productPriceLabel);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.searchBxAllParts);
            this.Controls.Add(this.btnSearchAllParts);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelAssociatedPartsTitle);
            this.Controls.Add(this.labelAllPartsTitle);
            this.Controls.Add(this.labelAddProdTitle);
            this.Controls.Add(this.dgvAllParts);
            this.Name = "AddProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssocParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllParts;
        private System.Windows.Forms.Label labelAddProdTitle;
        private System.Windows.Forms.Label labelAllPartsTitle;
        private System.Windows.Forms.Label labelAssociatedPartsTitle;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox searchBxAllParts;
        private System.Windows.Forms.Button btnSearchAllParts;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productInStockTextBox;
        private System.Windows.Forms.TextBox productMaxTextBox;
        private System.Windows.Forms.TextBox productMinTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.DataGridView dgvAssocParts;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ToolTip toolTipAddProductTextFields;
    }
}