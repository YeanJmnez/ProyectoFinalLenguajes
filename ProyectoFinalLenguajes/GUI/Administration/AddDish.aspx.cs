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
            if(TxtState.Text.ToLower().Trim() == "habilitado")
            {
                state = true;
            } else
            {
                state = false;
            }
            BLDish newDish = new BLDish(TxtName.Text.Trim(), TxtDescription.Text.Trim(), decimal.Parse(TxtPrice.Text.ToLower().Trim()), state, FileUploadDish.FileName);
            FileUploadDish.SaveAs("C:\\Users\\Antho\\Source\\Repos\\ProyectoFinalLenguajes\\ProyectoFinalLenguajes\\GUI\\DishesPicture\\" + FileUploadDish.FileName);
            newDish.addDish(newDish);
            Response.Redirect("http://localhost:12021/Administration/AddDish.aspx");
        }
    }
}