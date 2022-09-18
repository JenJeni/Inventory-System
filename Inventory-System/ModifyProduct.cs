using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace JeniMobley
{
    public partial class ModifyProduct : Form
    {       
        //Set variables to check save conditions.
        private bool _modProductName = false;

        private bool _modProductInventory = false;

        private bool _modProductPrice = false;

        private bool _modProductMin = false;

        private bool _modProductMax = false;

        //Set main screen as variable for easier use.
        MainScreen mainForm = new MainScreen();

        //Create a product object.
        Product modifyMyProduct = new Product();

        public ModifyProduct() 
        {
            InitializeComponent();
        }

        public ModifyProduct(int index, Product product)
        {
            InitializeComponent();

            //Top grid data source.
            dgvModAllParts.DataSource = Inventory.AllParts;

            //Format tog grid.
            dgvModAllParts.MultiSelect = false;

            dgvModAllParts.AllowUserToAddRows = false;

            dgvModAllParts.RowHeadersVisible = false;

            dgvModAllParts.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            dgvModAllParts.DefaultCellStyle.SelectionForeColor = Color.White;

            //Bottom grid data source.
            dgvModAssocParts.DataSource = modifyMyProduct.AssociatedParts;

            //Format bottom grid.
            dgvModAssocParts.MultiSelect = false;

            dgvModAssocParts.AllowUserToAddRows = false;

            dgvModAssocParts.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            dgvModAssocParts.DefaultCellStyle.SelectionForeColor = Color.White;

            //Grab data from textbox fields.
            textBoxModID.Text = product.ProductID.ToString();

            textBoxModName.Text = product.Name;

            textBoxModInventory.Text = product.Stock.ToString();

            textBoxModPrice.Text = product.Price.ToString();

            textBoxModMin.Text = product.Min.ToString();

            textBoxModMax.Text = product.Max.ToString();


            for (int i = 0; i < product.AssociatedParts.Count; i++)
            {
                modifyMyProduct.AddAssociatedPart(product.AssociatedParts[i]);
            }

            buttonSave.Enabled = false;
        }

        //Allows modifications to be saved if all textbox conditions are met.
        private bool modSave()
        {
            if ((_modProductName == true) &&

                (_modProductInventory == true) &&

                (_modProductPrice == true) &&

                (_modProductMin == true) &&

                (_modProductMax == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgvModAllParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvModAllParts.ClearSelection();
        }

        private void dgvModAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                Inventory.SelectedPartIndex = e.RowIndex;
            }                             
        }

        private void dgvModAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product.CurrentAssocPartIndex = e.RowIndex;
            }
        }

        private void btnSearchAllParts_Click(object sender, EventArgs e)
        {
            dgvModAllParts.ClearSelection();

            bool found = false;

            if (searchBxAllParts.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID.ToString().Contains(searchBxAllParts.Text.ToString())

                        || Inventory.AllParts[i].Name.ToUpper().Contains(searchBxAllParts.Text.ToUpper()))
                    {
                        dgvModAllParts.Rows[i].Selected = true;

                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void textBoxModName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModName.Text))
            {
                textBoxModName.BackColor = Color.IndianRed;

                _modProductName = false;
            }
            else
            {
                textBoxModName.BackColor = Color.White;

                _modProductName = true;
            }

            buttonSave.Enabled = modSave();
        }

        private void textBoxModInventory_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModInventory.Text) || (!Int32.TryParse(textBoxModInventory.Text, out _)))
            {
                textBoxModInventory.BackColor = Color.IndianRed;

                _modProductInventory = false;
            }
            else
            {
                textBoxModInventory.BackColor = Color.White;

                _modProductInventory = true;
            }

            buttonSave.Enabled = modSave();
        }

        private void textBoxModPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModPrice.Text) || (!Decimal.TryParse(textBoxModPrice.Text, out _)))
            {
                textBoxModPrice.BackColor = Color.IndianRed;

                _modProductPrice = false;
            }
            else
            {
                textBoxModPrice.BackColor = Color.White;

                _modProductPrice = true;
            }

            buttonSave.Enabled = modSave();
        }

        private void textBoxModMin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModMin.Text) || (!Int32.TryParse(textBoxModMin.Text, out _)))
            {
                textBoxModMin.BackColor = Color.IndianRed;

                _modProductMin = false;
            }
            else
            {
                textBoxModMin.BackColor = Color.White;

                _modProductMin = true;
            }

            buttonSave.Enabled = modSave();
        }

        private void textBoxModMax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModMax.Text) || (!Int32.TryParse(textBoxModMax.Text, out _)))
            {
                textBoxModMax.BackColor = Color.IndianRed;

                _modProductMax = false;

            }
            else
            {
                textBoxModMax.BackColor = Color.White;

                _modProductMax = true;
            }

            buttonSave.Enabled = modSave();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!dgvModAllParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part.");

                return;
            }
            else
            {
                Part part = (Part)dgvModAllParts.CurrentRow.DataBoundItem;

                modifyMyProduct.AddAssociatedPart(part);
            }
        }
                   
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvModAssocParts.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this associated part?", "Message", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {                        
                        Part part = (Part)dgvModAssocParts.CurrentRow.DataBoundItem;

                        modifyMyProduct.RemoveAssociatedPart(part);
                    }
                    else
                    {
                        MessageBox.Show("Please select an associated part to delete.", "Message", MessageBoxButtons.OK);

                        return;
                    }
                }
            }
            catch (ArgumentOutOfRangeException ar)
            {
                MessageBox.Show(ar.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string productName;

            int productInventory;

            decimal productPrice;

            int productMin;

            int productMax;

            try
            {
                productName = textBoxModName.Text.ToString();

                productInventory = Convert.ToInt32(textBoxModInventory.Text);

                productPrice = Convert.ToDecimal(textBoxModPrice.Text);

                productMin = Convert.ToInt32(textBoxModMin.Text);

                productMax = Convert.ToInt32(textBoxModMax.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

                return;
            }

            if (productInventory < productMin)
            {
                MessageBox.Show("Inventory value must be greater than Min value.", "Message", MessageBoxButtons.OK);

                return;
            }
            else if (productInventory > productMax)
            {
                MessageBox.Show("Inventory value must be less than Max value.", "Message", MessageBoxButtons.OK);

                return;
            }
            else if (productMin > productMax)
            {
                MessageBox.Show("Min value exceeds Max value.", "Message", MessageBoxButtons.OK);

                return;
            }

            int productID = Convert.ToInt32(textBoxModID.Text);

            //Create new product.
            modifyMyProduct.ProductID = productID; 

            modifyMyProduct.Name = productName;

            modifyMyProduct.Stock = productInventory;

            modifyMyProduct.Price = productPrice;

            modifyMyProduct.Min = productMin;

            modifyMyProduct.Max = productMax;

            Inventory.UpdateProduct(Inventory.SelectedProductIndex, modifyMyProduct);

            //Enable save and return to main screen.
            buttonSave.Enabled = modSave();

            this.Close();

            mainForm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            mainForm.Show();
        }
    }
}
