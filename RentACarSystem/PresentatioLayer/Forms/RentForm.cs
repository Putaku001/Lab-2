using BusinessLayer.Services;
using CommonLayer.Entities;
using PresentatioLayer.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentatioLayer.Forms
{
    public partial class RentForm : Form
    {
        private RentService _rentService;
        public bool isEditing = false;
        public RentForm()
        {
            InitializeComponent();
            rentTimeDTP.Format = DateTimePickerFormat.Time;
            returnTimeDTP.Format = DateTimePickerFormat.Time;
            _rentService = new RentService();
            LoadRents();
            LoadCars();
            LoadClients();
            rentsDataGridView.SelectionChanged += rentsDataGridView_SelectionChanged;

        }

        public void LoadCars()
        {
            CarscomboBox.DataSource = _rentService.GetCars();
            CarscomboBox.DisplayMember = "CarFullName";
            CarscomboBox.ValueMember = "VehiculoID";

        }
        public void LoadClients()
        {
            ClientscomboBox.DataSource = _rentService.GetClients();
            ClientscomboBox.DisplayMember = "ClientName";
            ClientscomboBox.ValueMember = "ClienteID";
        }

        public void LoadRents()
        {
            rentsDataGridView.DataSource = _rentService.GetRents();
        }
        private void clientsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm clientForm = new ClientForm();
            clientForm.Show();

        }

        private void carsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
        }

        private void RentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveRentButton_Click(object sender, EventArgs e)
        {
            string clientError, carError, dateError, timeError;
            TimeSpan rentTime = rentTimeDTP.Value.TimeOfDay;
            TimeSpan returnTime = returnTimeDTP.Value.TimeOfDay;

            if (!RentFormValidation.ValidateClientSelection(ClientscomboBox.SelectedValue, out clientError))
            {
                MessageBox.Show(clientError);
                return;
            }

            if (!RentFormValidation.ValidateCarSelection(CarscomboBox.SelectedValue, out carError))
            {
                MessageBox.Show(carError);
                return;
            }

            if (!RentFormValidation.ValidateDates(rentDateDTP.Value, rentReturnDTP.Value, out dateError))
            {
                MessageBox.Show(dateError);
                return;
            }

            if (!RentFormValidation.ValidateTimes(rentDateDTP.Value, rentReturnDTP.Value, rentTime, returnTime, out timeError))
            {
                MessageBox.Show(timeError);
                return;
            }

            Rent rent = new Rent()
            {
                ClientID = Convert.ToInt32(ClientscomboBox.SelectedValue),
                CarID = Convert.ToInt32(CarscomboBox.SelectedValue),
                RentDate = rentDateDTP.Value,
                RentTime = rentTime.ToString(@"hh\:mm\:ss"),
                ReturnDate = rentReturnDTP.Value,
                ReturnTime = returnTime.ToString(@"hh\:mm\:ss"),
            };

            _rentService.AddRent(rent);
            MessageBox.Show("Renta añadida con éxito.");
            LoadRents();

        }

        private void editRentButton_Click(object sender, EventArgs e)
        {
            string clientError, carError, dateError, timeError;
            TimeSpan rentTime = rentTimeDTP.Value.TimeOfDay;
            TimeSpan returnTime = returnTimeDTP.Value.TimeOfDay;

            if (!RentFormValidation.ValidateClientSelection(ClientscomboBox.SelectedValue, out clientError))
            {
                MessageBox.Show(clientError);
                return;
            }

            if (!RentFormValidation.ValidateCarSelection(CarscomboBox.SelectedValue, out carError))
            {
                MessageBox.Show(carError);
                return;
            }

            if (!RentFormValidation.ValidateDates(rentDateDTP.Value, rentReturnDTP.Value, out dateError))
            {
                MessageBox.Show(dateError);
                return;
            }

            if (!RentFormValidation.ValidateTimes(rentDateDTP.Value, rentReturnDTP.Value, rentTime, returnTime, out timeError))
            {
                MessageBox.Show(timeError);
                return;
            }

            Rent rent = new Rent()
            {
                RentID = int.Parse(rentsDataGridView.CurrentRow.Cells[0].Value.ToString()),
                ClientID = Convert.ToInt32(ClientscomboBox.SelectedValue),
                CarID = Convert.ToInt32(CarscomboBox.SelectedValue),
                RentDate = rentDateDTP.Value,
                RentTime = rentTime.ToString(@"hh\:mm\:ss"),
                ReturnDate = rentReturnDTP.Value,
                ReturnTime = returnTime.ToString(@"hh\:mm\:ss"),
            };

            _rentService.EditRent(rent);
            LoadRents();
            MessageBox.Show("Renta editada con éxito.");


        }
        private void deleteRentButton_Click(object sender, EventArgs e)
        {
            if (rentsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Por favor, seleccione el carro a eliminar",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar este dato?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int CarId = int.Parse(rentsDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _rentService.DeleteRent(CarId);
                    LoadRents();
                }
            }
        }

        private void rentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (rentsDataGridView.SelectedRows.Count > 0)
                {
                    var selectedRow = rentsDataGridView.SelectedRows[0];

                    // Verificar si la celda tiene un valor antes de convertirlo a texto
                    ClientscomboBox.Text = selectedRow.Cells[1].Value != null ? selectedRow.Cells[1].Value.ToString() : string.Empty;
                    CarscomboBox.Text = selectedRow.Cells[3].Value != null ? selectedRow.Cells[3].Value.ToString() : string.Empty;

                    // Verifica si la celda 4 tiene un valor
                    if (selectedRow.Cells[4].Value != null)
                    {
                        rentDateDTP.Value = Convert.ToDateTime(selectedRow.Cells[4].Value);
                    }

                    // Condición para pasarle el dato correcto al campo hora de renta
                    if (selectedRow.Cells[5].Value is TimeSpan rentTime)
                    {
                        rentTimeDTP.Value = DateTime.Today + rentTime;
                    }
                    else if (selectedRow.Cells[5].Value is string rentTimeString &&
                             TimeSpan.TryParse(rentTimeString, out TimeSpan parsedRentTime))
                    {
                        rentTimeDTP.Value = DateTime.Today + parsedRentTime;
                    }
                    else
                    {
                        rentTimeDTP.Value = DateTime.Today;
                    }

                    // Verifica si la celda 6 tiene un valor
                    if (selectedRow.Cells[6].Value != null)
                    {
                        rentReturnDTP.Value = Convert.ToDateTime(selectedRow.Cells[6].Value);
                    }

                    // Condición para pasarle dato correcto al campo hora devolución
                    if (selectedRow.Cells[7].Value is TimeSpan returnTime)
                    {
                        returnTimeDTP.Value = DateTime.Today + returnTime;
                    }
                    else if (selectedRow.Cells[7].Value is string returnTimeString &&
                             TimeSpan.TryParse(returnTimeString, out TimeSpan parsedReturnTime))
                    {
                        returnTimeDTP.Value = DateTime.Today + parsedReturnTime;
                    }
                    else
                    {
                        returnTimeDTP.Value = DateTime.Today;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"selecciono una casilla nula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
