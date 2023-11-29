using ProjectA6.ServiceReference2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectA6
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            string output = "Login Failed - Please Try Again";
            string outputHashedPass = "No Hash Generated";
            try
            {
                string username = uname.Text;
                string password = pass.Text;

                ServiceReference2.Service1Client service1Client = new ServiceReference2.Service1Client();

                string hashedPassStored = "";
                string hashedPassSalt = "";

                using(StreamReader reader = new StreamReader(HttpRuntime.AppDomainAppPath + "/App_Data/UserInfo.txt"))
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

                            if(input_hashedPass == hashedPassStored)
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

            

            loginVerifier.Text = output;
            HashedPassDisplay.Text = outputHashedPass;
        }
    }
}