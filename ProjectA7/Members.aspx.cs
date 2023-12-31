﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectA7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void friendClick(object sender, EventArgs e)
        {
            ServiceReference2.Service1Client service1Client = new ServiceReference2.Service1Client();

            friendLabel.Text = service1Client.getFriends();
        }

        protected void encryptionClick(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            string encryption = client.GetHash(encryptionText.Text, "");

            currentLabel.Text = "Original Text: " + encryptionText.Text;
            encryptionLabel.Text = "Encrypted Text: " + encryption;
        }
    }
}