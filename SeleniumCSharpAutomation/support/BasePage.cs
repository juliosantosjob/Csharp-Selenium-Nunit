using OpenQA.Selenium;

namespace MyTest.support
{
    public class BasePage
    {
        protected static IWebDriver driver;

        public static void SetDriver()
        {
            driver = BrowserInstance.GetInstances("CHROME");
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public IWebElement Find(By element)
        {
            try
            {
                return GetDriver().FindElement(element);
            }
            catch(Exception ex)
            {
                throw new Exception($"Not could find the element using " +
                    $"these parameters: \"{element}\". WARNING:", ex);
            }

        }

        public void FillIn(By element, string text)
        {
            try
            {
                GetDriver().FindElement(element).SendKeys(text);
            }
            catch(Exception ex)
            {
                throw new Exception($"Not could fillin the {text} in element " +
                    $"{element}. WARNING:", ex);
            }
        }
    }
}
