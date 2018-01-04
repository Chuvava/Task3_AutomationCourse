using System.Diagnostics;
using OpenQA.Selenium;

namespace Framework.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator)
            :base(locator)
        {            
        }

        public void ClickAndDownloadByScript(string scriptPath)
        {
            Process.Start(scriptPath);
        }
    }
}
