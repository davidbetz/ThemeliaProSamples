using System;
//+
//+
namespace Sample.Web
{
    public static class ExceptionSaver
    {
        //- @Save -//
        public static String Save(Exception ex)
        {
            //++ do database save and return record guid
            String problemGuid = Themelia.GuidCreator.GetNewGuid();
            //+ send e-mail about exception
            try
            {
                Themelia.Reporting.ReportFacade.Send(ex);
            }
            catch
            {
                //+ can't email, use alternate method
            }
            //+
            return problemGuid;
        }
        public static void Save(String guid, String description)
        {
            //++ update the database with the new information
        }
    }
}