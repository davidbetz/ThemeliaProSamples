using System;
//+
namespace Sample.Web.Processing
{
    public class ProcessorFactory : Themelia.Web.Processing.ProcessorFactory
    {
        //- @CreateProcessor -//
        public override Themelia.Web.Processing.IProcessor CreateProcessor(String text)
        {
            switch (text)
            {
                case "verbalinit":
                    return new VerbalInitProcessor();
            }
            //+
            return null;
        }
    }
}