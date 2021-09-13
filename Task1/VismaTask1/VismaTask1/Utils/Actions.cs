using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using VismaTask1.PageObjects;

namespace VismaTask1.Utils
{
    public static class Actions
    {
        public static void SelectDateFormatByValue(string valueToBeSelected)
        {
            FormatDatePage formatDatePage = new FormatDatePage();

            var selectElement = new SelectElement(formatDatePage.FormatOptionsDropdown);
            selectElement.SelectByValue(valueToBeSelected);
        }

        public static void SelectDateFormatByText(string textToBeSelected)
        {
            FormatDatePage formatDatePage = new FormatDatePage();

            var selectElement = new SelectElement(formatDatePage.FormatOptionsDropdown);
            selectElement.SelectByText(textToBeSelected);
        }
        public static void SelectTodayInDatePicker(string day)
        {
            FormatDatePage formatDatePage = new FormatDatePage();
            List<IWebElement> table = new List<IWebElement>(formatDatePage.DatePickerCalendar.FindElements(By.TagName("td")));
            foreach (IWebElement cell in table) // use foreach iterate each cell.
            {
                if (cell.Text.Equals(day))
                {
                    cell.Click();
                    break;
                }
            }
        }
        public static void InitializeDriver(string URL)
        {
            Driver.driver.Navigate().GoToUrl(URL);
        }
    }
}
