
namespace JeniMobley
{
    partial class ModifyPart
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
            System.Windows.Forms.Label partIDLabel;
            System.Windows.Forms.Label partInventoryLabel;
            System.Windows.Forms.Label partMaxLabel;
            System.Windows.Forms.Label partMinLabel;
            System.Windows.Forms.Label partNameLabel;
            System.Windows.Forms.Label partPriceLabel;
            this.buttonCancelModPart = new System.Windows.Forms.Button();
            this.buttonSaveModPart = new System.Windows.Forms.Button();
            this.radioButtonOutsourced = new System.Windows.Forms.RadioButton();
            this.radioButtonInhouse = new System.Windows.Forms.RadioButton();
            this.labelModifyPartTitle = new System.Windows.Forms.Label();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.partInventoryTextBox = new System.Windows.Forms.TextBox();
            this.partMaxTextBox = new System.Windows.Forms.TextBox();
            this.partMinTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partPriceTextBox = new System.Windows.Forms.TextBox();
            this.partTypeTextBox = new System.Windows.Forms.TextBox();
            this.labelPartType = new System.Windows.Forms.Label();
            partIDLabel = new System.Windows.Forms.Label();
            partInventoryLabel = new System.Windows.Forms.Label();
            partMaxLabel = new System.Windows.Forms.Label();
            partMinLabel = new System.Windows.Forms.Label();
            partNameLabel = new System.Windows.Forms.Label();
            partPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partIDLabel
            // 
            partIDLabel.AutoSize = true;
            partIDLabel.Location = new System.Drawing.Point(74, 92);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new System.Drawing.Size(21, 13);
            partIDLabel.TabIndex = 10;
            partIDLabel.Text = "ID:";
            // 
            // partInventoryLabel
            // 
            partInventoryLabel.AutoSize = true;
            partInventoryLabel.Location = new System.Drawing.Point(41, 150);
            partInventoryLabel.Name = "partInventoryLabel";
            partInventoryLabel.Size = new System.Drawing.Size(54, 13);
            partInventoryLabel.TabIndex = 12;
            partInventoryLabel.Text = "Inventory:";
            // 
            // partMaxLabel
            // 
            partMaxLabel.AutoSize = true;
            partMaxLabel.Location = new System.Drawing.Point(248, 205);
            partMaxLabel.Name = "partMaxLabel";
            partMaxLabel.Size = new System.Drawing.Size(30, 13);
            partMaxLabel.TabIndex = 14;
            partMaxLabel.Text = "Max:";
            // 
            // partMinLabel
            // 
            partMinLabel.AutoSize = true;
            partMinLabel.Location = new System.Drawing.Point(68, 205);
            partMinLabel.Name = "partMinLabel";
            partMinLabel.Size = new System.Drawing.Size(27, 13);
            partMinLabel.TabIndex = 16;
            partMinLabel.Text = "Min:";
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Location = new System.Drawing.Point(57, 120);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new System.Drawing.Size(38, 13);
            partNameLabel.TabIndex = 18;
            partNameLabel.Text = "Name:";
            // 
            // partPriceLabel
            // 
            partPriceLabel.AutoSize = true;
            partPriceLabel.Location = new System.Drawing.Point(61, 177);
            partPriceLabel.Name = "partPriceLabel";
            partPriceLabel.Size = new System.Drawing.Size(34, 13);
            partPriceLabel.TabIndex = 20;
            partPriceLabel.Text = "Price:";
            // 
            // buttonCancelModPart
            // 
            this.buttonCancelModPart.Location = new System.Drawing.Point(317, 300);
            this.buttonCancelModPart.Name = "buttonCancelModPart";
            this.buttonCancelModPart.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelModPart.TabIndex = 11;
            this.buttonCancelModPart.Text = "Cancel";
            this.buttonCancelModPart.UseVisualStyleBackColor = true;
            this.buttonCancelModPart.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSaveModPart
            // 
            this.buttonSaveModPart.Location = new System.Drawing.Point(236, 300);
            this.buttonSaveModPart.Name = "buttonSaveModPart";
            this.buttonSaveModPart.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveModPart.TabIndex = 10;
            this.buttonSaveModPart.Text = "Save";
            this.buttonSaveModPart.UseVisualStyleBackColor = true;
            this.buttonSaveModPart.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // radioButtonOutsourced
            // 
            this.radioButtonOutsourced.AutoSize = true;
            this.radioButtonOutsourced.Location = new System.Drawing.Point(261, 36);
            this.radioButtonOutsourced.Name = "radioButtonOutsourced";
            this.radioButtonOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioButtonOutsourced.TabIndex = 2;
            this.radioButtonOutsourced.TabStop = true;
            this.radioButtonOutsourced.Text = "Outsourced";
            this.radioButtonOutsourced.UseVisualStyleBackColor = true;
            this.radioButtonOutsourced.CheckedChanged += new System.EventHandler(this.radioButtonOutsourced_CheckedChanged);
            // 
            // radioButtonInhouse
            // 
            this.radioButtonInhouse.AutoSize = true;
            this.radioButtonInhouse.Location = new System.Drawing.Point(127, 36);
            this.radioButtonInhouse.Name = "radioButtonInhouse";
            this.radioButtonInhouse.Size = new System.Drawing.Size(68, 17);
            this.radioButtonInhouse.TabIndex = 1;
            this.radioButtonInhouse.TabStop = true;
            this.radioButtonInhouse.Text = "In-House";
            this.radioButtonInhouse.UseVisualStyleBackColor = true;
            this.radioButtonInhouse.CheckedChanged += new System.EventHandler(this.radioButtonInhouse_CheckedChanged);
            // 
            // labelModifyPartTitle
            // 
            this.labelModifyPartTitle.AutoSize = true;
            this.labelModifyPartTitle.Location = new System.Drawing.Point(12, 9);
            this.labelModifyPartTitle.Name = "labelModifyPartTitle";
            this.labelModifyPartTitle.Size = new System.Drawing.Size(60, 13);
            this.labelModifyPartTitle.TabIndex = 5;
            this.labelModifyPartTitle.Text = "Modify Part";
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.partIDTextBox.Location = new System.Drawing.Point(145, 89);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.ReadOnly = true;
            this.partIDTextBox.Size = new System.Drawing.Size(133, 20);
            this.partIDTextBox.TabIndex = 3;
            // 
            // partInventoryTextBox
            // 
            this.partInventoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.partInventoryTextBox.Location = new System.Drawing.Point(145, 147);
            this.partInventoryTextBox.Name = "partInventoryTextBox";
            this.partInventoryTextBox.Size = new System.Drawing.Size(133, 20);
            this.partInventoryTextBox.TabIndex = 5;
            this.partInventoryTextBox.TextChanged += new System.EventHandler(this.partInventoryTextBox_TextChanged);
            // 
            // partMaxTextBox
            // 
            this.partMaxTextBox.Location = new System.Drawing.Point(317, 202);
            this.partMaxTextBox.Name = "partMaxTextBox";
            this.partMaxTextBox.Size = new System.Drawing.Size(75, 20);
            this.partMaxTextBox.TabIndex = 8;
            this.partMaxTextBox.TextChanged += new System.EventHandler(this.partMaxTextBox_TextChanged);
            // 
            // partMinTextBox
            // 
            this.partMinTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.partMinTextBox.Location = new System.Drawing.Point(145, 202);
            this.partMinTextBox.Name = "partMinTextBox";
            this.partMinTextBox.Size = new System.Drawing.Size(72, 20);
            this.partMinTextBox.TabIndex = 7;
            this.partMinTextBox.TextChanged += new System.EventHandler(this.partMinTextBox_TextChanged);
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.partNameTextBox.Location = new System.Drawing.Point(145, 117);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(133, 20);
            this.partNameTextBox.TabIndex = 4;
            this.partNameTextBox.TextChanged += new System.EventHandler(this.partNameTextBox_TextChanged);
            // 
            // partPriceTextBox
            // 
            this.partPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.partPriceTextBox.Location = new System.Drawing.Point(145, 174);
            this.partPriceTextBox.Name = "partPriceTextBox";
            this.partPriceTextBox.Size = new System.Drawing.Size(133, 20);
            this.partPriceTextBox.TabIndex = 6;
            this.partPriceTextBox.TextChanged += new System.EventHandler(this.partPriceTextBox_TextChanged);
            
            // 
            // partTypeTextBox
            // 
            this.partTypeTextBox.Location = new System.Drawing.Point(145, 231);
            this.partTypeTextBox.Name = "partTypeTextBox";
            this.partTypeTextBox.Size = new System.Drawing.Size(133, 20);
            this.partTypeTextBox.TabIndex = 9;
            this.partTypeTextBox.TextChanged += new System.EventHandler(this.partTypeTextBox_TextChanged);
            // 
            // labelPartType
            // 
            this.labelPartType.AutoSize = true;
            this.labelPartType.Location = new System.Drawing.Point(30, 234);
            this.labelPartType.Name = "labelPartType";
            this.labelPartType.Size = new System.Drawing.Size(65, 13);
            this.labelPartType.TabIndex = 23;
            this.labelPartType.Text = "Machine ID:";
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 365);
            this.Controls.Add(this.labelPartType);
            this.Controls.Add(this.partTypeTextBox);
            this.Controls.Add(partIDLabel);
            this.Controls.Add(this.partIDTextBox);
            this.Controls.Add(partInventoryLabel);
            this.Controls.Add(this.partInventoryTextBox);
            this.Controls.Add(partMaxLabel);
            this.Controls.Add(this.partMaxTextBox);
            this.Controls.Add(partMinLabel);
            this.Controls.Add(this.partMinTextBox);
            this.Controls.Add(partNameLabel);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(partPriceLabel);
            this.Controls.Add(this.partPriceTextBox);
            this.Controls.Add(this.buttonCancelModPart);
            this.Controls.Add(this.buttonSaveModPart);
            this.Controls.Add(this.radioButtonOutsourced);
            this.Controls.Add(this.radioButtonInhouse);
            this.Controls.Add(this.labelModifyPartTitle);
            this.Name = "ModifyPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelModPart;
        private System.Windows.Forms.Button buttonSaveModPart;
        private System.Windows.Forms.RadioButton radioButtonOutsourced;
        private System.Windows.Forms.RadioButton radioButtonInhouse;
        private System.Windows.Forms.Label labelModifyPartTitle;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.TextBox partInventoryTextBox;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.TextBox partMinTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.TextBox partPriceTextBox;
        private System.Windows.Forms.TextBox partTypeTextBox;
        private System.Windows.Forms.Label labelPartType;
    }
}