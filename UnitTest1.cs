using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Taskmaster
{
    public class Tests
    {
        IWebDriver webDriver;

        [OneTimeSetUp]
        public void StartChrome()
        {
            webDriver = new ChromeDriver(".");


        }

        [Test]
        public void Test1()
        {
            webDriver.Url = @"C:\Users\Andrew1977\Downloads\index.html";
            //IWebElement txtFullName = webDriver.FindElement(By.Id("txtFullName"));
            IWebElement txtFullName = webDriver.FindElement(By.Name("Full Name"));
            //IWebElement txtFullName = webDriver.FindElement(By.ClassName("fullName"));
            
            txtFullName.SendKeys("Steve Rogers");
            Assert.Pass();
        }

        [OneTimeTearDown]
        public void CloseTest()
        {
           webDriver.Close();
        }
    }
}