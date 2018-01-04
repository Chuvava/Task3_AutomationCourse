using System.Globalization;
using System.IO;
using System.Threading;
using Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamClasses;
using SteamClasses.Pages;


namespace SteamTests
{
    [TestClass]
    public class SteamTest
    {
        private string filePath = "..\\..\\SteamSetup.exe";

        [TestInitialize]
        public void TestInit()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Configuration.GetCulture());
            if (File.Exists(filePath))
                File.Delete(filePath);
            Browser.GetInstance().GetBrowser();
        }

        [TestMethod]
        public void SteamAutoTest()
        {
            MainPage mainPage = new MainPage();
            mainPage.ChooseCategoryFromMenu();

            ActionsPage actionsPage = new ActionsPage();
            actionsPage.SelectDiscountsTab();

            DiscountsPage discountsPage = new DiscountsPage();
            discountsPage.NavigateToMaxDiscount();
            Game expectedGame = discountsPage.GetGameFromDiscounts();

            AgePage2 agePage2 = new AgePage2();
            agePage2.SubmitView();

            AgePage agePage = new AgePage();
            agePage.FillAgeData(Configuration.GetYear());
                       
            GamePage gamePage = new GamePage();
            Game actualGame = gamePage.GetGame();

            Assert.AreEqual(expectedGame.Name, actualGame.Name, "Names are equal. The right game opened.");
            Assert.AreEqual(expectedGame.Discount, actualGame.Discount, "Discounts are equal.");
            Assert.AreEqual(expectedGame.Price, actualGame.Price, "Prices are equal.");

            gamePage.NavigateToDownloadPage();

            DownloadPage downloadPage = new DownloadPage();
            downloadPage.StartDownloadSteam();
            Assert.IsTrue(downloadPage.CheckFinishDownload(filePath), "SteamSetup.exe downloaded successfully");
        }

        [TestCleanup]
        public void TestClean()
        {
            Browser.CloseBrowser();
        }

    }
}
