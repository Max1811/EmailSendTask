using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSend
{
    public partial class PohPage : System.Web.UI.Page
    {
        private CookiesActions _cookiesActions;
        protected void Page_Load(object sender, EventArgs e)
        {
            _cookiesActions = new CookiesActions(Request);

            string email = _cookiesActions.GetCookie("UserEmailAdress");
            SuccessfulResponce.Text = $"{Resources.SuccessSendLabel} on {email}";
            GoBackButton.Text = Resources.BackButton;
        }

        protected void BackButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("/");
        }
    }
}