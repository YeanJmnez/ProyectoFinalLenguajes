﻿using System;
using System.Web.UI;
using BL.Admistration;
using BL.Kitchen;

namespace GUI.Administration
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void Timer_State_Tick(object sender, EventArgs e)
        {
            //ManagerOrder manager = new ManagerOrder();
            //manager.run();
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
                ManagerUserSystem manager = new ManagerUserSystem();
                String result = manager.userLogIn(new BLSystemUser(username, password, role));

                if (result.Equals("Correct"))
                {
                    Session["username"] = username;
                    if (role.Equals("Admin"))
                    {
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        Response.Redirect("../Kitchen/IndexKitchen.aspx");
                    }

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