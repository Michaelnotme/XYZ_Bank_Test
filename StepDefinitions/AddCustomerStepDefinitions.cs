using XYZ_Bank_Test.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System.Threading;

namespace XYZ_Bank_Test.StepDefinitions
{
    [Binding]
    public class AddCustomerStepDefinitions
    {
        private IWebDriver driver = new ChromeDriver();
        private LoginPage loginPage;
        private ManagerPage managerPage;

        [Given("I navigate to the banking website")]
        public void GivenINavigateToTheBankingWebsite()
        {
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
            loginPage = new LoginPage(driver);
            managerPage = new ManagerPage(driver);
        }

        [When("I click on the Bank Manager Login button")]
        public void WhenIClickOnTheBankManagerLoginButton()
        {
            loginPage.ClickManagerLogin();
        }

        [When("I click on the Add Customer tab")]
        public void WhenIClickOnTheAddCustomerTab()
        {
            managerPage.ClickAddCustomerTab();
        }

        [When("I enter First Name \"(.*)\", Last Name \"(.*)\", and Post Code \"(.*)\"")]
        public void WhenIEnterFirstNameLastNameAndPostCode(string firstName, string lastName, string postCode)
        {
            managerPage.FillCustomerForm(firstName, lastName, postCode);
        }

        [When("I click the Add Customer submit button")]
        public void WhenIClickTheAddCustomerSubmitButton()
        {
            managerPage.SubmitNewCustomer();
        }

        [Then("I should see a success alert and accept it")]
        public void ThenIShouldSeeASuccessAlertAndAcceptIt()
        {
            Thread.Sleep(1000);

            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            Assert.That(alertText, Does.Contain("Customer added successfully"));
            alert.Accept();
        }

        [AfterScenario]
        public void CleanupWebDriver()
        {
            //driver?.Quit();
        }
    }
}