using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProjectA7
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void memberButtonClick(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] != null)
            {
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "0;url=http://webstrar86.fulton.asu.edu/page1/Members";
                this.Page.Controls.Add(meta);
            }
            else
            {
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "0;url=http://webstrar86.fulton.asu.edu/page1/About";
                this.Page.Controls.Add(meta);
            }
        }

        protected void staffButtonClick(object sender, EventArgs e)
        {
            if (Request.Cookies["usernameStaff"] != null)
            {
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "0;url=http://webstrar86.fulton.asu.edu/page1/Staff";
                this.Page.Controls.Add(meta);
            }
            else
            {
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "0;url=http://webstrar86.fulton.asu.edu/page1/Contact";
                this.Page.Controls.Add(meta);
            }
        }
    }
}