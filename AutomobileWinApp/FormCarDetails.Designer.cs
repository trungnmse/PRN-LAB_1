namespace AutomobileWinApp
{
    partial class FormCarDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCarId = new System.Windows.Forms.TextBox();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxReleaseYear = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Release Year";
            // 
            // textBoxCarId
            // 
            this.textBoxCarId.Location = new System.Drawing.Point(152, 37);
            this.textBoxCarId.Name = "textBoxCarId";
            this.textBoxCarId.Size = new System.Drawing.Size(272, 30);
            this.textBoxCarId.TabIndex = 5;
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Location = new System.Drawing.Point(152, 96);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(272, 30);
            this.textBoxCarName.TabIndex = 6;
            // 
            // maskedTextBoxPrice
            // 
            this.maskedTextBoxPrice.Location = new System.Drawing.Point(152, 217);
            this.maskedTextBoxPrice.Mask = "00000000";
            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            this.maskedTextBoxPrice.Size = new System.Drawing.Size(272, 30);
            this.maskedTextBoxPrice.TabIndex = 7;
            this.maskedTextBoxPrice.ValidatingType = typeof(int);
            // 
            // maskedTextBoxReleaseYear
            // 
            this.maskedTextBoxReleaseYear.Location = new System.Drawing.Point(152, 269);
            this.maskedTextBoxReleaseYear.Mask = "0000";
            this.maskedTextBoxReleaseYear.Name = "maskedTextBoxReleaseYear";
            this.maskedTextBoxReleaseYear.Size = new System.Drawing.Size(272, 30);
            this.maskedTextBoxReleaseYear.TabIndex = 8;
            this.maskedTextBoxReleaseYear.Text = "0";
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Ford",
            "Honda",
            "Hyundai",
            "Kia",
            "Suzuki",
            "Toyota"});
            this.comboBoxManufacturer.Location = new System.Drawing.Point(152, 157);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(272, 31);
            this.comboBoxManufacturer.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(122, 349);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 32);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(323, 349);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 32);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 409);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.maskedTextBoxReleaseYear);
            this.Controls.Add(this.maskedTextBoxPrice);
            this.Controls.Add(this.textBoxCarName);
            this.Controls.Add(this.textBoxCarId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormCarDetails";
            this.Text = "CarDetails";
            this.Load += new System.EventHandler(this.FormCarDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxCarId;
        private TextBox textBoxCarName;
        private MaskedTextBox maskedTextBoxPrice;
        private MaskedTextBox maskedTextBoxReleaseYear;
        private ComboBox comboBoxManufacturer;
        private Button buttonSave;
        private Button buttonCancel;
    }
}