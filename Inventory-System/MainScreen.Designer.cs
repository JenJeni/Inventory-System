
namespace JeniMobley
{
    partial class MainScreen
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.btnModifyProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelApplicationTitle = new System.Windows.Forms.Label();
            this.labelPartTitle = new System.Windows.Forms.Label();
            this.labelProdTitle = new System.Windows.Forms.Label();
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.btnSearchProd = new System.Windows.Forms.Button();
            this.searchBxPart = new System.Windows.Forms.TextBox();
            this.searchBxProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(12, 79);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(604, 282);
            this.dgvParts.TabIndex = 0;
            this.dgvParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvParts_DataBindingComplete);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(651, 79);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(604, 282);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProducts_DataBindingComplete);
            
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(378, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(459, 367);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(541, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDelProd
            // 
            this.btnDelProd.Location = new System.Drawing.Point(1180, 367);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(75, 23);
            this.btnDelProd.TabIndex = 7;
            this.btnDelProd.Text = "Delete";
            this.btnDelProd.UseVisualStyleBackColor = true;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelProd_Click);
            // 
            // btnModifyProd
            // 
            this.btnModifyProd.Location = new System.Drawing.Point(1099, 367);
            this.btnModifyProd.Name = "btnModifyProd";
            this.btnModifyProd.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProd.TabIndex = 6;
            this.btnModifyProd.Text = "Modify";
            this.btnModifyProd.UseVisualStyleBackColor = true;
            this.btnModifyProd.Click += new System.EventHandler(this.btnModifyProd_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(1018, 367);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 23);
            this.btnAddProd.TabIndex = 5;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1180, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelApplicationTitle
            // 
            this.labelApplicationTitle.AutoSize = true;
            this.labelApplicationTitle.Location = new System.Drawing.Point(13, 13);
            this.labelApplicationTitle.Name = "labelApplicationTitle";
            this.labelApplicationTitle.Size = new System.Drawing.Size(153, 13);
            this.labelApplicationTitle.TabIndex = 9;
            this.labelApplicationTitle.Text = "Inventory Management System";
            // 
            // labelPartTitle
            // 
            this.labelPartTitle.AutoSize = true;
            this.labelPartTitle.Location = new System.Drawing.Point(12, 60);
            this.labelPartTitle.Name = "labelPartTitle";
            this.labelPartTitle.Size = new System.Drawing.Size(31, 13);
            this.labelPartTitle.TabIndex = 10;
            this.labelPartTitle.Text = "Parts";
            // 
            // labelProdTitle
            // 
            this.labelProdTitle.AutoSize = true;
            this.labelProdTitle.Location = new System.Drawing.Point(651, 59);
            this.labelProdTitle.Name = "labelProdTitle";
            this.labelProdTitle.Size = new System.Drawing.Size(49, 13);
            this.labelProdTitle.TabIndex = 11;
            this.labelProdTitle.Text = "Products";
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.Location = new System.Drawing.Point(377, 42);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPart.TabIndex = 12;
            this.btnSearchPart.Text = "Search";
            this.btnSearchPart.UseVisualStyleBackColor = true;
            this.btnSearchPart.Click += new System.EventHandler(this.btnSearchPart_Click);
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.Location = new System.Drawing.Point(1018, 42);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProd.TabIndex = 13;
            this.btnSearchProd.Text = "Search";
            this.btnSearchProd.UseVisualStyleBackColor = true;
            this.btnSearchProd.Click += new System.EventHandler(this.btnSearchProd_Click);
            // 
            // searchBxPart
            // 
            this.searchBxPart.Location = new System.Drawing.Point(459, 44);
            this.searchBxPart.Name = "searchBxPart";
            this.searchBxPart.Size = new System.Drawing.Size(156, 20);
            this.searchBxPart.TabIndex = 14;
            // 
            // searchBxProd
            // 
            this.searchBxProd.Location = new System.Drawing.Point(1099, 44);
            this.searchBxProd.Name = "searchBxProd";
            this.searchBxProd.Size = new System.Drawing.Size(156, 20);
            this.searchBxProd.TabIndex = 15;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 465);
            this.Controls.Add(this.searchBxProd);
            this.Controls.Add(this.searchBxPart);
            this.Controls.Add(this.btnSearchProd);
            this.Controls.Add(this.btnSearchPart);
            this.Controls.Add(this.labelProdTitle);
            this.Controls.Add(this.labelPartTitle);
            this.Controls.Add(this.labelApplicationTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelProd);
            this.Controls.Add(this.btnModifyProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.Button btnModifyProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelApplicationTitle;
        private System.Windows.Forms.Label labelPartTitle;
        private System.Windows.Forms.Label labelProdTitle;
        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.Button btnSearchProd;
        private System.Windows.Forms.TextBox searchBxPart;
        private System.Windows.Forms.TextBox searchBxProd;
        public System.Windows.Forms.Button btnModify;
    }
}

