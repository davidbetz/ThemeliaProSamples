using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.UI.WebControls;
//+
namespace WebSite.Security
{
    public partial class Login : System.Web.UI.Page
    {
        //- #OnInit -//
        protected override void OnInit(EventArgs e)
        {
            //+ validation
            ValidationPane.Controls.Add(new RequiredFieldValidator
            {
                ControlToValidate = "txtUserName",
                ErrorMessage = "UserName is required",
                EnableClientScript = false
            });
            ValidationPane.Controls.Add(new System.Web.UI.HtmlControls.HtmlGenericControl("br"));
            ValidationPane.Controls.Add(new RequiredFieldValidator
            {
                ControlToValidate = "txtPassword",
                ErrorMessage = "Password is required",
                EnableClientScript = false
            });
            //+ events
            btnSubmit.Click += new EventHandler(OnSubmit);
            //+
            base.OnInit(e);
        }

        //- $OnSubmit -//
        private void OnSubmit(Object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                Themelia.Map authInfo = new Themelia.Map("username=" + txtUserName.Text, "password=" + txtPassword.Text);
                Boolean isValid = Themelia.Parser.ParseBoolean(Themelia.Net.HttpAbstractor.PostHttpRequest(new Uri(Themelia.Web.Http.Root + "/authenticate/"), authInfo));
                //+
                if (isValid)
                {
                    Themelia.Web.HttpData.SetSessionItem<Boolean>(Sample.Web.Setting.IsAuthenticated, true);
                    Themelia.Web.Http.Redirect("/" + String.Join("/", Themelia.ArrayModifier.Strip<String>(Themelia.Web.Http.UrlPartArray)));
                }
                else
                {
                    ValidationPane.Controls.Add(new Label
                    {
                        CssClass = "error",
                        Text = "Invalid username or password"
                    });
                }
            }
        }
    }
}