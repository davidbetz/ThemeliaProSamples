using System;
//+
namespace Sample.Web.Routing
{
    public class ProcessorFactory : Themelia.Web.Routing.ProcessorFactoryBase
    {
        public override Themelia.Web.Routing.IProcessor CreateProcessor(String text)
        {
            switch (text)
            {
                case "injection":
                    return new InjectionProcessor();
                case "savingerror":
                    return new SavingErrorProcessor();
            }
            //+
            return null;
        }
    }
}