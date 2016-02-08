using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using System.Reflection;

namespace DXWebAsoc {
    public partial class RootMaster : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {

            string comp = "";
            string copyright = "";
            AssemblyCopyrightAttribute[] copy = (AssemblyCopyrightAttribute[])Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), true);
            AssemblyCompanyAttribute[] attributes = (AssemblyCompanyAttribute[])Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), true);

            if (attributes.Length > 0)
                comp = attributes[0].Company;
            if (copy.Length > 0)
                copyright = copy[0].Copyright;
            
            ASPxLabel2.Text = DateTime.Now.Year + Server.HtmlDecode(" &copy; Copyright by "+ comp);
        }
    }
}