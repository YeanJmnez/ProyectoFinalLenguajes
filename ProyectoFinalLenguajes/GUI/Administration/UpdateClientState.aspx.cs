using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;

namespace GUI.Administration
{
    public partial class UpdateClientState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                chargeList();
            }
                
        }

        public void chargeList()
        {
            BLClient blcAvailable = new BLClient();
            List<String> list = blcAvailable.ListUserClient();
            List_User.Items.Clear();
            foreach (string item in list)
            {
                List_User.Items.Add(item);
            }
        }

        protected void BtEnable_Click(object sender, EventArgs e)
        {
            BLClient blcAvailable = new BLClient();
            string[] words = List_User.SelectedItem.ToString().Split();

            blcAvailable.enableStateDish(words[1], true);
            chargeList();
        }

        protected void BtDisable_Click(object sender, EventArgs e)
        {
            BLClient blcAvailable = new BLClient();
            string[] words = List_User.SelectedItem.ToString().Split();

            blcAvailable.enableStateDish(words[1], false);
            chargeList();
        }
    }
}