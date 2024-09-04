using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace MyTest.support
{
    public class BrowserInstance
    {
        public static IWebDriver GetInstances(string browser)
        {
            switch(browser.ToUpper())
            {
                case "CHROME":
                    return new ChromeDriver();
                case "FIREFOX":
                    return new FirefoxDriver();
                case "EDGE":
                    return new EdgeDriver();
                default:
                    throw new ArgumentException($"Browser {browser} not supported");
            }
        }
    }
}