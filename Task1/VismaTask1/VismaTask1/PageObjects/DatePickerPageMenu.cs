using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace VismaTask1.PageObjects
{
    public class DatePickerPageMenu
    {
        public DatePickerPageMenu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[text()='Default functionality']")]
        public IWebElement MenuDefaultFunctionality { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Animations']")]
        public IWebElement MenuAnimations { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Display month & year']")]
        public IWebElement MenuDisplayMonthAndYear { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Format date']")]
        public IWebElement MenuFormatDate { get; set; }
    }
}
