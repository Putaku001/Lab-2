namespace PresentatioLayer.Forms
{
    partial class RentForm
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
            clientsButton = new Button();
            carsButton = new Button();
            clientsLabel = new Label();
            CarLabel = new Label();
            rentDateLabel = new Label();
            rentReturnLabel = new Label();
            saveRentButton = new Button();
            editRentButton = new Button();
            deleteRentButton = new Button();
            ClientscomboBox = new ComboBox();
            CarscomboBox = new ComboBox();
            rentDateDTP = new DateTimePicker();
            rentReturnDTP = new DateTimePicker();
            rentsDataGridView = new DataGridView();
            titlePrincipalFormPanel = new Panel();
            tittleLabel = new Label();
            newRentGroupBox = new GroupBox();
            returnTimeDTP = new DateTimePicker();
            rentTimeDTP = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)rentsDataGridView).BeginInit();
            titlePrincipalFormPanel.SuspendLayout();
            newRentGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // clientsButton
            // 
            clientsButton.BackColor = SystemColors.ActiveCaption;
            clientsButton.Location = new Point(96, 26);
            clientsButton.Margin = new Padding(0);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(187, 36);
            clientsButton.TabIndex = 0;
            clientsButton.Text = "Agregar Nuevo Cliente";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += clientsButton_Click;
            // 
            // carsButton
            // 
            carsButton.BackColor = SystemColors.ActiveCaption;
            carsButton.Location = new Point(96, 110);
            carsButton.Margin = new Padding(4, 3, 4, 3);
            carsButton.Name = "carsButton";
            carsButton.Size = new Size(187, 37);
            carsButton.TabIndex = 1;
            carsButton.Text = "Agregar Nuevo Carro";
            carsButton.UseVisualStyleBackColor = false;
            carsButton.Click += carsButton_Click;
            // 
            // clientsLabel
            // 
            clientsLabel.AutoSize = true;
            clientsLabel.BackColor = SystemColors.ActiveCaption;
            clientsLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F);
            clientsLabel.Location = new Point(41, 69);
            clientsLabel.Margin = new Padding(4, 0, 4, 0);
            clientsLabel.Name = "clientsLabel";
            clientsLabel.Size = new Size(151, 23);
            clientsLabel.TabIndex = 2;
            clientsLabel.Text = "Seleccionar Cliente";
            // 
            // CarLabel
            // 
            CarLabel.AutoSize = true;
            CarLabel.BackColor = SystemColors.ActiveCaption;
            CarLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F);
            CarLabel.Location = new Point(51, 165);
            CarLabel.Margin = new Padding(4, 0, 4, 0);
            CarLabel.Name = "CarLabel";
            CarLabel.Size = new Size(141, 23);
            CarLabel.TabIndex = 3;
            CarLabel.Text = "Seleccionar Carro";
            // 
            // rentDateLabel
            // 
            rentDateLabel.AutoSize = true;
            rentDateLabel.BackColor = SystemColors.ActiveCaption;
            rentDateLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F);
            rentDateLabel.Location = new Point(118, 243);
            rentDateLabel.Margin = new Padding(4, 0, 4, 0);
            rentDateLabel.Name = "rentDateLabel";
            rentDateLabel.Size = new Size(175, 23);
            rentDateLabel.TabIndex = 4;
            rentDateLabel.Text = "Fecha y hora de retiro";
            // 
            // rentReturnLabel
            // 
            rentReturnLabel.AutoSize = true;
            rentReturnLabel.BackColor = SystemColors.ActiveCaption;
            rentReturnLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F);
            rentReturnLabel.Location = new Point(71, 342);
            rentReturnLabel.Margin = new Padding(4, 0, 4, 0);
            rentReturnLabel.Name = "rentReturnLabel";
            rentReturnLabel.Size = new Size(212, 23);
            rentReturnLabel.TabIndex = 5;
            rentReturnLabel.Text = "Fecha y hora de devolucion";
            // 
            // saveRentButton
            // 
            saveRentButton.BackColor = SystemColors.ActiveCaption;
            saveRentButton.ForeColor = Color.Black;
            saveRentButton.Location = new Point(13, 559);
            saveRentButton.Margin = new Padding(4, 3, 4, 3);
            saveRentButton.Name = "saveRentButton";
            saveRentButton.Size = new Size(133, 59);
            saveRentButton.TabIndex = 6;
            saveRentButton.Text = "Guardar";
            saveRentButton.UseVisualStyleBackColor = false;
            // 
            // editRentButton
            // 
            editRentButton.BackColor = SystemColors.ActiveCaption;
            editRentButton.Location = new Point(321, 559);
            editRentButton.Margin = new Padding(4, 3, 4, 3);
            editRentButton.Name = "editRentButton";
            editRentButton.Size = new Size(133, 59);
            editRentButton.TabIndex = 7;
            editRentButton.Text = "Editar";
            editRentButton.UseVisualStyleBackColor = false;
            // 
            // deleteRentButton
            // 
            deleteRentButton.BackColor = SystemColors.ActiveCaption;
            deleteRentButton.Location = new Point(163, 559);
            deleteRentButton.Margin = new Padding(4, 3, 4, 3);
            deleteRentButton.Name = "deleteRentButton";
            deleteRentButton.Size = new Size(133, 59);
            deleteRentButton.TabIndex = 8;
            deleteRentButton.Text = "Eliminar";
            deleteRentButton.UseVisualStyleBackColor = false;
            // 
            // ClientscomboBox
            // 
            ClientscomboBox.BackColor = SystemColors.ControlLightLight;
            ClientscomboBox.FormattingEnabled = true;
            ClientscomboBox.Location = new Point(259, 69);
            ClientscomboBox.Margin = new Padding(4, 3, 4, 3);
            ClientscomboBox.Name = "ClientscomboBox";
            ClientscomboBox.Size = new Size(203, 31);
            ClientscomboBox.TabIndex = 9;
            // 
            // CarscomboBox
            // 
            CarscomboBox.BackColor = SystemColors.ControlLightLight;
            CarscomboBox.ForeColor = SystemColors.InactiveBorder;
            CarscomboBox.FormattingEnabled = true;
            CarscomboBox.Location = new Point(259, 157);
            CarscomboBox.Margin = new Padding(4, 3, 4, 3);
            CarscomboBox.Name = "CarscomboBox";
            CarscomboBox.Size = new Size(203, 31);
            CarscomboBox.TabIndex = 10;
            // 
            // rentDateDTP
            // 
            rentDateDTP.CustomFormat = "";
            rentDateDTP.Location = new Point(8, 296);
            rentDateDTP.Margin = new Padding(4, 3, 4, 3);
            rentDateDTP.Name = "rentDateDTP";
            rentDateDTP.Size = new Size(322, 29);
            rentDateDTP.TabIndex = 11;
            rentDateDTP.Value = new DateTime(2024, 10, 9, 11, 41, 40, 0);
            // 
            // rentReturnDTP
            // 
            rentReturnDTP.Location = new Point(8, 386);
            rentReturnDTP.Margin = new Padding(4, 3, 4, 3);
            rentReturnDTP.Name = "rentReturnDTP";
            rentReturnDTP.Size = new Size(335, 29);
            rentReturnDTP.TabIndex = 12;
            // 
            // rentsDataGridView
            // 
            rentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            rentsDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            rentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentsDataGridView.Location = new Point(674, 122);
            rentsDataGridView.Margin = new Padding(4, 3, 4, 3);
            rentsDataGridView.Name = "rentsDataGridView";
            rentsDataGridView.RowHeadersWidth = 51;
            rentsDataGridView.Size = new Size(853, 404);
            rentsDataGridView.TabIndex = 13;
            // 
            // titlePrincipalFormPanel
            // 
            titlePrincipalFormPanel.BackColor = SystemColors.ActiveCaption;
            titlePrincipalFormPanel.Controls.Add(tittleLabel);
            titlePrincipalFormPanel.Location = new Point(13, 9);
            titlePrincipalFormPanel.Margin = new Padding(4, 3, 4, 3);
            titlePrincipalFormPanel.Name = "titlePrincipalFormPanel";
            titlePrincipalFormPanel.Size = new Size(972, 71);
            titlePrincipalFormPanel.TabIndex = 15;
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tittleLabel.Location = new Point(281, 13);
            tittleLabel.Margin = new Padding(4, 0, 4, 0);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(451, 44);
            tittleLabel.TabIndex = 0;
            tittleLabel.Text = "The Brothers Rent A Car";
            // 
            // newRentGroupBox
            // 
            newRentGroupBox.BackColor = Color.FromArgb(0, 192, 192);
            newRentGroupBox.Controls.Add(returnTimeDTP);
            newRentGroupBox.Controls.Add(rentDateDTP);
            newRentGroupBox.Controls.Add(rentTimeDTP);
            newRentGroupBox.Controls.Add(rentReturnDTP);
            newRentGroupBox.Controls.Add(CarscomboBox);
            newRentGroupBox.Controls.Add(ClientscomboBox);
            newRentGroupBox.Controls.Add(rentReturnLabel);
            newRentGroupBox.Controls.Add(rentDateLabel);
            newRentGroupBox.Controls.Add(CarLabel);
            newRentGroupBox.Controls.Add(clientsLabel);
            newRentGroupBox.Controls.Add(carsButton);
            newRentGroupBox.Controls.Add(clientsButton);
            newRentGroupBox.Location = new Point(13, 87);
            newRentGroupBox.Margin = new Padding(4);
            newRentGroupBox.Name = "newRentGroupBox";
            newRentGroupBox.Padding = new Padding(4);
            newRentGroupBox.Size = new Size(653, 454);
            newRentGroupBox.TabIndex = 16;
            newRentGroupBox.TabStop = false;
            newRentGroupBox.Text = "Renta de Vehiculo";
            // 
            // returnTimeDTP
            // 
            returnTimeDTP.Format = DateTimePickerFormat.Time;
            returnTimeDTP.Location = new Point(338, 296);
            returnTimeDTP.Margin = new Padding(4);
            returnTimeDTP.Name = "returnTimeDTP";
            returnTimeDTP.ShowUpDown = true;
            returnTimeDTP.Size = new Size(158, 29);
            returnTimeDTP.TabIndex = 14;
            // 
            // rentTimeDTP
            // 
            rentTimeDTP.Format = DateTimePickerFormat.Time;
            rentTimeDTP.Location = new Point(400, 386);
            rentTimeDTP.Margin = new Padding(4);
            rentTimeDTP.Name = "rentTimeDTP";
            rentTimeDTP.ShowUpDown = true;
            rentTimeDTP.Size = new Size(166, 29);
            rentTimeDTP.TabIndex = 13;
            // 
            // RentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1569, 688);
            Controls.Add(titlePrincipalFormPanel);
            Controls.Add(newRentGroupBox);
            Controls.Add(saveRentButton);
            Controls.Add(deleteRentButton);
            Controls.Add(editRentButton);
            Controls.Add(rentsDataGridView);
            Font = new Font("Tw Cen MT Condensed Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RentForm";
            Text = "RentForm";
            FormClosing += RentForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)rentsDataGridView).EndInit();
            titlePrincipalFormPanel.ResumeLayout(false);
            titlePrincipalFormPanel.PerformLayout();
            newRentGroupBox.ResumeLayout(false);
            newRentGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button clientsButton;
        private Button carsButton;
        private Label clientsLabel;
        private Label CarLabel;
        private Label rentDateLabel;
        private Label rentReturnLabel;
        private Button saveRentButton;
        private Button editRentButton;
        private Button deleteRentButton;
        private ComboBox ClientscomboBox;
        private ComboBox CarscomboBox;
        private DateTimePicker rentDateDTP;
        private DateTimePicker rentReturnDTP;
        private DataGridView rentsDataGridView;
        private Panel titlePrincipalFormPanel;
        private Label tittleLabel;
        private GroupBox newRentGroupBox;
        private DateTimePicker returnTimeDTP;
        private DateTimePicker rentTimeDTP;
    }
}