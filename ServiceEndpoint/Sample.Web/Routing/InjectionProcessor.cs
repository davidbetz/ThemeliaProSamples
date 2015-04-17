//+
using Themelia.Web.Routing.Data;
//+
namespace Sample.Web.Routing
{
    public class InjectionProcessor : Themelia.Web.Routing.InjectionProcessorBase
    {
        //- @OnAddHttpHandlers -//
        public override void OnAddHttpHandlers(HttpHandlerDataList injectedHandlerDataList, params object[] parameterArray)
        {
            injectedHandlerDataList.Add(new HttpHandlerData
            {
                Name = "Authentication",
                MatchText = "/authenticate/",
                MatchType = "pathStartsWith",
                Priority = 5
            });
        }
    }
}