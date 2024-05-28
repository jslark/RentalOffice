using System.Data;
using System.Windows.Forms;

namespace RentalOffice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateDgvColumns();
            var dataAccess = new DataAccess();
            DataTable dataTable = dataAccess.GetAllBookings();
            dgvMain.DataSource = dataTable;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            BookForm form = new BookForm();
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

            }
        }

        private void CreateDgvColumns()
        {
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "ID";
            idColumn.Visible = false;
            dgvMain.Columns.Add(idColumn);

            DataGridViewTextBoxColumn idMoviesColumn = new DataGridViewTextBoxColumn();
            idMoviesColumn.Name = "ID_MOVIES";
            idMoviesColumn.HeaderText = "ID_MOVIES";
            idMoviesColumn.DataPropertyName = "ID_MOVIES";
            idMoviesColumn.Visible = false;
            dgvMain.Columns.Add(idMoviesColumn);

            DataGridViewTextBoxColumn titleColumn = new DataGridViewTextBoxColumn();
            titleColumn.Name = "TITTLE";
            titleColumn.HeaderText = "Tytu³";
            titleColumn.DataPropertyName = "TITTLE";
            titleColumn.Visible = true;
            dgvMain.Columns.Add(titleColumn);

            DataGridViewTextBoxColumn speciesColumn = new DataGridViewTextBoxColumn();
            speciesColumn.Name = "SPECIES";
            speciesColumn.HeaderText = "Gatunek";
            speciesColumn.DataPropertyName = "SPECIES";
            speciesColumn.Visible = true;
            dgvMain.Columns.Add(speciesColumn);

            DataGridViewTextBoxColumn customerColumn = new DataGridViewTextBoxColumn();
            customerColumn.Name = "CUSTOMER_SURNAME";
            customerColumn.HeaderText = "Nazwisko klienta";
            customerColumn.DataPropertyName = "CUSTOMER_SURNAME";
            customerColumn.Visible = true;
            dgvMain.Columns.Add(customerColumn);

            DataGridViewTextBoxColumn workerColumn = new DataGridViewTextBoxColumn();
            workerColumn.Name = "WORKER_SURNAME";
            workerColumn.HeaderText = "Nazwisko pracownika";
            workerColumn.DataPropertyName = "WORKER_SURNAME";
            workerColumn.Visible = true;
            dgvMain.Columns.Add(workerColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.Name = "PRICE";
            priceColumn.HeaderText = "Cena";
            priceColumn.DataPropertyName = "PRICE";
            priceColumn.Visible = true;
            dgvMain.Columns.Add(priceColumn);
        }
    }
}
