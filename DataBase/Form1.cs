using System.Data;
using Microsoft.Data.SqlClient;

namespace DataBase
{

    public partial class Form1 : Form
    {
    public Form1()
        {
            InitializeComponent();
        }
        //Create a string connection variable
        string stringConnection = @"Server=localhost\SQLEXPRESS;Database=Escuela;Trusted_Connection=True;TrustServerCertificate=true;";

        
        private void btnConect_Click(object sender, EventArgs e)
        {
            MostrarDatosCarrera();
            MostrarDatosAlumnos();
        }
        private void MostrarDatosCarrera()
        {
            //Create a connection object
            SqlConnection connection = new SqlConnection(stringConnection);
            //Create a command object
            SqlCommand command = new SqlCommand("SELECT * FROM Carrera", connection);
            //Create a data adapter object
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //Create a data table object
            DataTable dataTable = new DataTable();
            //Fill the data table with the data from the database
            dataAdapter.Fill(dataTable);
            //Set the data source of the data grid view to the data table
            dtgvCarrera.DataSource = dataTable;
        }
        private void MostrarDatosAlumnos()
        {
            //Create a connection object
            SqlConnection connection = new SqlConnection(stringConnection);
            //Create a command object
            SqlCommand command = new SqlCommand("SELECT * FROM Alumnos", connection);
            //Create a data adapter object
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //Create a data table object
            DataTable dataTable = new DataTable();
            //Fill the data table with the data from the database
            dataAdapter.Fill(dataTable);
            //Set the data source of the data grid view to the data table
            dtgvAlumnos.DataSource = dataTable;
        }
    }
}
