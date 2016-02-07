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
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e) {

            CUsuario Usuario = new CUsuario();
            Usuario.Id = 1;
            Usuario.Nombre = this.tbUserName.Text;
            Usuario.Usuario = this.tbUserName.Text;
            Usuario.Contrasena = this.tbPassword.Text;
            Usuario.Role = Role.Administrador;
            Usuario.Estado = UserState.Activo;
            Usuario.FechaCreacion = DateTime.Now;
            Usuario.FechaModificacion = DateTime.Now;
            Usuario.UsuarioCreacion = Convert.ToString("1");
            Usuario.UsuarioModificacion = Convert.ToString("1");

            BLLUsuario BLL = new BLLUsuario();
            bool existe = BLL.ReadUser(Usuario);

            if (existe)
            {
                FormsAuthentication.RedirectFromLoginPage(tbUserName.Text, false);
            }
            else
            {
                tbUserName.ErrorText = "no pego";
                tbUserName.IsValid = false;
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