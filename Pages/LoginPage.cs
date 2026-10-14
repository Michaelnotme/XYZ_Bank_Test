using OpenQA.Selenium;
using System.Threading;

namespace XYZ_Bank_Test.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickManagerLogin()
        {
            Thread.Sleep(1000); 
            driver.FindElement(By.XPath("//button[contains(text(), 'Bank Manager Login')]")).Click();
        }
    }
}