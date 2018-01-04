using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework
{
    class BrowserFactory
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            switch (Configuration.GetBrowser())
            {
                case "Chrome":
                    ChromeOptions settingsChrome = new ChromeOptions();
                    settingsChrome.AddUserProfilePreference("safebrowsing.enabled", true);
                    settingsChrome.AddUserProfilePreference("download.default_directory", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    driver = new ChromeDriver(settingsChrome);
                    return driver;
                case "Firefox":
                    FirefoxOptions settingsFirefox = new FirefoxOptions();
                    settingsFirefox.SetPreference("browser.download.folderList", 2);
                    settingsFirefox.SetPreference("browser.download.dir", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    settingsFirefox.SetPreference("browser.helperApps.alwaysAsk.force", false);
                    settingsFirefox.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/octet-stream");
                    driver = new FirefoxDriver(settingsFirefox);
                    return driver;
                default:
                    throw new DriveNotFoundException();
            }
        }
    }
}

