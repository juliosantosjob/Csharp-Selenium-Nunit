namespace MyTest.support
{
    internal class TaskSetup : BasePage
    {
        public static void InitialSetup()
        {
            GetDriver().Manage().Window.Maximize();
            GetDriver().Navigate().GoToUrl("https://www.google.com");
        }

        public static void EndSetup() 
        {
            GetDriver().Quit();
            GetDriver().Dispose();
        }
    }
}
