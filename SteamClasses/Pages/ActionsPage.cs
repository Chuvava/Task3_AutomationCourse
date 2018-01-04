using Framework.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SteamClasses.Pages;


namespace SteamClasses
{
    public class ActionsPage : BasePage
    {
        private readonly Label lblDiscounts = new Label(By.XPath("//div[@id = 'tab_select_Discounts']/div[contains(text(), '" + Resources.Resource.GetTab + "')]"));
        private readonly Label lblH2 = new Label(By.XPath("//h2[contains(text(), '" + Resources.Resource.GetCategory + "')]"));

        public ActionsPage()
        {
            Assert.IsTrue(lblH2.IfExist());
        }

        public void SelectDiscountsTab()
        {
            lblDiscounts.Click();
        }
    }
}
