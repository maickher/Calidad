using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using DXWebAsoc.Model.Entities;
using DXWebAsoc.BLL;

namespace DXWebAsoc {
    public partial class Login : System.Web.UI.Page {
        #region MyRegion
        private BLLUsuario BLL = new BLLUsuario();
        #endregion
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e) {

            if (BLL.ValidateUser(this.tbUserName.Text, this.tbPassword.Text))
            {
                if (string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
                {
                    // Initialize FormsAuthentication, for what it's worth
                    FormsAuthentication.Initialize();

                    // Create a new ticket used for authentication
                    // Ticket Version, Username associated with ticket, Datetime issued, Datetime to expire, true= for persistent user cookie, user-data, in this case the role, path cookie valid for
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, this.tbUserName.Text, DateTime.Now, DateTime.Now.AddMinutes(5), true, "Registrador", FormsAuthentication.FormsCookiePath);
                    // Encrypt the cookie using the machine key for secure transport
                    string hash = FormsAuthentication.Encrypt(ticket);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);
                    // Set the cookie's expiration time to the tickets expiration time
                    if (ticket.IsPersistent) cookie.Expires = ticket.Expiration;
                    // Add the cookie to the list for outgoing response
                    Response.Cookies.Add(cookie);


                    //FormsAuthentication.SetAuthCookie(this.tbUserName.Text, false);                  
                    Response.Redirect("~/");
                }
                else
                {
                    FormsAuthentication.RedirectFromLoginPage(this.tbUserName.Text, false);
                }
            }
            else
            {
                this.tbUserName.ErrorText = "Usuario Invalido";
                this.tbUserName.IsValid = false;
            }

            /*if (Membership.ValidateUser(tbUserName.Text, tbPassword.Text)) {
                if(string.IsNullOrEmpty(Request.QueryString["ReturnUrl"])) {
                    FormsAuthentication.SetAuthCookie(tbUserName.Text, false);
                    Response.Redirect("~/");
                }
                else
                    FormsAuthentication.RedirectFromLoginPage(tbUserName.Text, false);
            }
            else {
                tbUserName.ErrorText = "Invalid user";
                tbUserName.IsValid = false;
            }*/
        }
    }
}