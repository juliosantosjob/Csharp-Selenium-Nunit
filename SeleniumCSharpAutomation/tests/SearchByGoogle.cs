using MyTest.pages;
using MyTest.support;

namespace MyTest.Tests
{
    public class Tests : Hooks
    {
        [Test]
        [Description("Deve realizar uma busca no google")]
        public void SearchInGoogle()
        {
            SearchByGooglePages searchByGooglePages = new SearchByGooglePages();

            searchByGooglePages.FillSearch("Selenium C# NUnit");
            searchByGooglePages.Submit();
            searchByGooglePages.VerifySearch("Selenium");
        }
    }
}
