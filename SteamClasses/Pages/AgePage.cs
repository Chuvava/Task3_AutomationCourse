using Framework;
using Framework.Elements;
using OpenQA.Selenium;
using SteamClasses.Pages;


namespace SteamClasses
{
    public class AgePage : BasePage
    {
        private readonly DropDown cmbYear = new DropDown(By.Name("ageYear"));
        private readonly Button btnEnter = new Button(By.XPath("//div[@id='agegate_box']//span[contains(text(), '" + Resources.Resource.SubmitAge + "')]"));

        public AgePage()
        {
            Browser.SetImplicitWaitForPage(Configuration.GetImplicitForPage());
        }

        public void FillAgeData(string year)
        {
            if (cmbYear.IfExist())
            {
                cmbYear.SelectByValue(year);
                btnEnter.Click();
            }
        }
    }
}
