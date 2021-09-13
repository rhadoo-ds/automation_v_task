using System;

namespace VismaTask1
{
    public class Start
    {
        static void Main()
        {
            try
            {
                Tests.PageObjectExample.TestTask1();
            }
            catch (Exception)
            {
                Console.WriteLine("Test ended prematurely due to exception: ");
                Driver.driver.Quit();
                throw;
            }
        }
    }
}

