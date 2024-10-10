using BusinessLayer.Services;
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
        public RentForm()
        {
            InitializeComponent();
            rentTimeDTP.Format = DateTimePickerFormat.Time;
            returnTimeDTP.Format = DateTimePickerFormat.Time;
            _rentService = new RentService();
            LoadRents();
            LoadCars();
            LoadClients();

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

    }
}
