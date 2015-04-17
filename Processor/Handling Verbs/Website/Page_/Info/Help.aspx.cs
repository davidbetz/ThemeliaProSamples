using System;
//+
namespace WebSite.Info
{
    public partial class Help : Themelia.Web.SimplePage
    {
        private static Object _lock = new Object();
        private static Themelia.Map _sectionTitleMap = null;

        //+
        //- #OnInit -//
        protected override void OnInit(System.EventArgs e)
        {
            lock (_lock)
            {
                if (_sectionTitleMap == null)
                {
                    _sectionTitleMap = new Themelia.Map();
                    _sectionTitleMap.Add("producta", "Product A");
                    _sectionTitleMap.Add("productb", "Product B");
                    _sectionTitleMap.Add("faq", "Frequently Asked Questions");
                    _sectionTitleMap.Add("investor", "Investors");
                }
            }
            Load += new System.EventHandler(Page_Load);
            //+
            base.OnInit(e);
        }

        //- $Page_Load -//
        private void Page_Load(Object sender, System.EventArgs e)
        {
            lock (_lock)
            {
                //++ SAMPLE NOTE: the Http class is one of two (the other being HttpData) classes that you will probably use
                //++ more than any other class in Themelia (or even in .NET).  In this example, they are being used to look at
                //++ the segments of a URL.  If the second to the last ("penultima") part of a URL is "help", then use the last
                //++ ("ultima") part of the URL as the key to obtain the page title.
                if (Themelia.Web.Http.GetUrlPart(Themelia.Position.Penultima) == "help")
                {
                    String text = _sectionTitleMap.PeekSafely(Themelia.Web.Http.GetUrlPart(Themelia.Position.Ultima).ToLower());
                    litSection.Text = text;
                    Title = text + " Help";
                }
            }
        }
    }
}