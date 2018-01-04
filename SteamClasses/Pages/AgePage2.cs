using Framework;
using Framework.Elements;
using OpenQA.Selenium;


namespace SteamClasses.Pages
{
    public class AgePage2 : BasePage
    {
        private readonly Button btnView = new Button(By.XPath("//a/span[contains(., '" + Resources.Resource.SubmitAge2 + "')]"));

        public AgePage2()
        {
            Browser.SetImplicitWaitForPage(Configuration.GetImplicitForPage());        
        }
        
        public void SubmitView()
        {
            if (btnView.IfExist())
            {
                btnView.Click();
            }
        }
    }
}
