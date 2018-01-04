using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Framework.Elements
{
    public class Label : BaseElement
    {
        public Label(By locator)
            : base(locator)
        {
        }

        public string GetAttributeText(string text)
        {
            WaitElement();
            return driver.FindElement(locator).GetAttribute(text);
        }

        public string GetAttributeClass()
        {
            WaitElement();
            return driver.FindElement(locator).GetAttribute("class");
        }

        public List<Label> FindElements(string locatorXpath)
        {
            int count = driver.FindElements(By.XPath(locatorXpath)).Count;
            List<Label> elements = new List<Label>();
            for (int i = 1; i <= count; i++)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Configuration.GetTimeWait()));
                By locatorEl = By.XPath(locatorXpath.Replace("/a", "/a[" + i + "]"));
                WaitElement();
                IWebElement el = wait.Until(ExpectedConditions.ElementExists(locatorEl));
                Label lblEl = new Label(By.XPath(locatorXpath.Replace("/a", "/a[" + i + "]")));
                elements.Add(lblEl);
            }
            return elements;
        }
    }
}
