using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace VismaTask1.PageObjects
{
    public class FormatDatePage
    {
        public FormatDatePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='example-1-tab-4']/div/iframe")]
        public IWebElement FormatDateIFrame { get; set; }

        [FindsBy(How = How.Id, Using = "datepicker")]
        public IWebElement DatePickerTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'ui-datepicker-today')]")]
        public IWebElement TodayDateInDatePicker { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='format']")]
        public IWebElement FormatOptionsDropdown { get; set; }

        [FindsBy(How = How.ClassName, Using = "ui-datepicker-calendar")]
        public IWebElement DatePickerCalendar { get; set; }
    }
}
