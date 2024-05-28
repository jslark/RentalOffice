using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.IO;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RentalOffice
{
    public class DataAccess
    {
        static void Connection()
        {

        }
        public DataTable GetAllBookings()
        {
            //string connectionString = //"Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)" +
            //                          //"(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = ORCL))); User Id = sys as sysdba; Password = Kurwa1!1;";
            //                          //"User Id=sys as sysdba;Password=Kurwa1!1;Data Source=localhost:1521/ORCL;persist security info=false;Connection Timeout=120;";
            //"User Id = sys; Password = Kurwa1!1; Data Source = 192.168.0.206:1521 / ORCL";
            
            string connectionString = "User Id = ADMIN; Password = Kurwakurwa1!1; Data Source = (description = (address = (protocol = tcps)(port = 1522)(host = adb.eu - frankfurt - 1.oraclecloud.com))(connect_data = (service_name = g4b5a9648fb507e_rentaloffice_low.adb.oraclecloud.com))(security = (my_wallet_directory = C:\\Users\\jssla\\OneDrive\\Pulpit\\RentalOffice)(ssl_server_dn_match = yes)))";

            string sql = "select b.ID, b.ID_MOVIES, b.RENTAL_DATE, b.ID_COSTUMER, b.ID_WORKER, c.SURNAME AS CUSTOMER_SURNAME, m.TITTLE, m.SPECIES, w.SURNAME AS WORKER_SURNAME, mp.PRICE" +
                         " from BOOK b, COSTUMER c, MOVIES m, MOVIES_PRICES mp, WORKER w WHERE b.ID_MOVIES = m.ID AND b.ID_COSTUMER = c.ID AND b.WORKER = w.ID";

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();


                    connection.Close();
                }
            }
            catch (Exception ex)
            {
               
            }

            return new DataTable();
        }

        public void SetBooking(Book booking)
        {
            string sql = "insert into BOOK (ID_MOVIES,RENTAL_DATE,ID_COSTUMER,ID_WORKER) " +
                         "values ("+ booking.ID_MOVIES + ", " + booking.RENTAL_DATE + ", " + booking.ID_COSTUMER + ", " + booking.ID_WORKER + ")";
        }

        public DataTable GetAllMovies()
        {
            string sql = "select ID, TITTLE, SPECIES from MOVIES";
            return new DataTable();
        }

        public DataTable GetAllCustomers()
        {
            string sql = "select ID,NAME,SURNAME,SEX,DATE_OF_BIRTH from COSTUMER";
            return new DataTable();
        }

        public DataTable GetAllWorkers()
        {
            string sql = "select ID,NAME,SURNAME,SEX,DATE_OF_BIRTH from WORKER";
            return new DataTable();
        }

        public decimal GetMoviePrice(int id)
        {
            string sql = "select PRICE from MOVIES_PRICES where ID_MOVIES= " + id;
            return 10;
        }
    }
}