using System;
using System.Linq;
//+
using Themelia.Web;
//+
namespace Sample.Web.Routing
{
    public class SavingErrorProcessor : Themelia.Web.Routing.ErrorProcessorBase
    {
        public override void OnErrorProcessorExecute(System.Web.HttpContext context, params object[] parameterArray)
        {
            Exception ex = context.Error;
            if (ex != null && !Http.UrlPartArray.Contains("problem"))
            {
                String problemGuid = Web.ExceptionSaver.Save(ex);
                Http.Redirect("/problem/" + problemGuid);
            }
            else
            {
                try
                {
                    Themelia.Reporting.ReportFacade.Send("Unknown exception occurred");
                }
                catch
                {
                    //+ just in case the sample web.config isn't configured for mail
                }
            }
        }
    }
}