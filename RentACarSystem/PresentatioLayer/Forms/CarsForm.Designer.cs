namespace PresentatioLayer.Forms
{
    partial class CarsForm
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
            CarsDataGridView = new DataGridView();
            Tittlelabel = new Label();
            brandLabel = new Label();
            modelLabel = new Label();
            yearLabel = new Label();
            label5 = new Label();
            tittlePanel = new Panel();
            brandTextBox = new TextBox();
            modelTextBox = new TextBox();
            yearTextBox = new TextBox();
            saveCarButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            availabilityCheckBox = new CheckBox();
            availabilityLabel = new Label();
            backButton = new Button();
            dataVehicleGroupBox = new GroupBox();
            registerVehicleDatagroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)CarsDataGridView).BeginInit();
            tittlePanel.SuspendLayout();
            dataVehicleGroupBox.SuspendLayout();
            registerVehicleDatagroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CarsDataGridView
            // 
            CarsDataGridView.BackgroundColor = SystemColors.Control;
            CarsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarsDataGridView.Location = new Point(34, 306);
            CarsDataGridView.Name = "CarsDataGridView";
            CarsDataGridView.RowHeadersWidth = 51;
            CarsDataGridView.Size = new Size(1031, 232);
            CarsDataGridView.TabIndex = 0;
            CarsDataGridView.SelectionChanged += CarsDataGridView_SelectionChanged;
            // 
            // Tittlelabel
            // 
            Tittlelabel.AutoSize = true;
            Tittlelabel.Font = new Font("Segoe UI", 15F);
            Tittlelabel.Location = new Point(141, 0);
            Tittlelabel.Name = "Tittlelabel";
            Tittlelabel.Size = new Size(397, 54);
            Tittlelabel.TabIndex = 1;
            Tittlelabel.Text = "Registro de  Vehiculo";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(70, 117);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(109, 38);
            brandLabel.TabIndex = 2;
            brandLabel.Text = "Marca :";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(64, 181);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(122, 38);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Modelo :";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(528, 37);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(80, 38);
            yearLabel.TabIndex = 4;
            yearLabel.Text = "Año :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 289);
            label5.Name = "label5";
            label5.Size = new Size(0, 38);
            label5.TabIndex = 5;
            // 
            // tittlePanel
            // 
            tittlePanel.BackColor = Color.WhiteSmoke;
            tittlePanel.BorderStyle = BorderStyle.Fixed3D;
            tittlePanel.Controls.Add(Tittlelabel);
            tittlePanel.Location = new Point(219, 12);
            tittlePanel.Name = "tittlePanel";
            tittlePanel.Size = new Size(687, 62);
            tittlePanel.TabIndex = 6;
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(137, 41);
            brandTextBox.Multiline = true;
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(314, 30);
            brandTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(158, 108);
            modelTextBox.Multiline = true;
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(325, 30);
            modelTextBox.TabIndex = 8;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(619, 41);
            yearTextBox.Multiline = true;
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(125, 34);
            yearTextBox.TabIndex = 9;
            // 
            // saveCarButton
            // 
            saveCarButton.Location = new Point(109, 35);
            saveCarButton.Name = "saveCarButton";
            saveCarButton.Size = new Size(130, 47);
            saveCarButton.TabIndex = 10;
            saveCarButton.Text = "Guardar";
            saveCarButton.UseVisualStyleBackColor = true;
            saveCarButton.Click += saveCarButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(22, 91);
            editButton.Name = "editButton";
            editButton.Size = new Size(130, 47);
            editButton.TabIndex = 11;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(178, 93);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(130, 47);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // availabilityCheckBox
            // 
            availabilityCheckBox.AutoSize = true;
            availabilityCheckBox.Location = new Point(608, 101);
            availabilityCheckBox.Name = "availabilityCheckBox";
            availabilityCheckBox.Size = new Size(170, 42);
            availabilityCheckBox.TabIndex = 13;
            availabilityCheckBox.Text = "disponible";
            availabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // availabilityLabel
            // 
            availabilityLabel.AutoSize = true;
            availabilityLabel.Location = new Point(509, 105);
            availabilityLabel.Name = "availabilityLabel";
            availabilityLabel.Size = new Size(93, 38);
            availabilityLabel.TabIndex = 14;
            availabilityLabel.Text = "Estado";
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(255, 192, 128);
            backButton.Location = new Point(4, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(133, 47);
            backButton.TabIndex = 15;
            backButton.Text = "Regresar";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // dataVehicleGroupBox
            // 
            dataVehicleGroupBox.Controls.Add(yearTextBox);
            dataVehicleGroupBox.Controls.Add(yearLabel);
            dataVehicleGroupBox.Controls.Add(modelTextBox);
            dataVehicleGroupBox.Controls.Add(availabilityLabel);
            dataVehicleGroupBox.Controls.Add(brandTextBox);
            dataVehicleGroupBox.Controls.Add(availabilityCheckBox);
            dataVehicleGroupBox.Location = new Point(34, 80);
            dataVehicleGroupBox.Name = "dataVehicleGroupBox";
            dataVehicleGroupBox.Size = new Size(778, 176);
            dataVehicleGroupBox.TabIndex = 16;
            dataVehicleGroupBox.TabStop = false;
            dataVehicleGroupBox.Text = "Datos del Vehículo";
            // 
            // registerVehicleDatagroupBox
            // 
            registerVehicleDatagroupBox.Controls.Add(saveCarButton);
            registerVehicleDatagroupBox.Controls.Add(editButton);
            registerVehicleDatagroupBox.Controls.Add(deleteButton);
            registerVehicleDatagroupBox.Location = new Point(832, 80);
            registerVehicleDatagroupBox.Name = "registerVehicleDatagroupBox";
            registerVehicleDatagroupBox.Size = new Size(314, 171);
            registerVehicleDatagroupBox.TabIndex = 17;
            registerVehicleDatagroupBox.TabStop = false;
            registerVehicleDatagroupBox.Text = "Acciones";
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1181, 591);
            Controls.Add(registerVehicleDatagroupBox);
            Controls.Add(backButton);
            Controls.Add(tittlePanel);
            Controls.Add(label5);
            Controls.Add(modelLabel);
            Controls.Add(brandLabel);
            Controls.Add(CarsDataGridView);
            Controls.Add(dataVehicleGroupBox);
            Font = new Font("Tw Cen MT Condensed Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CarsForm";
            Text = "CarsForm";
            ((System.ComponentModel.ISupportInitialize)CarsDataGridView).EndInit();
            tittlePanel.ResumeLayout(false);
            tittlePanel.PerformLayout();
            dataVehicleGroupBox.ResumeLayout(false);
            dataVehicleGroupBox.PerformLayout();
            registerVehicleDatagroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CarsDataGridView;
        private Label Tittlelabel;
        private Label brandLabel;
        private Label modelLabel;
        private Label yearLabel;
        private Label label5;
        private Panel tittlePanel;
        private TextBox brandTextBox;
        private TextBox modelTextBox;
        private TextBox yearTextBox;
        private Button saveCarButton;
        private Button editButton;
        private Button deleteButton;
        private CheckBox availabilityCheckBox;
        private Label availabilityLabel;
        private Button backButton;
        private GroupBox dataVehicleGroupBox;
        private GroupBox registerVehicleDatagroupBox;
    }
}