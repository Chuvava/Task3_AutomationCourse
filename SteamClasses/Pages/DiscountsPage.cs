using Framework.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SteamClasses.Pages;


namespace SteamClasses
{
    public class DiscountsPage : BasePage
    {                
        private string discountsXpath = "//div[@id = 'DiscountsRows']/a//div[contains (@class, 'discount_pct')]";
        private string pricesXpath = "//div[@id = 'DiscountsRows']/a//div[contains (@class, 'discount_final_price')]";
        private string namesXpath = "//div[@id = 'DiscountsRows']/a//div[contains (@class, 'tab_item_name')]";
        private readonly Label lblElementForCheck = new Label(By.XPath("//div[@id='tab_select_Discounts']"));
        private readonly string expectedClassOfElement = "tab active";

        public DiscountsPage()
        {
            Assert.AreEqual(lblElementForCheck.GetAttributeClass(), expectedClassOfElement, "Tab Discounts opened");
        }

        public void NavigateToMaxDiscount()
        {
            Tab.GetGameWithMaxDiscount(namesXpath, discountsXpath, pricesXpath);
        }

        public Game GetGameFromDiscounts()
        {
            return Tab.GetGame();
        }
    }
}
