using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReferenceUser;

public partial class _Default : System.Web.UI.Page
{

    ServiceReferenceUser.Service1Client client = new ServiceReferenceUser.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        UserDetails UserInfo = new UserDetails();
        UserInfo.UserName = txtUsername.Text;
        string result = client.InsertUserDetails(UserInfo);
        lblResult.Text = result;
    }
}