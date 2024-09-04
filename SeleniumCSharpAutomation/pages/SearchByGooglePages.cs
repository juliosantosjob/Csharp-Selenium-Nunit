using MyTest.support;
using OpenQA.Selenium;

namespace MyTest.pages
{
    internal class SearchByGooglePages : Hooks
    {
        By FLD_SEARCH = By.Name("q");

        public void FillSearch(string search)
        {
            FillIn(FLD_SEARCH, search);
        }

        public void Submit()
        {
            Find(FLD_SEARCH).Submit();
        }

        public void VerifySearch(string getSearch) 
        {
            Assert.IsTrue(GetDriver().PageSource.Contains(getSearch));
        }
    }
}
