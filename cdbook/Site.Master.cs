using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cdbook
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the current page URL
            string currentPage = Request.Url.AbsolutePath;

            // Retrieve last visited pages list from session or initialize it
            List<string> lastVisitedPages;
            if (Session["LastVisitedPages"] != null)
            {
                lastVisitedPages = (List<string>)Session["LastVisitedPages"];
            }
            else
            {
                lastVisitedPages = new List<string>();
            }

            // Add the current page to the list and maintain only the last 5 pages
            lastVisitedPages.Remove(currentPage);
            lastVisitedPages.Add(currentPage);
            if (lastVisitedPages.Count > 5)
            {
                lastVisitedPages.RemoveAt(0);
            }

            // Update the session variable
            Session["LastVisitedPages"] = lastVisitedPages;
        }
    }
}