using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;

namespace GUI.Administration
{
    public partial class AddDish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtAddDish_Click(object sender, EventArgs e)
        {
            bool state = true;
            if (TxtState.Text.ToLower().Trim() == "habilitado")
            {
                state = true;
            }
            else
            {
                state = false;
            }
            BLDish newDish = new BLDish(TxtName.Text.Trim(), TxtDescription.Text.Trim(), decimal.Parse(TxtPrice.Text.ToLower().Trim()), state, FileUploadImage.FileName);
            FileUploadImage.SaveAs(Server.MapPath("../DishesPicture/").ToString() + FileUploadImage.FileName);
            newDish.addDish(newDish);

            addDishForm.Visible = false;
            String css = successRegistration.Attributes["class"];
            String newCss = css.Replace("hidden", "");
            successRegistration.Attributes.Add("class", newCss);
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddDish.aspx");

        }
    }
}