using Framework;


namespace SteamClasses.Pages
{
    public class BasePage
    {

        public BasePage()
        {
            Browser.GetInstance().GetBrowser();
        }
    }
}
