using System;
//+
namespace Sample.Web.Processing
{
    public class ProcessorFactory : Themelia.Web.Processing.ProcessorFactory
    {
        //++ SAMPLE NOTE: It's very important to remember to always create a processor
        //++ factory for your Themelia web sites.  This increases the performance of 
        //++ your processors and makes it more difficult to make typos in configuration.
        public override Themelia.Web.Processing.IProcessor CreateProcessor(String text)
        {
            switch (text)
            {
                case "saveerror":
                    return new SaveErrorProcessor();
            }
            //+
            return null;
        }
    }
}