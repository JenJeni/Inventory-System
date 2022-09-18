
namespace JeniMobley
{
    partial class AddPart
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
            this.labelAddPartTitle = new System.Windows.Forms.Label();
            this.radioButtonInhouse = new System.Windows.Forms.RadioButton();
            this.radioButtonOutsourced = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.partInventoryTextBox = new System.Windows.Forms.TextBox();
            this.partMaxTextBox = new System.Windows.Forms.TextBox();
            this.partMinTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partPriceTextBox = new System.Windows.Forms.TextBox();
            this.labelAddPartType = new System.Windows.Forms.Label();
            this.addPartTypeTextBox = new System.Windows.Forms.TextBox();
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
            partIDLabel.Location = new System.Drawing.Point(61, 104);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new System.Drawing.Size(21, 13);
            partIDLabel.TabIndex = 6;
            partIDLabel.Text = "ID:";
            // 
            // partInventoryLabel
            // 
            partInventoryLabel.AutoSize = true;
            partInventoryLabel.Location = new System.Drawing.Point(28, 155);
            partInventoryLabel.Name = "partInventoryLabel";
            partInventoryLabel.Size = new System.Drawing.Size(54, 13);
            partInventoryLabel.TabIndex = 8;
            partInventoryLabel.Text = "Inventory:";
            // 
            // partMaxLabel
            // 
            partMaxLabel.AutoSize = true;
            partMaxLabel.Location = new System.Drawing.Point(252, 207);
            partMaxLabel.Name = "partMaxLabel";
            partMaxLabel.Size = new System.Drawing.Size(30, 13);
            partMaxLabel.TabIndex = 10;
            partMaxLabel.Text = "Max:";
            // 
            // partMinLabel
            // 
            partMinLabel.AutoSize = true;
            partMinLabel.Location = new System.Drawing.Point(55, 207);
            partMinLabel.Name = "partMinLabel";
            partMinLabel.Size = new System.Drawing.Size(27, 13);
            partMinLabel.TabIndex = 12;
            partMinLabel.Text = "Min:";
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Location = new System.Drawing.Point(44, 129);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new System.Drawing.Size(38, 13);
            partNameLabel.TabIndex = 14;
            partNameLabel.Text = "Name:";
            // 
            // partPriceLabel
            // 
            partPriceLabel.AutoSize = true;
            partPriceLabel.Location = new System.Drawing.Point(48, 181);
            partPriceLabel.Name = "partPriceLabel";
            partPriceLabel.Size = new System.Drawing.Size(34, 13);
            partPriceLabel.TabIndex = 16;
            partPriceLabel.Text = "Price:";
            // 
            // labelAddPartTitle
            // 
            this.labelAddPartTitle.AutoSize = true;
            this.labelAddPartTitle.Location = new System.Drawing.Point(13, 13);
            this.labelAddPartTitle.Name = "labelAddPartTitle";
            this.labelAddPartTitle.Size = new System.Drawing.Size(48, 13);
            this.labelAddPartTitle.TabIndex = 0;
            this.labelAddPartTitle.Text = "Add Part";
            // 
            // radioButtonInhouse
            // 
            this.radioButtonInhouse.AutoSize = true;
            this.radioButtonInhouse.Checked = true;
            this.radioButtonInhouse.Location = new System.Drawing.Point(128, 40);
            this.radioButtonInhouse.Name = "radioButtonInhouse";
            this.radioButtonInhouse.Size = new System.Drawing.Size(68, 17);
            this.radioButtonInhouse.TabIndex = 1;
            this.radioButtonInhouse.TabStop = true;
            this.radioButtonInhouse.Text = "In-House";
            this.radioButtonInhouse.UseVisualStyleBackColor = true;
            this.radioButtonInhouse.CheckedChanged += new System.EventHandler(this.radioButtonInhouse_CheckedChanged);
            // 
            // radioButtonOutsourced
            // 
            this.radioButtonOutsourced.AutoSize = true;
            this.radioButtonOutsourced.Location = new System.Drawing.Point(262, 40);
            this.radioButtonOutsourced.Name = "radioButtonOutsourced";
            this.radioButtonOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioButtonOutsourced.TabIndex = 2;
            this.radioButtonOutsourced.Text = "Outsourced";
            this.radioButtonOutsourced.UseVisualStyleBackColor = true;
            this.radioButtonOutsourced.CheckedChanged += new System.EventHandler(this.radioButtonOutsourced_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(230, 296);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(312, 295);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Location = new System.Drawing.Point(142, 101);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.ReadOnly = true;
            this.partIDTextBox.Size = new System.Drawing.Size(122, 20);
            this.partIDTextBox.TabIndex = 3;
            // 
            // partInventoryTextBox
            // 
            this.partInventoryTextBox.Location = new System.Drawing.Point(142, 152);
            this.partInventoryTextBox.Name = "partInventoryTextBox";
            this.partInventoryTextBox.Size = new System.Drawing.Size(122, 20);
            this.partInventoryTextBox.TabIndex = 5;
            this.partInventoryTextBox.TextChanged += new System.EventHandler(this.partInventoryTextBox_TextChanged);
            // 
            // partMaxTextBox
            // 
            this.partMaxTextBox.Location = new System.Drawing.Point(312, 204);
            this.partMaxTextBox.Name = "partMaxTextBox";
            this.partMaxTextBox.Size = new System.Drawing.Size(73, 20);
            this.partMaxTextBox.TabIndex = 8;
            this.partMaxTextBox.TextChanged += new System.EventHandler(this.partMaxTextBox_TextChanged);
            // 
            // partMinTextBox
            // 
            this.partMinTextBox.Location = new System.Drawing.Point(142, 204);
            this.partMinTextBox.Name = "partMinTextBox";
            this.partMinTextBox.Size = new System.Drawing.Size(72, 20);
            this.partMinTextBox.TabIndex = 7;
            this.partMinTextBox.TextChanged += new System.EventHandler(this.partMinTextBox_TextChanged);
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.Location = new System.Drawing.Point(142, 126);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.partNameTextBox.TabIndex = 4;
            this.partNameTextBox.TextChanged += new System.EventHandler(this.partNameTextBox_TextChanged);
            // 
            // partPriceTextBox
            // 
            this.partPriceTextBox.Location = new System.Drawing.Point(142, 178);
            this.partPriceTextBox.Name = "partPriceTextBox";
            this.partPriceTextBox.Size = new System.Drawing.Size(122, 20);
            this.partPriceTextBox.TabIndex = 6;
            this.partPriceTextBox.TextChanged += new System.EventHandler(this.partPriceTextBox_TextChanged);
            // 
            // labelAddPartType
            // 
            this.labelAddPartType.AutoSize = true;
            this.labelAddPartType.Location = new System.Drawing.Point(17, 233);
            this.labelAddPartType.Name = "labelAddPartType";
            this.labelAddPartType.Size = new System.Drawing.Size(65, 13);
            this.labelAddPartType.TabIndex = 18;
            this.labelAddPartType.Text = "Machine ID:";
            // 
            // addPartTypeTextBox
            // 
            this.addPartTypeTextBox.Location = new System.Drawing.Point(142, 230);
            this.addPartTypeTextBox.Name = "addPartTypeTextBox";
            this.addPartTypeTextBox.Size = new System.Drawing.Size(122, 20);
            this.addPartTypeTextBox.TabIndex = 9;
            this.addPartTypeTextBox.TextChanged += new System.EventHandler(this.addPartTypeTextBox_TextChanged);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 354);
            this.Controls.Add(this.addPartTypeTextBox);
            this.Controls.Add(this.labelAddPartType);
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
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.radioButtonOutsourced);
            this.Controls.Add(this.radioButtonInhouse);
            this.Controls.Add(this.labelAddPartTitle);
            this.Name = "AddPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddPartTitle;
        private System.Windows.Forms.RadioButton radioButtonInhouse;
        private System.Windows.Forms.RadioButton radioButtonOutsourced;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.TextBox partInventoryTextBox;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.TextBox partMinTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.TextBox partPriceTextBox;
        private System.Windows.Forms.Label labelAddPartType;
        private System.Windows.Forms.TextBox addPartTypeTextBox;
    }
}