namespace AutomobileWinApp
{
    partial class FormCarManagement
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
            this.labelCarId = new System.Windows.Forms.Label();
            this.labelCarName = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelReleaseYear = new System.Windows.Forms.Label();
            this.textBoxCarId = new System.Windows.Forms.TextBox();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxReleaseYear = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridListCar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListCar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCarId
            // 
            this.labelCarId.AutoSize = true;
            this.labelCarId.Location = new System.Drawing.Point(30, 61);
            this.labelCarId.Name = "labelCarId";
            this.labelCarId.Size = new System.Drawing.Size(48, 20);
            this.labelCarId.TabIndex = 0;
            this.labelCarId.Text = "Car Id";
            // 
            // labelCarName
            // 
            this.labelCarName.AutoSize = true;
            this.labelCarName.Location = new System.Drawing.Point(30, 123);
            this.labelCarName.Name = "labelCarName";
            this.labelCarName.Size = new System.Drawing.Size(75, 20);
            this.labelCarName.TabIndex = 1;
            this.labelCarName.Text = "Car Name";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(30, 181);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(97, 20);
            this.labelManufacturer.TabIndex = 2;
            this.labelManufacturer.Text = "Manufacturer";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(392, 58);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 20);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price";
            // 
            // labelReleaseYear
            // 
            this.labelReleaseYear.AutoSize = true;
            this.labelReleaseYear.Location = new System.Drawing.Point(392, 120);
            this.labelReleaseYear.Name = "labelReleaseYear";
            this.labelReleaseYear.Size = new System.Drawing.Size(92, 20);
            this.labelReleaseYear.TabIndex = 4;
            this.labelReleaseYear.Text = "Release Year";
            // 
            // textBoxCarId
            // 
            this.textBoxCarId.Location = new System.Drawing.Point(135, 63);
            this.textBoxCarId.Name = "textBoxCarId";
            this.textBoxCarId.Size = new System.Drawing.Size(233, 27);
            this.textBoxCarId.TabIndex = 5;
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Location = new System.Drawing.Point(135, 121);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(235, 27);
            this.textBoxCarName.TabIndex = 6;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(135, 176);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(233, 27);
            this.textBoxManufacturer.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(522, 64);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(227, 27);
            this.textBoxPrice.TabIndex = 8;
            // 
            // textBoxReleaseYear
            // 
            this.textBoxReleaseYear.Location = new System.Drawing.Point(522, 121);
            this.textBoxReleaseYear.Name = "textBoxReleaseYear";
            this.textBoxReleaseYear.Size = new System.Drawing.Size(227, 27);
            this.textBoxReleaseYear.TabIndex = 9;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(30, 247);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(103, 41);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(349, 247);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(103, 41);
            this.buttonNew.TabIndex = 11;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(646, 247);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 41);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(349, 514);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(103, 41);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridListCar
            // 
            this.dataGridListCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListCar.Location = new System.Drawing.Point(30, 309);
            this.dataGridListCar.Name = "dataGridListCar";
            this.dataGridListCar.ReadOnly = true;
            this.dataGridListCar.RowHeadersWidth = 51;
            this.dataGridListCar.RowTemplate.Height = 29;
            this.dataGridListCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListCar.Size = new System.Drawing.Size(719, 199);
            this.dataGridListCar.TabIndex = 14;
            this.dataGridListCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListCar_CellDoubleClick);
            // 
            // FormCarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 567);
            this.Controls.Add(this.dataGridListCar);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxReleaseYear);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.textBoxCarName);
            this.Controls.Add(this.textBoxCarId);
            this.Controls.Add(this.labelReleaseYear);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelCarName);
            this.Controls.Add(this.labelCarId);
            this.Name = "FormCarManagement";
            this.Text = "FormCarManagement";
            this.Load += new System.EventHandler(this.FormCarManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCarId;
        private Label labelCarName;
        private Label labelManufacturer;
        private Label labelPrice;
        private Label labelReleaseYear;
        private TextBox textBoxCarId;
        private TextBox textBoxCarName;
        private TextBox textBoxManufacturer;
        private TextBox textBoxPrice;
        private TextBox textBoxReleaseYear;
        private Button buttonLoad;
        private Button buttonNew;
        private Button buttonDelete;
        private Button buttonClose;
        private DataGridView dataGridListCar;
    }
}