using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.Repository;

namespace AutomobileWinApp
{
    public partial class FormCarManagement : Form
    {
        private ICarRepository _carRepository = new CarRepository();
        private BindingSource _source;
        public FormCarManagement()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            textBoxCarId.Text = string.Empty;
            textBoxCarName.Text = string.Empty;
            textBoxManufacturer.Text = string.Empty;
            textBoxReleaseYear.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
        }
        private void FormCarManagement_Load(object sender, EventArgs e)
        {
            buttonDelete.Enabled = false;
        }

        private Car? GetCarObject()
        {
            try
            {
                return new Car
                {
                    CarId = textBoxCarId.Text != null ? int.Parse(textBoxCarId.Text) : 0,
                    CarName = textBoxCarName.Text,
                    Price = textBoxPrice.Text != null ? int.Parse(textBoxPrice.Text) : 0,
                    Manufacturer = textBoxManufacturer.Text,
                    ReleaseYear = textBoxReleaseYear.Text != null ? int.Parse(textBoxReleaseYear.Text) : 0,
                };
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        private void dataGridListCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCarDetails formCarDetails = new FormCarDetails
            {
                Text = "Update Car",
                IsUpdateMode = true,
                Car = GetCarObject(),
                CarRepository = _carRepository
            };

            if (formCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                _source.Position = _source.Count - 1;
            }
        }

        private void LoadCarList()
        {
            var cars = _carRepository.GetCars();
            try
            {
                _source = new BindingSource();
                _source.DataSource = cars;

                textBoxCarId.DataBindings.Clear();
                textBoxCarName.DataBindings.Clear();
                textBoxManufacturer.DataBindings.Clear();
                textBoxPrice.DataBindings.Clear();
                textBoxReleaseYear.DataBindings.Clear();

                textBoxCarId.DataBindings.Add("Text", _source, "CarId");
                textBoxCarName.DataBindings.Add("Text", _source, "CarName");
                textBoxManufacturer.DataBindings.Add("Text", _source, "Manufacturer");
                textBoxPrice.DataBindings.Add("Text", _source, "Price");
                textBoxReleaseYear.DataBindings.Add("Text", _source, "ReleaseYear");

                dataGridListCar.DataSource = null;
                dataGridListCar.DataSource = _source;
                if (cars.Any())
                {
                    buttonDelete.Enabled = true;
                }
                else
                {
                    ClearText();
                    buttonDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormCarDetails formCarDetails = new FormCarDetails
            {
                Text = "Insert Car",
                IsInsertMode = true,
                Car = GetCarObject(),
                CarRepository = _carRepository
            };

            if (formCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                _source.Position = _source.Count - 1;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var car = GetCarObject();
                if (car != null)
                {
                    _carRepository.DeleteCar(car.CarId);
                    LoadCarList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Delete a car");
            }
        }
    }
}
