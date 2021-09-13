using NUnit.Framework;
using System;
using System.Linq;
using VismaTask1.PageObjects;
using VismaTask1.Utils;
using Actions = VismaTask1.Utils.Actions;

namespace VismaTask1.Tests
{
    public static class PageObjectExample
    {
        public static void TestTask1()
        {
            HomePage homePage = new HomePage();
            DatePickerPageMenu datePickerMenu = new DatePickerPageMenu();
            FormatDatePage formatDatePage = new FormatDatePage();

            // Point A. : Navigate to http://way2automation.com/way2auto_jquery/automation-practice-site.html 
            Actions.InitializeDriver(Config.URLs.BaseURL + Config.URLs.TestURL);

            // Point B. : Open the "Date picker" widget.
            homePage.WidgetDatepicker.Click();
            // make driver to use the new tab 
            Driver.driver.SwitchTo().Window(Driver.driver.WindowHandles.Last());

            // Point C. : Navigate to the "FORMAT DATE" section.
            datePickerMenu.MenuFormatDate.Click();
            // switch do the new frame
            Driver.driver.SwitchTo().Frame(formatDatePage.FormatDateIFrame);

            // Point D. : Select today's date.

            formatDatePage.DatePickerTextBox.Click();
            Actions.SelectTodayInDatePicker(Config.TodayDate.day);

            // Alternatively, we can also use a feature of the current DatePicker implementation that adds a class named ui-datepicker-today to current day
            // formatDatePage.TodayDateInDatePicker.Click();            

            // Point E. : Select the "ISO 8601" Format option.
            Actions.SelectDateFormatByText(Config.DateFormatText.ISO8601);

            // Point F. : Validate the shown date against the current date.
            Assert.AreEqual(formatDatePage.DatePickerTextBox.GetAttribute("value"), Config.TodayDate.ISO8601);

            Console.WriteLine("Test ended succesfull! The DatePicker selected date (" + formatDatePage.DatePickerTextBox.GetAttribute("value") + ") is equal to today (" + Config.TodayDate.ISO8601 + ")");
            Driver.driver.Quit();
        }
    }
}
