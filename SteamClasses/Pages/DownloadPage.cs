using System.IO;
using System.Threading.Tasks;
using Framework;
using Framework.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SteamClasses.Pages;


namespace SteamClasses
{
    public class DownloadPage : BasePage
    {
        private readonly Button btnDownload = new Button(By.XPath("//a[@id='about_install_steam_link']"));
        private readonly int countLoop = Configuration.GetCountLoop();
        private readonly int delay = Configuration.GetTaskDelay();
        private readonly string scriptPath = "..\\..\\DownloadFileAutoIT.exe";

        public DownloadPage()
        {
            Assert.IsTrue(btnDownload.IfExist());
        }

        public void StartDownloadSteam()
        {
            btnDownload.ClickAndDownloadByScript(scriptPath);
        }

        public bool CheckFinishDownload(string downloadPath)
        {
            for (int i = 0; i < countLoop; i++)
            {
                if (File.Exists(downloadPath))
                    return true;
                Task.Delay(delay).Wait();
            }

            Browser.CloseBrowser(); 
            return false;
        }
    }
}
