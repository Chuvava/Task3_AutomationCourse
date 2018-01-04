using System;
using System.Collections.Generic;
using Framework.Elements;
using OpenQA.Selenium;
using SteamClasses.Pages;


namespace SteamClasses
{
    public class Tab : BasePage
    {
        private static Game expectedGame;

        public static void GetGameWithMaxDiscount(string namesX, string discountsX, string pricesX)
        {
            string namesXpath = namesX;
            string discountsXpath = discountsX;
            string pricesXpath = pricesX;
            Label lblName = new Label(By.XPath(namesXpath));
            Label lblDiscount = new Label(By.XPath(discountsXpath));
            Label lblPrice = new Label(By.XPath(pricesXpath));
            List<Label> names = lblName.FindElements(namesXpath);
            List<Label> discounts = lblDiscount.FindElements(discountsXpath);
            List<Label> prices = lblPrice.FindElements(pricesXpath);

            int indexOfMaxDiscount = GetIndexOfMaxDiscount(discounts);

            expectedGame = new Game(names[indexOfMaxDiscount].GetText(), discounts[indexOfMaxDiscount].GetText(),
                prices[indexOfMaxDiscount].GetText());

            discounts[indexOfMaxDiscount].Click();
        }

        public static int GetIndexOfMaxDiscount(List<Label> discounts)
        {
            int index = 0;
            char[] un = { '-', '%' };
            int maxDiscount = Int32.Parse(discounts[0].GetText().Trim(un));
            for (int i = 1; i < 10; i++)
            {
                if (Int32.Parse(discounts[i].GetText().Trim(un)) > maxDiscount)
                {
                    index = i;
                    maxDiscount = Int32.Parse(discounts[i].GetText().Trim(un));
                }
            }
            return index;
        }

        public static Game GetGame()
        {
            return expectedGame;
        }
    }
}
