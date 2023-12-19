using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cdbook
{
    public partial class CDs : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var path = Server.MapPath(@"~/App_Data/HW3v1.accdb");
            if (!IsPostBack)
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=False;";
                string query = "SELECT Title, CDID FROM CDs"; // Adjust SQL query

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    GridViewCD.DataSource = dataTable;
                    GridViewCD.DataBind();
                }
            }
        }
    }
}