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
    public partial class AddPart : Form
    {
        MainScreen mainForm = new MainScreen();

        bool _addName = false;

        bool _addInventory = false;

        bool _addPrice = false;

        bool _addMinValue = false;

        bool _addMaxValue = false;

        bool _addPartType = false;

        public AddPart()
        {
            InitializeComponent();

            partNameTextBox.BackColor = Color.IndianRed;

            partInventoryTextBox.BackColor = Color.IndianRed;

            partPriceTextBox.BackColor = Color.IndianRed;

            partMinTextBox.BackColor = Color.IndianRed;

            partMaxTextBox.BackColor = Color.IndianRed;

            addPartTypeTextBox.BackColor = Color.IndianRed;

            buttonSave.Enabled = false;
        }

        //If text fields meet each condition, the part can be saved.
        private bool okToSave()
        {
            if ((_addName == true) &&

                (_addInventory == true) &&

                (_addPrice == true) &&

                (_addMinValue == true) &&

                (_addMaxValue == true) &&

                (_addPartType == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Checks radio button switch.
        private void radioButtonInhouse_CheckedChanged(object sender, EventArgs e)
        {            
            labelAddPartType.Text = "Machine ID:";

            if (string.IsNullOrWhiteSpace(addPartTypeTextBox.Text) || (!Int32.TryParse(addPartTypeTextBox.Text, out _)))
            {
                addPartTypeTextBox.BackColor = Color.IndianRed;

                _addPartType = false;

                //MessageBox.Show("Please enter a number value for specified part type.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addPartTypeTextBox.BackColor = Color.White;

                _addPartType = true;
            }

            buttonSave.Enabled = okToSave();
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            labelAddPartType.Text = "Company Name:";

            if (string.IsNullOrWhiteSpace(addPartTypeTextBox.Text))
            {
                addPartTypeTextBox.BackColor = Color.IndianRed;

                _addPartType = false;

                //MessageBox.Show("Please enter a company name for specified part type.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addPartTypeTextBox.BackColor = Color.White;

                _addPartType = true;
            }

            buttonSave.Enabled = okToSave();
        }

        //Checks whether name input is letters only; flag an error otherwise.
        private void partNameTextBox_TextChanged(object sender, EventArgs e)
        {            
            foreach (char name in partNameTextBox.Text)
            {
                if (!char.IsLetter(name))
                {
                    partNameTextBox.BackColor = Color.IndianRed;

                    _addName = false;

                    MessageBox.Show("Please enter a valid name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    partNameTextBox.BackColor = Color.White;

                    _addName = true;

                    return;
                }
            }
        }

        private void partInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partInventoryTextBox.Text) || (!Int32.TryParse(partInventoryTextBox.Text, out _)))
            {
                partInventoryTextBox.BackColor = Color.IndianRed;

                _addInventory = false;

                MessageBox.Show("Please enter a number value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                partInventoryTextBox.BackColor = Color.White;

                _addInventory = true;
            }

            buttonSave.Enabled = okToSave();
        }

        private void partPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partPriceTextBox.Text) || (!Decimal.TryParse(partPriceTextBox.Text, out _)))
            {
                partPriceTextBox.BackColor = Color.IndianRed;

                _addInventory = false;

                MessageBox.Show("Please enter a number value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {             
                partPriceTextBox.BackColor = Color.White;

                _addPrice = true;
            }

            buttonSave.Enabled = okToSave();
        }        

        private void partMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partMinTextBox.Text) || (!Int32.TryParse(partMinTextBox.Text, out _)))
            {
                partMinTextBox.BackColor = Color.IndianRed;

                _addMinValue = false;

                MessageBox.Show("Please enter a number value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                partMinTextBox.BackColor = Color.White;

                _addMinValue = true;

            }

            buttonSave.Enabled = okToSave();
        }

        private void partMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partMaxTextBox.Text) || (!Int32.TryParse(partMaxTextBox.Text, out _)))
            {
                partMaxTextBox.BackColor = Color.IndianRed;

                _addMaxValue = false;

                MessageBox.Show("Please enter a number value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                partMaxTextBox.BackColor = Color.White;

                _addMaxValue = true;
            }

            buttonSave.Enabled = okToSave();
        }

        //Part type changed.
        private void addPartTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonInhouse.Checked)
            {
                if (string.IsNullOrWhiteSpace(addPartTypeTextBox.Text) || (!Int32.TryParse(addPartTypeTextBox.Text, out _)))
                {
                    addPartTypeTextBox.BackColor = Color.IndianRed;

                    _addPartType = false;
                }
                else
                {
                    addPartTypeTextBox.BackColor = Color.White;

                    _addPartType = true;
                }

                buttonSave.Enabled = okToSave();
            }

            if (radioButtonOutsourced.Checked)
            {
                if (string.IsNullOrWhiteSpace(addPartTypeTextBox.Text))
                {
                    addPartTypeTextBox.BackColor = Color.IndianRed;

                    _addPartType = false;
                }
                else
                {
                    addPartTypeTextBox.BackColor = Color.White;

                    _addPartType = true;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButtonInhouse.Checked == true)
            {
                string partName = partNameTextBox.Text.ToString();

                int partInventory = Convert.ToInt32(partInventoryTextBox.Text);

                decimal partPrice = Convert.ToDecimal(partPriceTextBox.Text);

                int partMin = Convert.ToInt32(partMinTextBox.Text);

                int partMax = Convert.ToInt32(partMaxTextBox.Text);

                int machineID = Convert.ToInt32(addPartTypeTextBox.Text);

                try
                {
                    partName = partNameTextBox.Text;

                    partInventory = Convert.ToInt32(partInventoryTextBox.Text);

                    partPrice = Convert.ToDecimal(partPriceTextBox.Text);

                    partMin = Convert.ToInt32(partMinTextBox.Text);

                    partMax = Convert.ToInt32(partMaxTextBox.Text);

                    machineID = Convert.ToInt32(addPartTypeTextBox.Text);
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
                    Part partTypeOne = new Inhouse(partName, partInventory, partPrice, partMin, partMax, machineID);

                    Inventory.AddPart(partTypeOne);
                }

                buttonSave.Enabled = okToSave();
            }

            if (radioButtonOutsourced.Checked == true)
            {
                string partName = partNameTextBox.Text.ToString();

                int partInventory = Convert.ToInt32(partInventoryTextBox.Text);

                decimal partPrice = Convert.ToDecimal(partPriceTextBox.Text);

                int partMin = Convert.ToInt32(partMinTextBox.Text);

                int partMax = Convert.ToInt32(partMaxTextBox.Text);

                string companyName = addPartTypeTextBox.Text.ToString();

                try
                {
                    partName = partNameTextBox.Text;

                    partInventory = Convert.ToInt32(partInventoryTextBox.Text);

                    partPrice = Convert.ToDecimal(partPriceTextBox.Text);

                    partMin = Convert.ToInt32(partMinTextBox.Text);

                    partMax = Convert.ToInt32(partMaxTextBox.Text);

                    companyName = addPartTypeTextBox.Text;
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

                    Inventory.AddPart(partTypeTwo);
                }

                buttonSave.Enabled = okToSave();
            }

            this.Close();
            //mainForm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }
    }
}
