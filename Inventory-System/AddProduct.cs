using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeniMobley
{
    public partial class AddProduct : Form
    {
       
        MainScreen mainForm = new MainScreen();

        Product addMyProduct = new Product();

        bool _addProductName = false;

        bool _addProductInventory = false;

        bool _addProductPrice = false;

        bool _addProductMin = false;

        bool _addProductMax = false;

        public AddProduct()
        {            
            InitializeComponent();

            //Set data source for top grid.
            dgvAllParts.DataSource = Inventory.AllParts;

            //Format top datagridview.
            dgvAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvAllParts.MultiSelect = false;

            dgvAllParts.AllowUserToAddRows = false;

            dgvAllParts.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            dgvAllParts.DefaultCellStyle.SelectionForeColor = Color.White;

            //Set data source for bottom grid.
            addMyProduct.AssociatedParts = new BindingList<Part>(); 

            dgvAssocParts.DataSource = addMyProduct.AssociatedParts; 

            //Format bottom datagridview.
            dgvAssocParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvAssocParts.MultiSelect = false;

            dgvAssocParts.AllowUserToAddRows = false;

            dgvAssocParts.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            dgvAssocParts.DefaultCellStyle.SelectionForeColor = Color.White;

            //Format text box fields
            productNameTextBox.BackColor = Color.IndianRed;

            productInStockTextBox.BackColor = Color.IndianRed;

            productPriceTextBox.BackColor = Color.IndianRed;

            productMinTextBox.BackColor = Color.IndianRed;

            productMaxTextBox.BackColor = Color.IndianRed;

            //Disable save button until each textbox condition(s) have been met.
            buttonSave.Enabled = false;
        }

        //Save data in textbox
        private bool canSave()
        {
            if ((_addProductName == true) &&

                (_addProductInventory == true) &&

                (_addProductPrice == true) &&

                (_addProductMin == true) &&

                (_addProductMax == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgvAllParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAllParts.ClearSelection();
        }
        
        private void dgvAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                Inventory.SelectedPartIndex = e.RowIndex;

                Inventory.SelectedPartIndex = (int)dgvAllParts.Rows[Inventory.SelectedPartIndex].Cells[0].Value;
            }
        }

        private void dgvAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                Product.CurrentAssocPartIndex = e.RowIndex;

                Product.CurrentAssocPartIndex = (int)dgvAssocParts.Rows[Product.CurrentAssocPartIndex].Cells[0].Value;
            }
        }

        #region TextBox Fields
        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productNameTextBox.Text))
            {
                productNameTextBox.BackColor = Color.IndianRed;

                _addProductName = false;
            }
            else
            {
                productNameTextBox.BackColor = Color.White;

                _addProductName = true;
            }

            buttonSave.Enabled = canSave();
        }
        
        private void productInStockTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productInStockTextBox.Text) || (!Int32.TryParse(productInStockTextBox.Text, out _)))
            {
                productInStockTextBox.BackColor = Color.IndianRed;

                _addProductInventory = false;
            }
            else
            {
                productInStockTextBox.BackColor = Color.White;

                _addProductInventory = true;
            }

            buttonSave.Enabled = canSave();
        }
        
        private void productPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productPriceTextBox.Text) || (!Decimal.TryParse(productPriceTextBox.Text, out _)))
            {
                productPriceTextBox.BackColor = Color.IndianRed;

                _addProductPrice = false;
            }
            else
            {
                productPriceTextBox.BackColor = Color.White;

                _addProductPrice = true;
            }

            buttonSave.Enabled = canSave();
        }

        private void productMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productMinTextBox.Text) || (!Int32.TryParse(productMinTextBox.Text, out _)))
            {
                productMinTextBox.BackColor = Color.IndianRed;

                _addProductMin = false;
            }
            else
            {
                productMinTextBox.BackColor = Color.White;

                _addProductMin = true;
            }

            buttonSave.Enabled = canSave();
        }

        private void productMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productMaxTextBox.Text) || (!Int32.TryParse(productMaxTextBox.Text, out _)))
            {
                productMaxTextBox.BackColor = Color.IndianRed;

                _addProductMax = false;              
            }
            else
            {
                productMaxTextBox.BackColor = Color.White;
                _addProductMax = true;
            }

            buttonSave.Enabled = canSave();
        }
        #endregion

        #region Buttons
        //Can search by ID and name.
        private void btnSearchAllParts_Click(object sender, EventArgs e)
        {
            dgvAllParts.ClearSelection();

            bool found = false;

            if (searchBxAllParts.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID.ToString().Contains(searchBxAllParts.Text.ToString())

                        || Inventory.AllParts[i].Name.ToUpper().Contains(searchBxAllParts.Text.ToUpper()))
                    {
                        dgvAllParts.Rows[i].Selected = true;

                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");

                return;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!dgvAllParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part.");
                return;
            }
            else
            {
                Part part = (Part)dgvAllParts.CurrentRow.DataBoundItem;

                addMyProduct.AddAssociatedPart(part);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {                
                if (dgvAssocParts.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this associated part?", "Message", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Part part = (Part)dgvAssocParts.CurrentRow.DataBoundItem;

                        addMyProduct.RemoveAssociatedPart(part);
                    }
                    else
                    {
                        MessageBox.Show("Please select an associated part to delete.", "Message", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            catch (IndexOutOfRangeException ex) 
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Grab data from textboxes.
            string productName = productNameTextBox.Text.ToString();

            int productInventory = Convert.ToInt32(productInStockTextBox.Text);

            decimal productPrice = Convert.ToDecimal(productPriceTextBox.Text);

            int productMin = Convert.ToInt32(productMinTextBox.Text);

            int productMax = Convert.ToInt32(productMaxTextBox.Text);
            
            try
            {
                productName = productNameTextBox.Text.ToString();

                productInventory = Convert.ToInt32(productInStockTextBox.Text);

                productPrice = Convert.ToDecimal(productPriceTextBox.Text);

                productMin = Convert.ToInt32(productMinTextBox.Text);

                productMax = Convert.ToInt32(productMaxTextBox.Text);

            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Min value must be less than Max value.", "Message", MessageBoxButtons.OK);
                return;
            }
            
            //Create new product.
            addMyProduct = new Product(productName, productInventory, productPrice, productMin, productMax);

            //Save each selected part and add it to the product.
            foreach (DataGridViewRow row in dgvAssocParts.Rows)
            {
                Part part = (Part)row.DataBoundItem;

                addMyProduct.AssociatedParts.Add(part);

            }
            Inventory.AddProduct(addMyProduct);

            buttonSave.Enabled = canSave();

            this.Close();

            mainForm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            mainForm.Show();
        }
        #endregion
    }
}
