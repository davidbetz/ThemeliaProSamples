using System;
//+
namespace Sample.Console
{
    class Program
    {
        static void Main(String[] args)
        {
            Sample.Logic.MyCustomProcess processor = Themelia.Activation.InjectionData.GetObject<Sample.Logic.MyCustomProcess>("Process");
            if (processor != null)
            {
                System.Console.WriteLine(processor.Run());
            }
            else
            {
                System.Console.WriteLine("No processor was configured.");
            }
        }
    }
}
