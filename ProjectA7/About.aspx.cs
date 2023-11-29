using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProjectA7
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginClick(object sender, EventArgs e)
        {
            string output = "Login Failed - Please Try Again";
            string outputHashedPass = "No Hash Generated";
            try
            {
                string username = uname.Text;
                string password = pass.Text;

                ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();

                string hashedPassStored = "";
                string hashedPassSalt = "";

                using (StreamReader reader = new StreamReader(HttpRuntime.AppDomainAppPath + "/App_Data/UserInfo.txt"))
                {
                    //csv labels
                    string line = reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        string[] lines = line.Split(',');
                        if (lines[0].ToLower() == username.ToLower())
                        {
                            //found storage hashed password
                            hashedPassSalt = lines[2];
                            hashedPassStored = lines[1];

                            //hash current password with salt - see if they match
                            string input_hashedPass = service1Client.GetHash(password, hashedPassSalt);

                            if (input_hashedPass == hashedPassStored)
                            {
                                output = "SUCCESS - You Are Now Logged In";
                            }

                            //output hashedpass stuff too

                        }
                    }
                }

                outputHashedPass = service1Client.GetHash(password, "");

            }
            catch (Exception ex)
            {
                output = ex.Message;
            }

            if (output.Contains("SUCCESS"))
            {
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "3;url=http://webstrar86.fulton.asu.edu/page1/Members";
                this.Page.Controls.Add(meta);

                confirmationText.Text = output + " --- you will be redirected to your Members page in 3 seconds...";
            }
            else
            {
                confirmationText.Text = output;
            }
            //delay for a few seconds and redirect to members page
            

            
        }
    }
}