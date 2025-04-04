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
            //Create a connection object
            SqlConnection connection = new SqlConnection(stringConnection);
        }
    }
}
