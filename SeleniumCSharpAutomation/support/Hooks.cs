namespace MyTest.support
{
    public class Hooks : BasePage
    {
        [SetUp]
        public void Setup()
        {
            SetDriver();
            TaskSetup.InitialSetup();
        }

        [TearDown]
        public void TearDown()
        {
            TaskSetup.EndSetup();
        }
    }
}
