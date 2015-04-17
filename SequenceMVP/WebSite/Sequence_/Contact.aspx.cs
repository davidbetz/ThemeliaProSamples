using System;
using System.Linq;
//+
namespace WebSite.Sequence
{
    public partial class Contact : Themelia.Web.Sequence.Page
    {
        //++ SAMPLE NOTE: This method is called when a sequence is loaded for the first time.
        //++ It is used to tell the internal "sequence controller" which view part of the 
        //++ sequence to show first.  In this sample, it's based which endpoint is being
        //++ accessed.
        //- @SelectInitView -//
        public override String SelectInitView()
        {
            String[] urlPartArray = Themelia.Web.Http.UrlPartArray;
            if (urlPartArray.Contains("suggestion") || urlPartArray.Contains("contact"))
            {
                return "MessageInput";
            }
            else if (urlPartArray.Contains("problem"))
            {
                return "ProblemInput";
            }
            //+
            return "MessageInput";
        }
    }
}