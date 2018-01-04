using Framework;
using OpenQA.Selenium;
using Framework.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamClasses.Pages;


namespace SteamClasses
{
    public class MainPage : BasePage
    {
        private readonly string menuItem = Resources.Resource.GetMenu;
        private readonly string categoryItem = Resources.Resource.GetCategory;
        private readonly Button btnLang = new Button(By.XPath("//span[@id='language_pulldown']"));
        private readonly Button btnEngOrRus = new Button(By.XPath("//div[@id='language_dropdown']/div/a[contains(text(),'" + Resources.Resource.GetLanguage + "')]"));        
        private readonly Label lblHtml = new Label(By.XPath("//html"));
        private readonly Button btnLogin = new Button(By.XPath("//div[@id='content_login']//div[contains(@class, 'signin_buttons_ctn')]"));
        private readonly Menu menu = new Menu();

        public MainPage()
        {
            Assert.IsTrue(btnLogin.IfExist(), "Main page is open");
        }

        public void ChooseCategoryFromMenu()
        {
            ChooseLanguage();
            menu.NavigateMenu(menuItem, categoryItem);
        }

        public void ChooseLanguage()
        {
            if (Configuration.GetLanguage() != lblHtml.GetAttributeText("lang"))
            {
                    btnLang.Click();
                    btnEngOrRus.Click();
            }
        }
        
    }
}
