using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;

namespace GUI.Administration
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallCheckTextBoxes", "checkTextBoxes();", true);

            String username = txtLoginUserName.Value.Trim();
            String password = txtLoginUserPassword.Value.Trim();
            String role = rblRoleSelector.SelectedItem.Value;


            if (string.IsNullOrEmpty(username))
            {
                loginEmptyUserName.Visible = true;
            }
            if (string.IsNullOrEmpty(password))
            {
                loginEmptyPassword.Visible = true;
            }

            if (!string.IsNullOrEmpty(username) && 
                !string.IsNullOrEmpty(password) &&
                !string.IsNullOrEmpty(role))
            {
                BLSystemUser blSystemUser = new BLSystemUser(username, password, role);
                String result = blSystemUser.userLogIn();

                if (result.Equals("Correct"))
                {
                    Session["username"] = username;
                    Response.Redirect("Index.aspx");
                }
                else if (result.Equals("IncorrectUserName"))
                {
                    String css = wrongUserName.Attributes["class"];
                    String newCss = css.Replace("hidden", "");

                    wrongUserName.Attributes.Add("class", newCss);
                }
                else if (result.Equals("IncorrectPassword"))
                {
                    String css = wrongPassword.Attributes["class"];
                    String newCss = css.Replace("hidden", "");

                    wrongPassword.Attributes.Add("class", newCss);
                }
            }

        }
       
    }
}