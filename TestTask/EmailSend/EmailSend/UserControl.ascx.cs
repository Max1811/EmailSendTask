using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSend
{
    public partial class UserControl : System.Web.UI.UserControl
    {
        private CookiesActions _cookiesActions;
        private readonly MailValidator _validator = new MailValidator();

        protected void Page_Load(object sender, EventArgs e)
        {
            EmailLabelName.Text = Resources.Email;
            ResponceStatus.Text = Resources.Responce;
            Description.Text = Resources.Description;
            Post.Text = Resources.PostButtonText;
            ResponceStatus.Text = Resources.ErrorFormatMessage;

            _cookiesActions = new CookiesActions(Request);
                
            string adress = _cookiesActions.GetCookie("UserEmailAdress");
            string message = _cookiesActions.GetCookie("UserDetailsMessage");

            if (EmailField.Text == string.Empty)
            {
                EmailField.Text = adress;
            }

            if (EmailBody.Text == string.Empty)
            {
                EmailBody.Text = message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies.Add(_cookiesActions.CreateCookie("UserEmailAdress", EmailField.Text));
            Response.Cookies.Add(_cookiesActions.CreateCookie("UserDetailsMessage", EmailBody.Text));

            if (_validator.Validate(EmailField.Text))
            {
                Response.Redirect("/SuccessfulSendPage.aspx");
            }
            else
            {
                ResponceStatus.Visible = true;
            }
            
        }

        protected void OnEmailChanged(object sender, EventArgs e)
        {
            Response.Cookies.Add(_cookiesActions.CreateCookie("UserEmailAdress", EmailField.Text));
        }

        protected void OnDescriptionChanged(object sender, EventArgs e)
        {
            Response.Cookies.Add(_cookiesActions.CreateCookie("UserDetailsMessage", EmailBody.Text));
        }
    }
}