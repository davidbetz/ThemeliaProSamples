using System;
//+
namespace Sample.Web.Processing
{
    public class VerbalInitProcessor : Themelia.Web.Processing.InitProcessor, 
                                     Themelia.Web.Processing.IHandlesPostVerb
    {
        //- @Execute -//
        public override Themelia.Web.Processing.InitProcessor Execute()
        {
            //++ this will be called for non-POSTs.
            return null;
        }

        //- @Post -//
        public void Post()
        {
            //++ this will be called for POSTs; Execute will not.
            System.Diagnostics.Debug.Write("This was a POST.");
        }
    }
}