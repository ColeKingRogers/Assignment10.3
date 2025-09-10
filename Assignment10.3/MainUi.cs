using Assignment10._3.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment10._3
{
    public partial class MainUi : Form
    {
        Crud crud = new Crud();
        public MainUi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = crud.GetAllCar();
            dataGridView1.Columns["Manufacturer"].Visible = false;
            bntSubmit.Enabled = false;
            bntUpdate.Enabled = false;
            foreach (var manu in crud.GetManufacturer())
            {
                cbxManufacturer.Items.Add(manu.ManufacturerName);
            }
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            tbxCPrice.Clear();
            tbxCVin.Clear();
            tbxCModel.Clear();
            tbxCYear.Clear();
            cbxManufacturer.SelectedIndex = -1;
            bntSubmit.Enabled = true;
        }

        private void bntSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxCPrice.Text) && !string.IsNullOrEmpty(tbxCVin.Text) && !string.IsNullOrEmpty(tbxCModel.Text) && !string.IsNullOrEmpty(tbxCYear.Text) && cbxManufacturer.SelectedIndex != -1)
            {
                Models.Cars car = new Models.Cars()
                {
                    Price = Convert.ToDouble(tbxCPrice.Text),
                    Vin = tbxCVin.Text,
                    Model = tbxCModel.Text,
                    Year = Convert.ToInt32(tbxCYear.Text),
                    ManufacturerId = cbxManufacturer.SelectedIndex + 1
                };
                crud.AddCar(car);
                dataGridView1.DataSource = crud.GetAllCar();
                bntSubmit.Enabled = false;

            }
            else

            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            var model = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            crud.DeleteCar(model);
            dataGridView1.DataSource = crud.GetAllCar();
        }

        private void bntUpdateSelect_Click(object sender, EventArgs e)
        {
            var model = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            var car = crud.GetCarByModel(model);
            if (car != null)
            {
                tbxCPrice.Text = Convert.ToString(car.Price);
                tbxCVin.Text = car.Vin;
                tbxCModel.Text = car.Model.ToString();
                cbxManufacturer.SelectedIndex = car.ManufacturerId - 1;
                bntUpdate.Enabled = true;
                bntSubmit.Enabled = false;
            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbxCPrice.Text) && !string.IsNullOrEmpty(tbxCVin.Text) && !string.IsNullOrEmpty(tbxCModel.Text) && !string.IsNullOrEmpty(tbxCYear.Text) && cbxManufacturer.SelectedIndex != -1)
            {
                var model = tbxCModel.Text;
                var car = crud.GetCarByModel(model);
                car.Vin = tbxCVin.Text;
                car.Model = tbxCModel.Text;
                car.ManufacturerId = cbxManufacturer.SelectedIndex + 1;
                crud.UpdateCar(model ,car);
                dataGridView1.DataSource = crud.GetAllCar();
                MessageBox.Show("Cars Updated Successfully");
                bntUpdate.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }
    }
}
