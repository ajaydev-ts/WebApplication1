using System.Data;
using System.Data.SqlClient;
namespace WebApplication1

{
    public class Connection
    {
        DataSet ds = new DataSet();
        SqlConnection connection = new SqlConnection("Data Source=AJAYDEVTS-991\\SQLEXPRESS;Initial Catalog=DB1;Integrated Security=True");
        SqlCommand command = new SqlCommand();


        public Connection()
        {
            connection.Open();
            command.Connection = connection;

        }
        public SqlCommand getCommand
        {
            get { return command; }
        }

    }
}