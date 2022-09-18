
namespace JeniMobley
{
    partial class ModifyProduct
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
            this.searchBxAllParts = new System.Windows.Forms.TextBox();
            this.btnSearchAllParts = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAssociatedPartsTitle = new System.Windows.Forms.Label();
            this.labelAllPartsTitle = new System.Windows.Forms.Label();
            this.labelModifyProdTitle = new System.Windows.Forms.Label();
            this.dgvModAllParts = new System.Windows.Forms.DataGridView();
            this.dgvModAssocParts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxModID = new System.Windows.Forms.TextBox();
            this.textBoxModName = new System.Windows.Forms.TextBox();
            this.textBoxModInventory = new System.Windows.Forms.TextBox();
            this.textBoxModPrice = new System.Windows.Forms.TextBox();
            this.textBoxModMin = new System.Windows.Forms.TextBox();
            this.textBoxModMax = new System.Windows.Forms.TextBox();
            this.toolTipTextFields = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModAssocParts)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBxAllParts
            // 
            this.searchBxAllParts.Location = new System.Drawing.Point(770, 23);
            this.searchBxAllParts.Name = "searchBxAllParts";
            this.searchBxAllParts.Size = new System.Drawing.Size(203, 20);
            this.searchBxAllParts.TabIndex = 23;
            // 
            // btnSearchAllParts
            // 
            this.btnSearchAllParts.Location = new System.Drawing.Point(688, 21);
            this.btnSearchAllParts.Name = "btnSearchAllParts";
            this.btnSearchAllParts.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAllParts.TabIndex = 22;
            this.btnSearchAllParts.Text = "Search";
            this.btnSearchAllParts.UseVisualStyleBackColor = true;
            this.btnSearchAllParts.Click += new System.EventHandler(this.btnSearchAllParts_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(897, 590);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(815, 590);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(898, 546);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(898, 276);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelAssociatedPartsTitle
            // 
            this.labelAssociatedPartsTitle.AutoSize = true;
            this.labelAssociatedPartsTitle.Location = new System.Drawing.Point(375, 315);
            this.labelAssociatedPartsTitle.Name = "labelAssociatedPartsTitle";
            this.labelAssociatedPartsTitle.Size = new System.Drawing.Size(174, 13);
            this.labelAssociatedPartsTitle.TabIndex = 17;
            this.labelAssociatedPartsTitle.Text = "Parts Associated With This Product";
            // 
            // labelAllPartsTitle
            // 
            this.labelAllPartsTitle.AutoSize = true;
            this.labelAllPartsTitle.Location = new System.Drawing.Point(375, 42);
            this.labelAllPartsTitle.Name = "labelAllPartsTitle";
            this.labelAllPartsTitle.Size = new System.Drawing.Size(96, 13);
            this.labelAllPartsTitle.TabIndex = 16;
            this.labelAllPartsTitle.Text = "All Candidate Parts";
            // 
            // labelModifyProdTitle
            // 
            this.labelModifyProdTitle.AutoSize = true;
            this.labelModifyProdTitle.Location = new System.Drawing.Point(12, 13);
            this.labelModifyProdTitle.Name = "labelModifyProdTitle";
            this.labelModifyProdTitle.Size = new System.Drawing.Size(78, 13);
            this.labelModifyProdTitle.TabIndex = 15;
            this.labelModifyProdTitle.Text = "Modify Product";
            // 
            // dgvModAllParts
            // 
            this.dgvModAllParts.AllowUserToAddRows = false;
            this.dgvModAllParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModAllParts.Location = new System.Drawing.Point(375, 64);
            this.dgvModAllParts.Name = "dgvModAllParts";
            this.dgvModAllParts.ReadOnly = true;
            this.dgvModAllParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvModAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModAllParts.Size = new System.Drawing.Size(599, 206);
            this.dgvModAllParts.TabIndex = 24;
            this.dgvModAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModAllParts_CellClick);
            this.dgvModAllParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvModAllParts_DataBindingComplete);
            // 
            // dgvModAssocParts
            // 
            this.dgvModAssocParts.AllowUserToAddRows = false;
            this.dgvModAssocParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModAssocParts.Location = new System.Drawing.Point(375, 334);
            this.dgvModAssocParts.Name = "dgvModAssocParts";
            this.dgvModAssocParts.ReadOnly = true;
            this.dgvModAssocParts.RowHeadersVisible = false;
            this.dgvModAssocParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvModAssocParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModAssocParts.Size = new System.Drawing.Size(598, 206);
            this.dgvModAssocParts.TabIndex = 25;
            this.dgvModAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModAssocParts_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Inventory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Min:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Max:";
            // 
            // textBoxModID
            // 
            this.textBoxModID.Location = new System.Drawing.Point(105, 198);
            this.textBoxModID.Name = "textBoxModID";
            this.textBoxModID.ReadOnly = true;
            this.textBoxModID.Size = new System.Drawing.Size(136, 20);
            this.textBoxModID.TabIndex = 32;
            // 
            // textBoxModName
            // 
            this.textBoxModName.Location = new System.Drawing.Point(105, 224);
            this.textBoxModName.Name = "textBoxModName";
            this.textBoxModName.Size = new System.Drawing.Size(136, 20);
            this.textBoxModName.TabIndex = 33;
            this.toolTipTextFields.SetToolTip(this.textBoxModName, "Please enter a product name.");
            this.textBoxModName.TextChanged += new System.EventHandler(this.textBoxModName_TextChanged);
            // 
            // textBoxModInventory
            // 
            this.textBoxModInventory.Location = new System.Drawing.Point(105, 250);
            this.textBoxModInventory.Name = "textBoxModInventory";
            this.textBoxModInventory.Size = new System.Drawing.Size(136, 20);
            this.textBoxModInventory.TabIndex = 34;
            this.toolTipTextFields.SetToolTip(this.textBoxModInventory, "Enter a number value.");
            this.textBoxModInventory.TextChanged += new System.EventHandler(this.textBoxModInventory_TextChanged);
            // 
            // textBoxModPrice
            // 
            this.textBoxModPrice.Location = new System.Drawing.Point(105, 276);
            this.textBoxModPrice.Name = "textBoxModPrice";
            this.textBoxModPrice.Size = new System.Drawing.Size(136, 20);
            this.textBoxModPrice.TabIndex = 35;
            this.toolTipTextFields.SetToolTip(this.textBoxModPrice, "Enter a decimal value.");
            this.textBoxModPrice.TextChanged += new System.EventHandler(this.textBoxModPrice_TextChanged);
            // 
            // textBoxModMin
            // 
            this.textBoxModMin.Location = new System.Drawing.Point(105, 302);
            this.textBoxModMin.Name = "textBoxModMin";
            this.textBoxModMin.Size = new System.Drawing.Size(62, 20);
            this.textBoxModMin.TabIndex = 36;
            this.toolTipTextFields.SetToolTip(this.textBoxModMin, "Enter a number value.");
            this.textBoxModMin.TextChanged += new System.EventHandler(this.textBoxModMin_TextChanged);
            // 
            // textBoxModMax
            // 
            this.textBoxModMax.Location = new System.Drawing.Point(268, 302);
            this.textBoxModMax.Name = "textBoxModMax";
            this.textBoxModMax.Size = new System.Drawing.Size(62, 20);
            this.textBoxModMax.TabIndex = 37;
            this.toolTipTextFields.SetToolTip(this.textBoxModMax, "Enter a number value.");
            this.textBoxModMax.TextChanged += new System.EventHandler(this.textBoxModMax_TextChanged);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 628);
            this.Controls.Add(this.textBoxModMax);
            this.Controls.Add(this.textBoxModMin);
            this.Controls.Add(this.textBoxModPrice);
            this.Controls.Add(this.textBoxModInventory);
            this.Controls.Add(this.textBoxModName);
            this.Controls.Add(this.textBoxModID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvModAssocParts);
            this.Controls.Add(this.dgvModAllParts);
            this.Controls.Add(this.searchBxAllParts);
            this.Controls.Add(this.btnSearchAllParts);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAssociatedPartsTitle);
            this.Controls.Add(this.labelAllPartsTitle);
            this.Controls.Add(this.labelModifyProdTitle);
            this.Name = "ModifyProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModAssocParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBxAllParts;
        private System.Windows.Forms.Button btnSearchAllParts;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAssociatedPartsTitle;
        private System.Windows.Forms.Label labelAllPartsTitle;
        private System.Windows.Forms.Label labelModifyProdTitle;
        private System.Windows.Forms.DataGridView dgvModAllParts;
        private System.Windows.Forms.DataGridView dgvModAssocParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxModID;
        private System.Windows.Forms.TextBox textBoxModName;
        private System.Windows.Forms.TextBox textBoxModInventory;
        private System.Windows.Forms.TextBox textBoxModPrice;
        private System.Windows.Forms.TextBox textBoxModMin;
        private System.Windows.Forms.TextBox textBoxModMax;
        private System.Windows.Forms.ToolTip toolTipTextFields;
    }
}