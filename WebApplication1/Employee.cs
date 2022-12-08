using Microsoft.AspNetCore.Mvc.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class Employee
    {
        Connection connection = new Connection();

        public DataSet getdata()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
        DataSet ds = new DataSet();

        connection.getCommand.CommandText = "select * from Employee";
            adp.SelectCommand = connection.getCommand;
            adp.Fill(ds);
            return ds;
        }
        public DataSet getdata1()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();

            connection.getCommand.CommandText = "select * from Department";
            adp.SelectCommand = connection.getCommand;
            adp.Fill(ds);
            return ds;
        }
        public DataSet getdata2()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();

            connection.getCommand.CommandText = "select * from Designation";
            adp.SelectCommand = connection.getCommand;
            adp.Fill(ds);
            return ds;
        }
        public string insertEmployee(Regmodel rm)
        {
            connection.getCommand.CommandText = "insert into Employee(id,Name,depid,desid,Salary,Phone) values ('" + rm.Id + "','" + rm.Name + "','" + rm.Depid + "','" + rm.Desid + "','" + rm.Salary + "','" + rm.Phone + "')";
            connection.getCommand.ExecuteNonQuery();
            return "Success";
        }
        public string insertDepartment(Regmodeldept rm)
        {
            connection.getCommand.CommandText = "insert into Department(Id,Name) values('" + rm.Id + "','" + rm.Name + "')";
            connection.getCommand.ExecuteNonQuery();
            return "success";
        }
        public string insertDesignation(Regmodeldes rm)
        {
            connection.getCommand.CommandText = "insert into designation(id,designation) values('" + rm.Id + "','" + rm.Designation + "')";
            connection.getCommand.ExecuteNonQuery();
            return "success";
        }
        public string delete(int Id)
        {
            connection.getCommand.CommandText = "delete from Employee where id='" + Id + "'";
            connection.getCommand.ExecuteNonQuery();
            return "success";
        }
        public string update(Regmodeldept rm)
        {
            connection.getCommand.CommandText = "update Department set Name='"+ rm.Name + "'where id= '"+  rm.Id  +"'" ;
            connection.getCommand.ExecuteNonQuery();
            return "Success";
        }
    }
}
