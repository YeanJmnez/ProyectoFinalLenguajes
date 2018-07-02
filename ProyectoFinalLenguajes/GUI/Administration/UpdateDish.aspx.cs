using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using BL.Admistration;

namespace GUI.Administration
{
    public partial class UpdateDish : System.Web.UI.Page
    {
        BLDish blUpdate = new BLDish();
        protected void Page_Load(object sender, EventArgs e)
        {
            ChargeAllDish();
        }

        public void ChargeAllDish ()
        {
            ArrayList CompleteDishesList = new ArrayList();
            BLDish Bl = new BLDish();
            CompleteDishesList = Bl.DishesList();
            GridCompleteDishesList.DataSource = CompleteDishesList;
            GridCompleteDishesList.DataBind();
        }

        protected void BtChargeDU_Click(object sender, EventArgs e)
        {
            BLDish Bl = new BLDish();
            blUpdate = Bl.ChargeDish(int.Parse(TxtCodeUpdate.Text.Trim()));
            TxtUpdateName.Text = blUpdate.Name;
            TxtUpdateDescription.Text = blUpdate.Description;
            TxtUpdatePrice.Text = blUpdate.Price.ToString();
            if (blUpdate.State == true)
            {
                TxtUpdateState.Text = "Habilitado";
            } else
            {
                TxtUpdateState.Text = "Deshabilitado";
            }  
        }

        protected void btUpdateDish_Click(object sender, EventArgs e)
        {
            BLDish Bl = new BLDish();
        }
    }
}