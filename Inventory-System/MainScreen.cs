
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeniMobley
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            //Set part data source.
            dgvParts.DataSource = Inventory.AllParts;

            //Format  all parts dgv.
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvParts.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            dgvParts.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvParts.RowHeadersVisible = false;

            //Set product data source.           
            dgvProducts.DataSource = Inventory.Products;

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.White;    
            
            dgvProducts.RowHeadersVisible = false;            
        }

        //Clears selection.
        private void dgvParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
        }

        private void dgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();
        }

        //Highlight selected row.
        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                Inventory.SelectedPartIndex = e.RowIndex;

                Inventory.SelectedPartIndex = (int)dgvParts.Rows[Inventory.SelectedPartIndex].Cells[0].Value;

                Inventory.LookupPart(Inventory.SelectedPartIndex);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {               
                Inventory.SelectedProductIndex = (int)dgvProducts.Rows[Inventory.SelectedProductIndex].Cells[0].Value;
            }            
        }

        //Add part/product.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            AddPart addPart = new AddPart();

            addPart.Show();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {

            this.Hide();

            AddProduct addProduct = new AddProduct();

            addProduct.Show();
        }

        //Modify part/product.
        public void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvParts.SelectedRows.Count > 0)
            {
                var selectedPart = (Part)dgvParts.CurrentRow.DataBoundItem;

                var index = dgvParts.CurrentCell.RowIndex;

                this.Hide();

                ModifyPart modPartForm = new ModifyPart(index, selectedPart);

                modPartForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a part to modify.", "Message", MessageBoxButtons.OK);

                return;
            }
        }

        private void btnModifyProd_Click(object sender, EventArgs e)
        {

            if (dgvProducts.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
                
                var index = dgvProducts.CurrentCell.RowIndex;

                this.Hide();

                ModifyProduct modifyProduct = new ModifyProduct(index, selectedProduct);

                modifyProduct.Show();
            }
            else
            {
                MessageBox.Show("Please select a product to modify.", "Message", MessageBoxButtons.OK);

                return;
            }
        }

        //Delete part/product.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvParts.CurrentRow != null || dgvParts.CurrentRow.Selected)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        int partID = Convert.ToInt32(dgvParts.SelectedRows[0].Cells[0].Value);

                        var selectedPart = Inventory.LookupPart(partID);

                        Inventory.DeletePart(partID);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a part to delete.", "Message", MessageBoxButtons.OK);

                    return;
                }
            }
            catch (IndexOutOfRangeException re)
            {
                MessageBox.Show(re.Message);
            }
        }

        private void btnDelProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        int productId = (int)dgvProducts.SelectedRows[0].Cells[0].Value;

                        var productDelete = Inventory.LookupProduct(productId);

                        var partsCount = productDelete.AssociatedParts.Count;

                        if (partsCount > 0)
                        {
                            MessageBox.Show("Must disassociate part(s) from product before deleting product.", "Message", MessageBoxButtons.OK);

                            return;
                        }

                        Inventory.RemoveProduct(productId);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to delete.", "Message", MessageBoxButtons.OK);

                    return;
                }
            }
            catch (ArgumentOutOfRangeException re)
            {
                MessageBox.Show(re.Message);
            }
        }

        //Can search part/product by ID and name.
        private void btnSearchPart_Click(object sender, EventArgs e)
        {
            dgvParts.ClearSelection();

            bool found = false;

            if (searchBxPart.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID.ToString().Contains(searchBxPart.Text.ToString()) 

                        || Inventory.AllParts[i].Name.ToUpper().Contains(searchBxPart.Text.ToUpper()))
                    {
                        dgvParts.Rows[i].Selected = true;

                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void btnSearchProd_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            
            bool found = false;

            if (searchBxProd.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].ProductID.ToString().Contains(searchBxProd.Text.ToString()) 

                        || Inventory.Products[i].Name.ToUpper().Contains(searchBxProd.Text.ToUpper()))
                    {
                        dgvProducts.Rows[i].Selected = true;

                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}
