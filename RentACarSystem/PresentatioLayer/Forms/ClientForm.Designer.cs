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
            emailLabel = new Label();
            phoneLabel = new Label();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            clientDataGridView = new DataGridView();
            BackButton = new Button();
            clienteDataGroupBox = new GroupBox();
            clientActiongroupBox = new GroupBox();
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
            tittleLabel.Size = new Size(97, 24);
            tittleLabel.TabIndex = 0;
            tittleLabel.Text = "Cliente";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(36, 27);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Nombre:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(40, 104);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 20);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email: ";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(37, 200);
            phoneLabel.Margin = new Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(64, 20);
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
            // emailTextBox
            // 
            emailTextBox.Location = new Point(38, 134);
            emailTextBox.Margin = new Padding(4);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(411, 36);
            emailTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(40, 236);
            phoneTextBox.Margin = new Padding(4);
            phoneTextBox.Multiline = true;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(409, 43);
            phoneTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Aquamarine;
            addButton.Location = new Point(33, 68);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(214, 39);
            addButton.TabIndex = 7;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Aquamarine;
            editButton.Location = new Point(182, 396);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(215, 40);
            editButton.TabIndex = 8;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Aquamarine;
            deleteButton.Location = new Point(255, 68);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(209, 39);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // clientDataGridView
            // 
            clientDataGridView.BackgroundColor = SystemColors.Control;
            clientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDataGridView.Location = new Point(574, 88);
            clientDataGridView.Margin = new Padding(4);
            clientDataGridView.Name = "clientDataGridView";
            clientDataGridView.RowHeadersWidth = 51;
            clientDataGridView.Size = new Size(488, 348);
            clientDataGridView.TabIndex = 10;
            clientDataGridView.SelectionChanged += clientDataGridView_SelectionChanged;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Aquamarine;
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
            clienteDataGroupBox.Controls.Add(phoneTextBox);
            clienteDataGroupBox.Controls.Add(emailTextBox);
            clienteDataGroupBox.Controls.Add(nameTextBox);
            clienteDataGroupBox.Controls.Add(phoneLabel);
            clienteDataGroupBox.Controls.Add(emailLabel);
            clienteDataGroupBox.Controls.Add(nameLabel);
            clienteDataGroupBox.FlatStyle = FlatStyle.System;
            clienteDataGroupBox.ForeColor = SystemColors.ActiveCaptionText;
            clienteDataGroupBox.Location = new Point(31, 71);
            clienteDataGroupBox.Name = "clienteDataGroupBox";
            clienteDataGroupBox.Size = new Size(512, 299);
            clienteDataGroupBox.TabIndex = 12;
            clienteDataGroupBox.TabStop = false;
            clienteDataGroupBox.Text = "Datos Personales";
            // 
            // clientActiongroupBox
            // 
            clientActiongroupBox.Controls.Add(addButton);
            clientActiongroupBox.Controls.Add(deleteButton);
            clientActiongroupBox.Location = new Point(34, 376);
            clientActiongroupBox.Name = "clientActiongroupBox";
            clientActiongroupBox.Size = new Size(509, 125);
            clientActiongroupBox.TabIndex = 13;
            clientActiongroupBox.TabStop = false;
            clientActiongroupBox.Text = "Acciones";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightGray;
            ClientSize = new Size(1070, 497);
            Controls.Add(clienteDataGroupBox);
            Controls.Add(BackButton);
            Controls.Add(clientDataGridView);
            Controls.Add(editButton);
            Controls.Add(tittleLabel);
            Controls.Add(clientActiongroupBox);
            Font = new Font("Tw Cen MT Condensed Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "ClientForm";
            Padding = new Padding(3, 0, 3, 0);
            Text = "ClientForm";
            TransparencyKey = Color.LightGreen;
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
        private Label emailLabel;
        private Label phoneLabel;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private DataGridView clientDataGridView;
        private Button BackButton;
        private GroupBox clienteDataGroupBox;
        private GroupBox clientActiongroupBox;
    }
}