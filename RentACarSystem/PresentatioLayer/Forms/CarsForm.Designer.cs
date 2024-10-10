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
            CarsDataGridView.Location = new Point(628, 81);
            CarsDataGridView.Name = "CarsDataGridView";
            CarsDataGridView.RowHeadersWidth = 51;
            CarsDataGridView.Size = new Size(382, 425);
            CarsDataGridView.TabIndex = 0;
            CarsDataGridView.SelectionChanged += CarsDataGridView_SelectionChanged;
            // 
            // Tittlelabel
            // 
            Tittlelabel.AutoSize = true;
            Tittlelabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tittlelabel.Location = new Point(234, 12);
            Tittlelabel.Name = "Tittlelabel";
            Tittlelabel.Size = new Size(228, 32);
            Tittlelabel.TabIndex = 1;
            Tittlelabel.Text = "Registro de  Vehiculo";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(70, 129);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(56, 20);
            brandLabel.TabIndex = 2;
            brandLabel.Text = "Marca :";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(64, 194);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(62, 20);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Modelo :";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(41, 173);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(41, 20);
            yearLabel.TabIndex = 4;
            yearLabel.Text = "Año :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 289);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 5;
            // 
            // tittlePanel
            // 
            tittlePanel.BackColor = Color.WhiteSmoke;
            tittlePanel.BorderStyle = BorderStyle.Fixed3D;
            tittlePanel.Controls.Add(Tittlelabel);
            tittlePanel.Location = new Point(219, 8);
            tittlePanel.Name = "tittlePanel";
            tittlePanel.Size = new Size(687, 62);
            tittlePanel.TabIndex = 6;
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(112, 41);
            brandTextBox.Multiline = true;
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(326, 30);
            brandTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(113, 108);
            modelTextBox.Multiline = true;
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(325, 30);
            modelTextBox.TabIndex = 8;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(113, 162);
            yearTextBox.Multiline = true;
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(125, 34);
            yearTextBox.TabIndex = 9;
            // 
            // saveCarButton
            // 
            saveCarButton.BackColor = Color.Aquamarine;
            saveCarButton.Location = new Point(204, 35);
            saveCarButton.Name = "saveCarButton";
            saveCarButton.Size = new Size(148, 50);
            saveCarButton.TabIndex = 10;
            saveCarButton.Text = "Guardar";
            saveCarButton.UseVisualStyleBackColor = false;
            saveCarButton.Click += saveCarButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Aquamarine;
            editButton.Location = new Point(36, 79);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 54);
            editButton.TabIndex = 11;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Aquamarine;
            deleteButton.Location = new Point(375, 77);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(158, 52);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // availabilityCheckBox
            // 
            availabilityCheckBox.AutoSize = true;
            availabilityCheckBox.Location = new Point(101, 232);
            availabilityCheckBox.Name = "availabilityCheckBox";
            availabilityCheckBox.Size = new Size(92, 24);
            availabilityCheckBox.TabIndex = 13;
            availabilityCheckBox.Text = "disponible";
            availabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // availabilityLabel
            // 
            availabilityLabel.AutoSize = true;
            availabilityLabel.Location = new Point(25, 230);
            availabilityLabel.Name = "availabilityLabel";
            availabilityLabel.Size = new Size(49, 20);
            availabilityLabel.TabIndex = 14;
            availabilityLabel.Text = "Estado";
            // 
            // backButton
            // 
            backButton.BackColor = Color.Aquamarine;
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
            dataVehicleGroupBox.BackColor = Color.Silver;
            dataVehicleGroupBox.Controls.Add(yearTextBox);
            dataVehicleGroupBox.Controls.Add(yearLabel);
            dataVehicleGroupBox.Controls.Add(modelTextBox);
            dataVehicleGroupBox.Controls.Add(availabilityLabel);
            dataVehicleGroupBox.Controls.Add(brandTextBox);
            dataVehicleGroupBox.Controls.Add(availabilityCheckBox);
            dataVehicleGroupBox.Location = new Point(32, 81);
            dataVehicleGroupBox.Name = "dataVehicleGroupBox";
            dataVehicleGroupBox.Size = new Size(575, 295);
            dataVehicleGroupBox.TabIndex = 16;
            dataVehicleGroupBox.TabStop = false;
            dataVehicleGroupBox.Text = "Datos del Vehículo";
            // 
            // registerVehicleDatagroupBox
            // 
            registerVehicleDatagroupBox.BackColor = Color.Silver;
            registerVehicleDatagroupBox.Controls.Add(saveCarButton);
            registerVehicleDatagroupBox.Controls.Add(editButton);
            registerVehicleDatagroupBox.Controls.Add(deleteButton);
            registerVehicleDatagroupBox.Location = new Point(32, 392);
            registerVehicleDatagroupBox.Name = "registerVehicleDatagroupBox";
            registerVehicleDatagroupBox.Size = new Size(575, 142);
            registerVehicleDatagroupBox.TabIndex = 17;
            registerVehicleDatagroupBox.TabStop = false;
            registerVehicleDatagroupBox.Text = "Acciones";
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1031, 546);
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