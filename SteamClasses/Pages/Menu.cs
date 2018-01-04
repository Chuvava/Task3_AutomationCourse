using System;
using Framework.Elements;
using OpenQA.Selenium;


namespace SteamClasses.Pages
{
    public class Menu : BasePage
    {
        private string menuLocator = "//a[contains(text(), '{0}')]";
        private string locatorCategory = "//a[contains(@class, 'popup_menu_item') and contains(text(), '{0}')]";

        public void NavigateMenu(string menuItem, string categoryItem)
        {
            Label lblMenu = new Label(By.XPath(String.Format(menuLocator, menuItem)));
            Label lblCategory = new Label(By.XPath(String.Format(locatorCategory, categoryItem)));
            lblMenu.MoveToElement();
            lblCategory.Click();
        }
    }
}
