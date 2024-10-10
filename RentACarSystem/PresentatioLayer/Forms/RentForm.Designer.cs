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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            clientsButton.BackColor = Color.LightGray;
            clientsButton.Location = new Point(971, 21);
            clientsButton.Margin = new Padding(0);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(250, 43);
            clientsButton.TabIndex = 0;
            clientsButton.Text = "registro de clientes";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += clientsButton_Click;
            // 
            // carsButton
            // 
            carsButton.BackColor = Color.LightGray;
            carsButton.Location = new Point(971, 113);
            carsButton.Margin = new Padding(5, 3, 5, 3);
            carsButton.Name = "carsButton";
            carsButton.Size = new Size(250, 44);
            carsButton.TabIndex = 1;
            carsButton.Text = "registro de carros";
            carsButton.UseVisualStyleBackColor = false;
            carsButton.Click += carsButton_Click;
            // 
            // clientsLabel
            // 
            clientsLabel.BackColor = Color.LightGray;
            clientsLabel.BorderStyle = BorderStyle.Fixed3D;
            clientsLabel.Font = new Font("Bahnschrift", 13F);
            clientsLabel.Location = new Point(34, 43);
            clientsLabel.Margin = new Padding(5, 0, 5, 0);
            clientsLabel.Name = "clientsLabel";
            clientsLabel.Size = new Size(210, 34);
            clientsLabel.TabIndex = 2;
            clientsLabel.Text = "Seleccionar Cliente";
            // 
            // CarLabel
            // 
            CarLabel.BackColor = Color.LightGray;
            CarLabel.Font = new Font("Bahnschrift", 13F);
            CarLabel.Location = new Point(34, 123);
            CarLabel.Margin = new Padding(5, 0, 5, 0);
            CarLabel.Name = "CarLabel";
            CarLabel.Size = new Size(210, 34);
            CarLabel.TabIndex = 3;
            CarLabel.Text = "Seleccionar Carro";
            // 
            // rentDateLabel
            // 
            rentDateLabel.BackColor = Color.LightGray;
            rentDateLabel.BorderStyle = BorderStyle.Fixed3D;
            rentDateLabel.Font = new Font("Bahnschrift", 13F);
            rentDateLabel.Location = new Point(11, 224);
            rentDateLabel.Margin = new Padding(5, 0, 5, 0);
            rentDateLabel.Name = "rentDateLabel";
            rentDateLabel.Size = new Size(250, 44);
            rentDateLabel.TabIndex = 4;
            rentDateLabel.Text = "Fecha y hora de retiro";
            // 
            // rentReturnLabel
            // 
            rentReturnLabel.BackColor = Color.LightGray;
            rentReturnLabel.BorderStyle = BorderStyle.Fixed3D;
            rentReturnLabel.Font = new Font("Bahnschrift", 13F);
            rentReturnLabel.Location = new Point(11, 298);
            rentReturnLabel.Margin = new Padding(5, 0, 5, 0);
            rentReturnLabel.Name = "rentReturnLabel";
            rentReturnLabel.Size = new Size(286, 42);
            rentReturnLabel.TabIndex = 5;
            rentReturnLabel.Text = "Fecha y hora de devolucion";
            // 
            // saveRentButton
            // 
            saveRentButton.BackColor = Color.LightGray;
            saveRentButton.ForeColor = Color.Black;
            saveRentButton.Location = new Point(1340, 109);
            saveRentButton.Margin = new Padding(5, 3, 5, 3);
            saveRentButton.Name = "saveRentButton";
            saveRentButton.Size = new Size(146, 70);
            saveRentButton.TabIndex = 6;
            saveRentButton.Text = "Guardar";
            saveRentButton.UseVisualStyleBackColor = false;
            saveRentButton.Click += saveRentButton_Click;
            // 
            // editRentButton
            // 
            editRentButton.BackColor = Color.LightGray;
            editRentButton.Location = new Point(1340, 238);
            editRentButton.Margin = new Padding(5, 3, 5, 3);
            editRentButton.Name = "editRentButton";
            editRentButton.Size = new Size(146, 70);
            editRentButton.TabIndex = 7;
            editRentButton.Text = "Editar";
            editRentButton.UseVisualStyleBackColor = false;
            editRentButton.Click += editRentButton_Click;
            // 
            // deleteRentButton
            // 
            deleteRentButton.BackColor = Color.LightGray;
            deleteRentButton.Location = new Point(1340, 372);
            deleteRentButton.Margin = new Padding(5, 3, 5, 3);
            deleteRentButton.Name = "deleteRentButton";
            deleteRentButton.Size = new Size(146, 70);
            deleteRentButton.TabIndex = 8;
            deleteRentButton.Text = "Eliminar";
            deleteRentButton.UseVisualStyleBackColor = false;
            deleteRentButton.Click += deleteRentButton_Click;
            // 
            // ClientscomboBox
            // 
            ClientscomboBox.BackColor = SystemColors.ControlLightLight;
            ClientscomboBox.FormattingEnabled = true;
            ClientscomboBox.Location = new Point(300, 39);
            ClientscomboBox.Margin = new Padding(5, 3, 5, 3);
            ClientscomboBox.Name = "ClientscomboBox";
            ClientscomboBox.Size = new Size(269, 35);
            ClientscomboBox.TabIndex = 9;
            // 
            // CarscomboBox
            // 
            CarscomboBox.BackColor = SystemColors.ButtonFace;
            CarscomboBox.ForeColor = SystemColors.ControlText;
            CarscomboBox.FormattingEnabled = true;
            CarscomboBox.Location = new Point(300, 123);
            CarscomboBox.Margin = new Padding(5, 3, 5, 3);
            CarscomboBox.Name = "CarscomboBox";
            CarscomboBox.Size = new Size(269, 35);
            CarscomboBox.TabIndex = 10;
            // 
            // rentDateDTP
            // 
            rentDateDTP.CustomFormat = "";
            rentDateDTP.Location = new Point(319, 224);
            rentDateDTP.Margin = new Padding(5, 3, 5, 3);
            rentDateDTP.Name = "rentDateDTP";
            rentDateDTP.Size = new Size(428, 34);
            rentDateDTP.TabIndex = 11;
            rentDateDTP.Value = new DateTime(2024, 10, 9, 11, 41, 40, 0);
            // 
            // rentReturnDTP
            // 
            rentReturnDTP.Location = new Point(319, 306);
            rentReturnDTP.Margin = new Padding(5, 3, 5, 3);
            rentReturnDTP.Name = "rentReturnDTP";
            rentReturnDTP.Size = new Size(428, 34);
            rentReturnDTP.TabIndex = 12;
            // 
            // rentsDataGridView
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Khaki;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            rentsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            rentsDataGridView.Anchor = AnchorStyles.None;
            rentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rentsDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            rentsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            rentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            rentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            rentsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            rentsDataGridView.GridColor = Color.FromArgb(255, 255, 192);
            rentsDataGridView.Location = new Point(14, 516);
            rentsDataGridView.Margin = new Padding(5, 3, 5, 3);
            rentsDataGridView.MaximumSize = new Size(1660, 600);
            rentsDataGridView.MinimumSize = new Size(500, 300);
            rentsDataGridView.Name = "rentsDataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            rentsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            rentsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            rentsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            rentsDataGridView.ScrollBars = ScrollBars.Vertical;
            rentsDataGridView.Size = new Size(1472, 350);
            rentsDataGridView.TabIndex = 13;
            // 
            // titlePrincipalFormPanel
            // 
            titlePrincipalFormPanel.BackColor = Color.WhiteSmoke;
            titlePrincipalFormPanel.Controls.Add(tittleLabel);
            titlePrincipalFormPanel.Location = new Point(17, 10);
            titlePrincipalFormPanel.Margin = new Padding(5, 3, 5, 3);
            titlePrincipalFormPanel.Name = "titlePrincipalFormPanel";
            titlePrincipalFormPanel.Size = new Size(2074, 83);
            titlePrincipalFormPanel.TabIndex = 15;
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tittleLabel.Location = new Point(648, 12);
            tittleLabel.Margin = new Padding(5, 0, 5, 0);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(451, 44);
            tittleLabel.TabIndex = 0;
            tittleLabel.Text = "The Brothers Rent A Car";
            // 
            // newRentGroupBox
            // 
            newRentGroupBox.BackColor = Color.OldLace;
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
            newRentGroupBox.Location = new Point(17, 102);
            newRentGroupBox.Margin = new Padding(5, 4, 5, 4);
            newRentGroupBox.Name = "newRentGroupBox";
            newRentGroupBox.Padding = new Padding(5, 4, 5, 4);
            newRentGroupBox.Size = new Size(1297, 398);
            newRentGroupBox.TabIndex = 16;
            newRentGroupBox.TabStop = false;
            newRentGroupBox.Text = "Renta de Vehiculo";
            // 
            // returnTimeDTP
            // 
            returnTimeDTP.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnTimeDTP.Format = DateTimePickerFormat.Time;
            returnTimeDTP.Location = new Point(782, 306);
            returnTimeDTP.Margin = new Padding(5, 4, 5, 4);
            returnTimeDTP.Name = "returnTimeDTP";
            returnTimeDTP.ShowUpDown = true;
            returnTimeDTP.Size = new Size(178, 32);
            returnTimeDTP.TabIndex = 14;
            // 
            // rentTimeDTP
            // 
            rentTimeDTP.CustomFormat = "";
            rentTimeDTP.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentTimeDTP.Format = DateTimePickerFormat.Time;
            rentTimeDTP.Location = new Point(782, 224);
            rentTimeDTP.Name = "rentTimeDTP";
            rentTimeDTP.ShowUpDown = true;
            rentTimeDTP.Size = new Size(178, 32);
            rentTimeDTP.TabIndex = 13;
            rentTimeDTP.Value = new DateTime(2024, 10, 10, 12, 33, 0, 0);
            // 
            // RentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MistyRose;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1632, 770);
            Controls.Add(titlePrincipalFormPanel);
            Controls.Add(newRentGroupBox);
            Controls.Add(saveRentButton);
            Controls.Add(deleteRentButton);
            Controls.Add(editRentButton);
            Controls.Add(rentsDataGridView);
            Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            MaximumSize = new Size(1650, 900);
            Name = "RentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentForm";
            FormClosing += RentForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)rentsDataGridView).EndInit();
            titlePrincipalFormPanel.ResumeLayout(false);
            titlePrincipalFormPanel.PerformLayout();
            newRentGroupBox.ResumeLayout(false);
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