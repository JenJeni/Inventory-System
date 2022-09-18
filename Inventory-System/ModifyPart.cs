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
    public partial class ModifyPart : Form
    {
        MainScreen mainForm = new MainScreen();

        private int _partId;

        bool _partNameOK = false;

        bool _partInventoryOK = false;

        bool _partPriceOK = false;

        bool _partMinOK = false;

        bool _partMaxOK = false;

        bool _partTypeOK = false;

        public ModifyPart() 
        {
            InitializeComponent();
        }

        public ModifyPart(int partId, Part part) 
        {
            InitializeComponent();

            _partId = partId;

            //partIDTextBox.Text = part.PartID.ToString();

            partNameTextBox.Text = part.Name;

            partInventoryTextBox.Text = part.Inventory.ToString();

            partPriceTextBox.Text = part.Price.ToString();

            partMinTextBox.Text = part.Min.ToString();

            partMaxTextBox.Text = part.Max.ToString();

            Inhouse inhouse = new Inhouse();

            Outsourced outsourced = new Outsourced();

            try
            {
                if (part is Inhouse)
                {
                    Inhouse partInhouse = (Inhouse)part;

                    partTypeTextBox.Text = partInhouse.MachineID.ToString();

                    radioButtonInhouse.Checked = true;
                }
            }
            catch (NullReferenceException) { }

            try
            {
                if (part is Outsourced)
                {
                    Outsourced partOutsourced = (Outsourced)part;

                    partTypeTextBox.Text = partOutsourced.CompanyName;

                    radioButtonOutsourced.Checked = true;
                }
            }
            catch (NullReferenceException) { }

            buttonSaveModPart.Enabled = false;
        }


        private void ModifyPart_Load(object sender, EventArgs e)
        {
        }

        private bool okToSave()
        {
            if ((_partNameOK == true) &&

                (_partInventoryOK == true) &&

                (_partPriceOK == true) &&

                (_partMinOK == true) &&

                (_partMaxOK == true) &&

                (_partTypeOK == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void radioButtonInhouse_CheckedChanged(object sender, EventArgs e)
        {
            int number;

            labelPartType.Text = "Machine ID:";

            if (string.IsNullOrWhiteSpace(partTypeTextBox.Text) || (!Int32.TryParse(partTypeTextBox.Text, out number)))
            {
                partTypeTextBox.BackColor = Color.IndianRed;

                _partTypeOK = false;

                //MessageBox.Show("Please enter a valid value for specified part type.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                partTypeTextBox.BackColor = Color.White;

                _partTypeOK = true;
            }

            buttonSaveModPart.Enabled = okToSave();
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            labelPartType.Text = "Company Name:";

            if (string.IsNullOrWhiteSpace(partTypeTextBox.Text))
            {
                partTypeTextBox.BackColor = Color.IndianRed;

                _partTypeOK = false;
            }
            else
            {
                partTypeTextBox.BackColor = Color.White;

                _partTypeOK = true;
            }

            buttonSaveModPart.Enabled = okToSave();
        }

        private void partNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partNameTextBox.Text))
            {
                partNameTextBox.BackColor = Color.IndianRed;

                _partNameOK = false;
            }
            else
            {
                partNameTextBox.BackColor = Color.White;

                _partNameOK = true;
            }

            buttonSaveModPart.Enabled = okToSave();
        }

        private void partInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partInventoryTextBox.Text) || (!Int32.TryParse(partInventoryTextBox.Text, out _)))
            {
                partInventoryTextBox.BackColor = Color.IndianRed;

                _partInventoryOK = false;
            }
            else
            {
                partInventoryTextBox.BackColor = Color.White;

                _partInventoryOK = true;
            }

            buttonSaveModPart.Enabled = okToSave();
        }

        private void partPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal decValue;

            if (string.IsNullOrWhiteSpace(partPriceTextBox.Text) || (!Decimal.TryParse(partPriceTextBox.Text, out decValue)))
            {
                partPriceTextBox.BackColor = Color.IndianRed;

                _partPriceOK = false;
            }
            else
            {
                partPriceTextBox.BackColor = Color.White;

                _partPriceOK = true;
            }
            buttonSaveModPart.Enabled = okToSave();
        }

        private void partMinTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;

            if (string.IsNullOrWhiteSpace(partMinTextBox.Text) || (!Int32.TryParse(partMinTextBox.Text, out number)))
            {
                partMinTextBox.BackColor = Color.IndianRed;

                _partMinOK = false;
            }
            else
            {
                partMinTextBox.BackColor = Color.White;

                _partMinOK = true;
            }

            buttonSaveModPart.Enabled = okToSave();
        }

        private void partMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;

            if (string.IsNullOrWhiteSpace(partMaxTextBox.Text) || (!Int32.TryParse(partMaxTextBox.Text, out number)))
            {
                partMaxTextBox.BackColor = Color.IndianRed;

                _partMaxOK = false;
            }
            else
            {
                partMaxTextBox.BackColor = Color.White;

                _partMaxOK = true;
            }

            buttonSaveModPart.Enabled = okToSave();
        }

        private void partTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            //int number;

           if (radioButtonInhouse.Checked)
            {
                if (string.IsNullOrWhiteSpace(partTypeTextBox.Text) || (!Int32.TryParse(partTypeTextBox.Text, out _)))
                {
                    partTypeTextBox.BackColor = Color.IndianRed;

                    _partTypeOK = false;
                }
                else
                {
                    partTypeTextBox.BackColor = Color.White;

                    _partTypeOK = true;
                }

                buttonSaveModPart.Enabled = okToSave();
            }

           if (radioButtonOutsourced.Checked)
            {
                if (string.IsNullOrWhiteSpace(partTypeTextBox.Text))
                {
                    partTypeTextBox.BackColor = Color.IndianRed;
                    _partTypeOK = false;
                }
                else
                {
                    partTypeTextBox.BackColor = Color.White;
                    _partTypeOK = true;
                }
                buttonSaveModPart.Enabled = okToSave();
            }           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButtonInhouse.Checked == true)
            {
                //int partId = Convert.ToInt32(partIDTextBox.Text);

                string partName = partNameTextBox.Text.ToString();

                int partInventory = Convert.ToInt32(partInventoryTextBox.Text);

                decimal partPrice = Convert.ToDecimal(partPriceTextBox.Text);

                int partMin = Convert.ToInt32(partMinTextBox.Text);

                int partMax = Convert.ToInt32(partMaxTextBox.Text);

                int machineID = Convert.ToInt32(partTypeTextBox.Text);

                try
                {
                    //partId = Convert.ToInt32(partIDTextBox.Text);

                    partName = partNameTextBox.Text;

                    partInventory = Convert.ToInt32(partInventoryTextBox.Text);

                    partPrice = Convert.ToDecimal(partPriceTextBox.Text);

                    partMin = Convert.ToInt32(partMinTextBox.Text);

                    partMax = Convert.ToInt32(partMaxTextBox.Text);

                    machineID = Convert.ToInt32(partTypeTextBox.Text);
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (partInventory < partMin)
                {
                    MessageBox.Show("Inventory value must be greater than Min value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ( partInventory > partMax)
                {
                    MessageBox.Show("Inventory value must be less than Max value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (partMin > partMax)
                {
                    MessageBox.Show("Min value must be less than Max value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Part partTypeOne = new Inhouse(partName, partInventory, partPrice, partMin, partMax, machineID);

                    Inventory.UpdatePart(Inventory.SelectedPartIndex, partTypeOne);
                }
                buttonSaveModPart.Enabled = okToSave();
            }

            if (radioButtonOutsourced.Checked == true)
            {
                string partName = partNameTextBox.Text.ToString();

                int partInventory = Convert.ToInt32(partInventoryTextBox.Text);

                decimal partPrice = Convert.ToDecimal(partPriceTextBox.Text);

                int partMin = Convert.ToInt32(partMinTextBox.Text);

                int partMax = Convert.ToInt32(partMaxTextBox.Text);

                string companyName = partTypeTextBox.Text.ToString();

                try
                {                    
                    partName = partNameTextBox.Text;

                    partInventory = Convert.ToInt32(partInventoryTextBox.Text);

                    partPrice = Convert.ToDecimal(partPriceTextBox.Text);

                    partMin = Convert.ToInt32(partMinTextBox.Text);

                    partMax = Convert.ToInt32(partMaxTextBox.Text);

                    companyName = partTypeTextBox.Text;
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (partInventory < partMin)
                {
                    MessageBox.Show("Inventory value must be greater than Min value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (partInventory > partMax)
                {
                    MessageBox.Show("Inventory value must be less than Max value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (partMin > partMax)
                {
                    MessageBox.Show("Min value must be less than Max value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Part partTypeTwo = new Outsourced(partName, partInventory, partPrice, partMin, partMax, companyName);  
                    
                    Inventory.UpdatePart(Inventory.SelectedPartIndex, partTypeTwo);
                }
                buttonSaveModPart.Enabled = okToSave();
            }
           
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
