using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace VismaTask1.PageObjects
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[text()='Draggable']")]
        public IWebElement InteractionDraggable { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Droppable']")]
        public IWebElement InteractionDroppable { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Resizable']")]
        public IWebElement InteractionResizable { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Selectable']")]
        public IWebElement InteractionSelectable { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Sortable']")]
        public IWebElement InteractionSortable { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Accordion']")]
        public IWebElement WidgetAccordion { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Autocomplete']")]
        public IWebElement WidgetAutocomplete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Datepicker']")]
        public IWebElement WidgetDatepicker { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Menu']")]
        public IWebElement WidgetMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Slider']")]
        public IWebElement WidgetSlider { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Tabs']")]
        public IWebElement WidgetTabs { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Tooltip']")]
        public IWebElement WidgetTooltip { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Frames and Windows']")]
        public IWebElement FramesAndWindowsFrameAndWindows { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Submit Button Clicked']")]
        public IWebElement DynamicElementsSubmitButtonClicked { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Dropdown']")]
        public IWebElement DynamicElementsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Registration']")]
        public IWebElement RegistrationRegistration { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Alert']")]
        public IWebElement AlertAlert { get; set; }
    }
}
