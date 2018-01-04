using Framework.Elements;
using OpenQA.Selenium;
using SteamClasses.Pages;


namespace SteamClasses
{
    public class GamePage : BasePage
    {
        private readonly Label lblCurrentName = new Label(By.XPath("//div[contains (@class, 'apphub_AppName')]"));
        private readonly Label lblCurrentDiscount = new Label(By.XPath("//div[@id='game_area_purchase']//div[contains(@class, 'discount_pct')]"));
        private readonly Label lblCurrentPrice = new Label(By.XPath("//div[@id='game_area_purchase']//div[contains(@class, 'discount_final_price')]"));
        private readonly Button btnDownload = new Button(By.XPath("//div[@id='global_action_menu']//a[contains(text(), 'Steam')]"));
        private readonly string currency = " USD";        

        public Game GetGame()
        {
            Game gameFromGamePage = new Game(lblCurrentName.GetText(), lblCurrentDiscount.GetText(), lblCurrentPrice.GetText().Replace(currency, ""));
            return gameFromGamePage;
        }

        public void NavigateToDownloadPage()
        {
            btnDownload.Click();
        }
    }
}
