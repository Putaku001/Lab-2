using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Validation;
using System.Windows.Forms;

namespace PresentatioLayer.Forms
{
    public partial class ClientForm : Form
    {
        private ClientRepository _clientRepository;
        public bool isEditing = false;

        public ClientForm()
        {
            InitializeComponent();
            _clientRepository = new ClientRepository();
            LoadClients();
            

            //evento de seleccionar dato
            clientDataGridView.SelectionChanged += clientDataGridView_SelectionChanged;
            
        }

        private void LoadClients()
        {
            DataTable clientsTable = _clientRepository.GetClients();
            clientDataGridView.DataSource = clientsTable;

            clientDataGridView.Columns["ClienteID"].HeaderText = "ID";
            clientDataGridView.Columns["Nombre"].HeaderText = "Nombre";
            clientDataGridView.Columns["Apellido"].HeaderText = "Apellido";
            clientDataGridView.Columns["Telefono"].HeaderText = "Teléfono";
            clientDataGridView.Columns["Licencia"].HeaderText = "Licencia";
        }
        private void clientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (clientDataGridView.SelectedRows.Count > 0)
                {
                    var selectedRow = clientDataGridView.SelectedRows[0];

                    // Verificar si las celdas no son nulas antes de acceder a sus valores
                    phoneTextBox.Text = selectedRow.Cells["Telefono"].Value?.ToString() ?? "N/A";
                    LastNameTextBox.Text = selectedRow.Cells["Apellido"].Value?.ToString() ?? "N/A";
                    licenceTextBox.Text = selectedRow.Cells["Licencia"].Value?.ToString() ?? "N/A";
                }
            }
            catch (NullReferenceException ex)
            {
                // Mensaje personalizado si ocurre una excepción
                MessageBox.Show("Ha seleccionado una fila que está en blanco o con datos incompletos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string nameError, phoneError, lastNameError, licenceError;

            if (!ClientFormValidation.ValidateName(nameTextBox.Text, out nameError))
            {
                MessageBox.Show(nameError);
                return;
            }

            if (!ClientFormValidation.ValidatePhone(phoneTextBox.Text, out phoneError))
            {
                MessageBox.Show(phoneError);
                return;
            }

            if (!ClientFormValidation.ValidateLastName(LastNameTextBox.Text, out lastNameError))
            {
                MessageBox.Show(lastNameError);
                return;
            }

            if (!ClientFormValidation.ValidateLicense(licenceTextBox.Text, out licenceError))
            {
                MessageBox.Show(licenceError);
                return;
            }

            Client client = new Client
            {
                Name = nameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Telephone = phoneTextBox.Text,
                License = licenceTextBox.Text,

            };

            _clientRepository.AddClient(client);
            MessageBox.Show("Cliente agregado con éxito");
            ClearForm();
            LoadClients();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count > 0)
            {
                string nameError, phoneError, lastNameError, licenceError;

                if (!ClientFormValidation.ValidateName(nameTextBox.Text, out nameError))
                {
                    MessageBox.Show(nameError);
                    return;
                }
                if (!ClientFormValidation.ValidateLastName(LastNameTextBox.Text, out lastNameError))
                {
                    MessageBox.Show(lastNameError);
                    return;
                }

                if (!ClientFormValidation.ValidatePhone(phoneTextBox.Text, out phoneError))
                {
                    MessageBox.Show(phoneError);
                    return;
                }

                if (!ClientFormValidation.ValidateLicense(licenceTextBox.Text, out licenceError))
                {
                    MessageBox.Show(licenceError);
                    return;
                }



                var selectedRow = clientDataGridView.SelectedRows[0];
                Client client = new Client
                {
                    ClientID = Convert.ToInt32(selectedRow.Cells["ClienteID"].Value),
                    Name = nameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Telephone = phoneTextBox.Text,
                    License = licenceTextBox.Text,

                };

                _clientRepository.EditClient(client);
                MessageBox.Show("Cliente editado con éxito");
                ClearForm();
                LoadClients();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar, por favor.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = clientDataGridView.SelectedRows[0];
                int clientId = Convert.ToInt32(selectedRow.Cells["ClienteID"].Value);

                var result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _clientRepository.DeleteClient(clientId);
                    MessageBox.Show("Cliente eliminado con éxito");
                    ClearForm();
                    LoadClients();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar, por favor.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void ClearForm()
        {
            nameTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            licenceTextBox.Text = string.Empty;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            RentForm rentForm = new RentForm();

            rentForm.Show();
        }

       
    
    }
}

