namespace PresentatioLayer.Forms
{
    partial class ClientForm
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
            tittleLabel = new Label();
            nameLabel = new Label();
            lastNameLabel = new Label();
            phoneLabel = new Label();
            nameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            clientDataGridView = new DataGridView();
            BackButton = new Button();
            clienteDataGroupBox = new GroupBox();
            clientActiongroupBox = new GroupBox();
            licenceLabel = new Label();
            licenseTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).BeginInit();
            clienteDataGroupBox.SuspendLayout();
            clientActiongroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Algerian", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tittleLabel.Location = new Point(574, 21);
            tittleLabel.Margin = new Padding(4, 0, 4, 0);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(125, 30);
            tittleLabel.TabIndex = 0;
            tittleLabel.Text = "Cliente";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(36, 27);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(75, 23);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Nombre:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(40, 100);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(76, 23);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "apellido:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(37, 189);
            phoneLabel.Margin = new Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(79, 23);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Telefono:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(36, 60);
            nameTextBox.Margin = new Padding(4);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(413, 36);
            nameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(38, 134);
            lastNameTextBox.Margin = new Padding(4);
            lastNameTextBox.Multiline = true;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(411, 36);
            lastNameTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(40, 225);
            phoneTextBox.Margin = new Padding(4);
            phoneTextBox.Multiline = true;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(409, 43);
            phoneTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.Location = new Point(33, 68);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(214, 39);
            addButton.TabIndex = 7;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(154, 20);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(215, 40);
            editButton.TabIndex = 8;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(255, 68);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(209, 39);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // clientDataGridView
            // 
            clientDataGridView.BackgroundColor = SystemColors.Control;
            clientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDataGridView.Location = new Point(574, 71);
            clientDataGridView.Margin = new Padding(4);
            clientDataGridView.Name = "clientDataGridView";
            clientDataGridView.RowHeadersWidth = 51;
            clientDataGridView.Size = new Size(604, 412);
            clientDataGridView.TabIndex = 10;
            clientDataGridView.SelectionChanged += clientDataGridView_SelectionChanged;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(255, 192, 128);
            BackButton.Location = new Point(7, 6);
            BackButton.Margin = new Padding(4, 3, 4, 3);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(142, 37);
            BackButton.TabIndex = 11;
            BackButton.Text = "Regresar";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // clienteDataGroupBox
            // 
            clienteDataGroupBox.Controls.Add(licenseTextBox);
            clienteDataGroupBox.Controls.Add(licenceLabel);
            clienteDataGroupBox.Controls.Add(phoneTextBox);
            clienteDataGroupBox.Controls.Add(lastNameTextBox);
            clienteDataGroupBox.Controls.Add(nameTextBox);
            clienteDataGroupBox.Controls.Add(phoneLabel);
            clienteDataGroupBox.Controls.Add(lastNameLabel);
            clienteDataGroupBox.Controls.Add(nameLabel);
            clienteDataGroupBox.Location = new Point(28, 49);
            clienteDataGroupBox.Name = "clienteDataGroupBox";
            clienteDataGroupBox.Size = new Size(512, 352);
            clienteDataGroupBox.TabIndex = 12;
            clienteDataGroupBox.TabStop = false;
            clienteDataGroupBox.Text = "Datos Personales";
            // 
            // clientActiongroupBox
            // 
            clientActiongroupBox.Controls.Add(addButton);
            clientActiongroupBox.Controls.Add(deleteButton);
            clientActiongroupBox.Controls.Add(editButton);
            clientActiongroupBox.Location = new Point(31, 443);
            clientActiongroupBox.Name = "clientActiongroupBox";
            clientActiongroupBox.Size = new Size(509, 125);
            clientActiongroupBox.TabIndex = 13;
            clientActiongroupBox.TabStop = false;
            clientActiongroupBox.Text = "Acciones";
            // 
            // licenceLabel
            // 
            licenceLabel.AutoSize = true;
            licenceLabel.Location = new Point(38, 275);
            licenceLabel.Margin = new Padding(4, 0, 4, 0);
            licenceLabel.Name = "licenceLabel";
            licenceLabel.Size = new Size(161, 23);
            licenceLabel.TabIndex = 7;
            licenceLabel.Text = "licencia de conducir:";
            // 
            // licenseTextBox
            // 
            licenseTextBox.Location = new Point(40, 302);
            licenseTextBox.Margin = new Padding(4);
            licenseTextBox.Multiline = true;
            licenseTextBox.Name = "licenseTextBox";
            licenseTextBox.Size = new Size(409, 43);
            licenseTextBox.TabIndex = 8;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1215, 600);
            Controls.Add(clienteDataGroupBox);
            Controls.Add(BackButton);
            Controls.Add(clientDataGridView);
            Controls.Add(tittleLabel);
            Controls.Add(clientActiongroupBox);
            Font = new Font("Tw Cen MT Condensed Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "ClientForm";
            Padding = new Padding(3, 0, 3, 0);
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).EndInit();
            clienteDataGroupBox.ResumeLayout(false);
            clienteDataGroupBox.PerformLayout();
            clientActiongroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tittleLabel;
        private Label nameLabel;
        private Label lastNameLabel;
        private Label phoneLabel;
        private TextBox nameTextBox;
        private TextBox lastNameTextBox;
        private TextBox phoneTextBox;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private DataGridView clientDataGridView;
        private Button BackButton;
        private GroupBox clienteDataGroupBox;
        private GroupBox clientActiongroupBox;
        private TextBox licenseTextBox;
        private Label licenceLabel;
    }
}