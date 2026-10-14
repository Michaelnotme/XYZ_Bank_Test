using OpenQA.Selenium;
using System.Threading;

namespace XYZ_Bank_Test.Pages
{
    public class ManagerPage
    {
        private IWebDriver driver;

        public ManagerPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickAddCustomerTab()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[contains(text(), 'Add Customer')]")).Click();
        }

        public void FillCustomerForm(string firstName, string lastName, string postCode)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@ng-model='fName']")).SendKeys(firstName);
            driver.FindElement(By.XPath("//input[@ng-model='lName']")).SendKeys(lastName);
            driver.FindElement(By.XPath("//input[@ng-model='postCd']")).SendKeys(postCode);
        }

        public void SubmitNewCustomer()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }
    }
}