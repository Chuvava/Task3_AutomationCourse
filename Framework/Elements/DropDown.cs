using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Framework.Elements
{
    public class DropDown : BaseElement
    {
        public DropDown(By locator)
            :base(locator)
        {            
        }

        public void SelectByValue(string value)
        {
            WaitElement();
            var select = driver.FindElement(locator);
            var selectItem = new SelectElement(select);
            selectItem.SelectByValue(value);
        }
    }
}
