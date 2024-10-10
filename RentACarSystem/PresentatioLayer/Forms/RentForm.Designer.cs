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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentForm));
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
            returnTimeLabel = new Label();
            rentTimeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)rentsDataGridView).BeginInit();
            titlePrincipalFormPanel.SuspendLayout();
            newRentGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // clientsButton
            // 
            clientsButton.BackColor = SystemColors.ActiveCaption;
            clientsButton.Location = new Point(104, 25);
            clientsButton.Margin = new Padding(0);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(145, 26);
            clientsButton.TabIndex = 0;
            clientsButton.Text = "agregar nuevo cliente";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += clientsButton_Click;
            // 
            // carsButton
            // 
            carsButton.BackColor = SystemColors.ActiveCaption;
            carsButton.Location = new Point(96, 116);
            carsButton.Margin = new Padding(3, 2, 3, 2);
            carsButton.Name = "carsButton";
            carsButton.Size = new Size(145, 27);
            carsButton.TabIndex = 1;
            carsButton.Text = "agregar nuevo carro";
            carsButton.UseVisualStyleBackColor = false;
            carsButton.Click += carsButton_Click;
            // 
            // clientsLabel
            // 
            clientsLabel.AutoSize = true;
            clientsLabel.BackColor = SystemColors.ActiveCaption;
            clientsLabel.Font = new Font("Arial", 10F);
            clientsLabel.Location = new Point(0, 72);
            clientsLabel.Name = "clientsLabel";
            clientsLabel.Size = new Size(145, 19);
            clientsLabel.TabIndex = 2;
            clientsLabel.Text = "seleccionar cliente";
            // 
            // CarLabel
            // 
            CarLabel.AutoSize = true;
            CarLabel.BackColor = SystemColors.ActiveCaption;
            CarLabel.Font = new Font("Arial", 10F);
            CarLabel.Location = new Point(5, 172);
            CarLabel.Name = "CarLabel";
            CarLabel.Size = new Size(137, 19);
            CarLabel.TabIndex = 3;
            CarLabel.Text = "seleccionar carro";
            // 
            // rentDateLabel
            // 
            rentDateLabel.AutoSize = true;
            rentDateLabel.BackColor = SystemColors.ActiveCaption;
            rentDateLabel.Font = new Font("Arial", 10F);
            rentDateLabel.Location = new Point(451, 20);
            rentDateLabel.Name = "rentDateLabel";
            rentDateLabel.Size = new Size(116, 19);
            rentDateLabel.TabIndex = 4;
            rentDateLabel.Text = "fecha de retiro";
            // 
            // rentReturnLabel
            // 
            rentReturnLabel.AutoSize = true;
            rentReturnLabel.BackColor = SystemColors.ActiveCaption;
            rentReturnLabel.Font = new Font("Arial", 10F);
            rentReturnLabel.Location = new Point(441, 81);
            rentReturnLabel.Name = "rentReturnLabel";
            rentReturnLabel.Size = new Size(155, 19);
            rentReturnLabel.TabIndex = 5;
            rentReturnLabel.Text = "fecha de devolucion";
            // 
            // saveRentButton
            // 
            saveRentButton.BackColor = SystemColors.ActiveCaption;
            saveRentButton.ForeColor = Color.Black;
            saveRentButton.Location = new Point(419, 355);
            saveRentButton.Margin = new Padding(3, 2, 3, 2);
            saveRentButton.Name = "saveRentButton";
            saveRentButton.Size = new Size(128, 43);
            saveRentButton.TabIndex = 6;
            saveRentButton.Text = "guardar";
            saveRentButton.UseVisualStyleBackColor = false;
            saveRentButton.Click += saveRentButton_Click;
            // 
            // editRentButton
            // 
            editRentButton.BackColor = SystemColors.ActiveCaption;
            editRentButton.Location = new Point(100, 355);
            editRentButton.Margin = new Padding(3, 2, 3, 2);
            editRentButton.Name = "editRentButton";
            editRentButton.Size = new Size(108, 43);
            editRentButton.TabIndex = 7;
            editRentButton.Text = "editar";
            editRentButton.UseVisualStyleBackColor = false;
            editRentButton.Click += editRentButton_Click;
            // 
            // deleteRentButton
            // 
            deleteRentButton.BackColor = SystemColors.ActiveCaption;
            deleteRentButton.Location = new Point(713, 337);
            deleteRentButton.Margin = new Padding(3, 2, 3, 2);
            deleteRentButton.Name = "deleteRentButton";
            deleteRentButton.Size = new Size(98, 43);
            deleteRentButton.TabIndex = 8;
            deleteRentButton.Text = "eliminar";
            deleteRentButton.UseVisualStyleBackColor = false;
            deleteRentButton.Click += deleteRentButton_Click;
            // 
            // ClientscomboBox
            // 
            ClientscomboBox.BackColor = SystemColors.ControlLightLight;
            ClientscomboBox.ForeColor = SystemColors.InfoText;
            ClientscomboBox.FormattingEnabled = true;
            ClientscomboBox.Location = new Point(198, 71);
            ClientscomboBox.Margin = new Padding(3, 2, 3, 2);
            ClientscomboBox.Name = "ClientscomboBox";
            ClientscomboBox.Size = new Size(119, 25);
            ClientscomboBox.TabIndex = 9;
            // 
            // CarscomboBox
            // 
            CarscomboBox.BackColor = SystemColors.ControlLightLight;
            CarscomboBox.ForeColor = SystemColors.ControlText;
            CarscomboBox.FormattingEnabled = true;
            CarscomboBox.Location = new Point(198, 167);
            CarscomboBox.Margin = new Padding(3, 2, 3, 2);
            CarscomboBox.Name = "CarscomboBox";
            CarscomboBox.Size = new Size(119, 25);
            CarscomboBox.TabIndex = 10;
            // 
            // rentDateDTP
            // 
            rentDateDTP.CustomFormat = "";
            rentDateDTP.Location = new Point(611, 15);
            rentDateDTP.Margin = new Padding(3, 2, 3, 2);
            rentDateDTP.Name = "rentDateDTP";
            rentDateDTP.Size = new Size(214, 25);
            rentDateDTP.TabIndex = 11;
            rentDateDTP.Value = new DateTime(2024, 10, 9, 11, 41, 40, 0);
            // 
            // rentReturnDTP
            // 
            rentReturnDTP.Location = new Point(615, 79);
            rentReturnDTP.Margin = new Padding(3, 2, 3, 2);
            rentReturnDTP.Name = "rentReturnDTP";
            rentReturnDTP.Size = new Size(214, 25);
            rentReturnDTP.TabIndex = 12;
            // 
            // rentsDataGridView
            // 
            rentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            rentsDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            rentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentsDataGridView.Location = new Point(70, 442);
            rentsDataGridView.Margin = new Padding(3, 2, 3, 2);
            rentsDataGridView.Name = "rentsDataGridView";
            rentsDataGridView.RowHeadersWidth = 51;
            rentsDataGridView.Size = new Size(885, 202);
            rentsDataGridView.TabIndex = 13;
            // 
            // titlePrincipalFormPanel
            // 
            titlePrincipalFormPanel.BackColor = SystemColors.ActiveCaption;
            titlePrincipalFormPanel.Controls.Add(tittleLabel);
            titlePrincipalFormPanel.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlePrincipalFormPanel.Location = new Point(44, 11);
            titlePrincipalFormPanel.Margin = new Padding(3, 2, 3, 2);
            titlePrincipalFormPanel.Name = "titlePrincipalFormPanel";
            titlePrincipalFormPanel.Size = new Size(861, 48);
            titlePrincipalFormPanel.TabIndex = 15;
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tittleLabel.Location = new Point(295, 9);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(419, 42);
            tittleLabel.TabIndex = 0;
            tittleLabel.Text = "The Brothers Rent A Car";
            // 
            // newRentGroupBox
            // 
            newRentGroupBox.BackColor = SystemColors.ControlDark;
            newRentGroupBox.Controls.Add(returnTimeDTP);
            newRentGroupBox.Controls.Add(rentTimeDTP);
            newRentGroupBox.Controls.Add(returnTimeLabel);
            newRentGroupBox.Controls.Add(rentReturnDTP);
            newRentGroupBox.Controls.Add(rentDateDTP);
            newRentGroupBox.Controls.Add(rentTimeLabel);
            newRentGroupBox.Controls.Add(CarscomboBox);
            newRentGroupBox.Controls.Add(ClientscomboBox);
            newRentGroupBox.Controls.Add(rentReturnLabel);
            newRentGroupBox.Controls.Add(rentDateLabel);
            newRentGroupBox.Controls.Add(CarLabel);
            newRentGroupBox.Controls.Add(clientsLabel);
            newRentGroupBox.Controls.Add(carsButton);
            newRentGroupBox.Controls.Add(clientsButton);
            newRentGroupBox.Location = new Point(24, 86);
            newRentGroupBox.Name = "newRentGroupBox";
            newRentGroupBox.Size = new Size(882, 246);
            newRentGroupBox.TabIndex = 16;
            newRentGroupBox.TabStop = false;
            newRentGroupBox.Text = "Renta de Vehiculo";
            // 
            // returnTimeDTP
            // 
            returnTimeDTP.Format = DateTimePickerFormat.Time;
            returnTimeDTP.Location = new Point(588, 176);
            returnTimeDTP.Name = "returnTimeDTP";
            returnTimeDTP.ShowUpDown = true;
            returnTimeDTP.Size = new Size(223, 25);
            returnTimeDTP.TabIndex = 14;
            // 
            // rentTimeDTP
            // 
            rentTimeDTP.Format = DateTimePickerFormat.Time;
            rentTimeDTP.Location = new Point(588, 140);
            rentTimeDTP.Name = "rentTimeDTP";
            rentTimeDTP.ShowUpDown = true;
            rentTimeDTP.Size = new Size(223, 25);
            rentTimeDTP.TabIndex = 13;
            // 
            // returnTimeLabel
            // 
            returnTimeLabel.AutoSize = true;
            returnTimeLabel.Location = new Point(440, 178);
            returnTimeLabel.Name = "returnTimeLabel";
            returnTimeLabel.Size = new Size(102, 17);
            returnTimeLabel.TabIndex = 12;
            returnTimeLabel.Text = "hora de entrga";
            // 
            // rentTimeLabel
            // 
            rentTimeLabel.AutoSize = true;
            rentTimeLabel.Location = new Point(441, 140);
            rentTimeLabel.Name = "rentTimeLabel";
            rentTimeLabel.Size = new Size(94, 17);
            rentTimeLabel.TabIndex = 11;
            rentTimeLabel.Text = "hora de retiro";
            // 
            // RentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 682);
            Controls.Add(titlePrincipalFormPanel);
            Controls.Add(saveRentButton);
            Controls.Add(rentsDataGridView);
            Controls.Add(deleteRentButton);
            Controls.Add(editRentButton);
            Controls.Add(newRentGroupBox);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label returnTimeLabel;
        private Label rentTimeLabel;
    }
}