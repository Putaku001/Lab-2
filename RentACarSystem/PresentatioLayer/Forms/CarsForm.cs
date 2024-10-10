using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Validation;
using BusinessLayer.Services;
using CommonLayer.Entities;

namespace PresentatioLayer.Forms
{
    public partial class CarsForm : Form
    {
        private CarService _carService;
        public bool isEditing = false;
        public CarsForm()
        {
            InitializeComponent();
            _carService = new CarService();
            LoadCars();
            CarsDataGridView.SelectionChanged += CarsDataGridView_SelectionChanged;
        }

        private void LoadCars()
        {
            CarsDataGridView.DataSource = _carService.GetAllCars();
            CarsDataGridView.Columns[4].ReadOnly = true;
        }

        private void saveCarButton_Click(object sender, EventArgs e)
        {
            string brandError, modelError, yearError;

            if (!CarsFormValidation.ValidateBrand(brandTextBox.Text, out brandError))
            {
                MessageBox.Show(brandError);
                return;
            }

            if (!CarsFormValidation.ValidateModel(modelTextBox.Text, out modelError))
            {
                MessageBox.Show(modelError);
                return;
            }

            if (!CarsFormValidation.ValidateYear(yearTextBox.Text, out yearError))
            {
                MessageBox.Show(yearError);
                return;
            }

            // Agregar un nuevo carro
            Car car = new Car()
            {
                Brand = brandTextBox.Text,
                Model = modelTextBox.Text,
                Year = int.Parse(yearTextBox.Text),
                Availability = availabilityCheckBox.Checked,
            };

            _carService.AddCar(car);
            LoadCars();
            MessageBox.Show("Carro guardado");

            // Limpiar los campos después de agregar
            ClearFields();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (CarsDataGridView.SelectedRows.Count > 0)
            {
                string brandError, modelError, yearError;

                if (!CarsFormValidation.ValidateBrand(brandTextBox.Text, out brandError))
                {
                    MessageBox.Show(brandError);
                    return;
                }

                if (!CarsFormValidation.ValidateModel(modelTextBox.Text, out modelError))
                {
                    MessageBox.Show(modelError);
                    return;
                }

                if (!CarsFormValidation.ValidateYear(yearTextBox.Text, out yearError))
                {
                    MessageBox.Show(yearError);
                    return;
                }

                // Editar el carro seleccionado
                Car car = new Car()
                {
                    CarId = int.Parse(CarsDataGridView.CurrentRow.Cells[0].Value.ToString()),
                    Brand = brandTextBox.Text,
                    Model = modelTextBox.Text,
                    Year = int.Parse(yearTextBox.Text),
                    Availability = availabilityCheckBox.Checked
                };

                _carService.EditCar(car);
                LoadCars();
                MessageBox.Show("Carro actualizado");

                // Limpiar los campos después de editar
                ClearFields();
            }
            else
            {
                MessageBox.Show("Seleccione un carro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (CarsDataGridView.SelectedRows.Count < 1)
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
                    int CarId = int.Parse(CarsDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _carService.DeleteCar(CarId);
                    LoadCars();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            RentForm rentForm = new RentForm();
            rentForm.Show();
        }

        private void dataVehicleGroupBox_Enter(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            brandTextBox.Text = "";
            modelTextBox.Text = "";
            yearTextBox.Text = "";
            availabilityCheckBox.Checked = false;
        }

       
        private void CarsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CarsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = CarsDataGridView.SelectedRows[0];
                brandTextBox.Text = selectedRow.Cells["Marca"].Value.ToString();
                modelTextBox.Text = selectedRow.Cells["Modelo"].Value.ToString();
                yearTextBox.Text = selectedRow.Cells["Año"].Value.ToString();
                availabilityCheckBox.Checked = Convert.ToBoolean(selectedRow.Cells["Disponibilidad"].Value);
            }
        }
    }
}
