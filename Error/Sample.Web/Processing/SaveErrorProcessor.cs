using System;
using System.Linq;
//+
using Themelia.Web;
//+
namespace Sample.Web.Processing
{
    public class SaveErrorProcessor : Themelia.Web.Processing.ErrorProcessor
    {
        //++ SAMPLE NOTE: This is called when an unhandled exception is thrown in a Themelia web site.
        //++ Exceptions may also be filtered by types of exceptions.  In this example, Execute is only
        //++ called when an ArgumentOutOfRangeException is thrown.
        public override void Execute()
        {
            if (Error != null && !Http.UrlPartArray.Contains("problem"))
            {
                String problemGuid = Web.ExceptionSaver.Save(Error);
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