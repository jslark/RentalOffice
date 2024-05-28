namespace RentalOffice
{
    public partial class BookForm : Form
    {
        DataAccess _dataAccess = new DataAccess();

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            var customers = _dataAccess.GetAllCustomers();
            var workers = _dataAccess.GetAllWorkers();
            var movies = _dataAccess.GetAllMovies();

            cbxCustomer.DataSource = customers;
            cbxCustomer.DisplayMember = "SURNAME";
            cbxCustomer.ValueMember = "ID";

            cbxWorker.DataSource = workers;
            cbxWorker.DisplayMember = "SURNAME";
            cbxWorker.ValueMember = "ID";

            cbxMovie.DataSource = movies;
            cbxMovie.DisplayMember = "Title";
            cbxMovie.ValueMember = "ID";
        }

        private void cbxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbxMovie.SelectedValue);

            var price = _dataAccess.GetMoviePrice(id);

            lblPrice.Text = price.ToString();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            var booking = new Book();
            booking.ID_COSTUMER = Convert.ToInt32(cbxCustomer.SelectedValue);
            booking.ID_WORKER = Convert.ToInt32(cbxWorker.SelectedValue);
            booking.ID_MOVIES = Convert.ToInt32(cbxMovie.SelectedValue);
            booking.RENTAL_DATE = dtpDate.Value;

            _dataAccess.SetBooking(booking);
        }
    }
}
