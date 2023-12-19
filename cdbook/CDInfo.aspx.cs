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
    public partial class CDInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var path = Server.MapPath(@"~/App_Data/HW3v1.accdb");
            if (!IsPostBack)
            {
                // Check if the "id" query string parameter is present
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    string bookId = Request.QueryString["id"];

                     string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=False;";
                    string query = "SELECT Title, Artist, Year, Duration FROM CDs WHERE CDID = @CDID";

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@CDID", bookId);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        connection.Open();
                        adapter.Fill(dataTable);
                        connection.Close();

                        if (dataTable.Rows.Count > 0)
                        {
                            DetailsViewBook.DataSource = dataTable;
                            DetailsViewBook.DataBind();

                            // Set the title of the page to the book's title
                            string bookTitle = dataTable.Rows[0]["Title"].ToString();
                            this.Title = bookTitle;

                            // Store the title in the session for the last visited pages list
                            AddToLastVisitedPages(bookTitle);
                        }
                        else
                        {
                            // Handle case where book with given ID is not found
                        }
                    }
                }
                else
                {
                    // Handle case where "id" query string parameter is missing
                }
            }
        }

        private void AddToLastVisitedPages(string page)
        {
            // Retrieve last visited pages list from session or initialize it
            if (Session["LastVisitedPages"] != null)
            {
                var lastVisitedPages = (System.Collections.Generic.List<string>)Session["LastVisitedPages"];
                if (!lastVisitedPages.Contains(page))
                {
                    lastVisitedPages.Add(page);
                    Session["LastVisitedPages"] = lastVisitedPages;
                }
            }
            else
            {
                var lastVisitedPages = new System.Collections.Generic.List<string> { page };
                Session["LastVisitedPages"] = lastVisitedPages;
            }
        }
    }
}