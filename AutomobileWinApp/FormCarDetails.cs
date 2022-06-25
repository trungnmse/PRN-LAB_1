using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.Repository;
namespace AutomobileWinApp
{
    public partial class FormCarDetails : Form
    {
        public bool IsInsertMode { get; set; } = false;
        public bool IsUpdateMode { get; set; } = false;
        public ICarRepository? CarRepository;
        public Car? Car { get; set; }
        public FormCarDetails()
        {
            InitializeComponent();
        }

        public void FormCarDetails_Load(object? sender, EventArgs e)
        {
            comboBoxManufacturer.SelectedIndex = 0;
            if (IsInsertMode)
            {
                textBoxCarId.Enabled = IsInsertMode;
            }

            if (IsUpdateMode)
            {
                textBoxCarId.Enabled = false;
                textBoxCarId.Text = Car?.CarId.ToString();
                textBoxCarName.Text = Car?.CarName;
                maskedTextBoxPrice.Text = Car?.Price.ToString();
                maskedTextBoxReleaseYear.Text = Car?.ReleaseYear.ToString();
                comboBoxManufacturer.Text = Car?.Manufacturer;
            };
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarId = int.Parse(textBoxCarId.Text),
                    CarName = textBoxCarName.Text,
                    Manufacturer = comboBoxManufacturer.Text,
                    Price = int.Parse(maskedTextBoxPrice.Text),
                    ReleaseYear = int.Parse(maskedTextBoxReleaseYear.Text),
                };
                if (IsInsertMode && CarRepository != null)
                {
                    CarRepository.InsertCar(car);
                    this.DialogResult = DialogResult.OK;
                }
                if (IsUpdateMode && CarRepository != null)
                {
                    CarRepository.UpdateCar(car);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}