using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
namespace Taskonecloudqa
{
    public class Tests
    {
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            driver.Manage().Window.Maximize();
            IWebElement webElement = driver.FindElement(By.Name("First Name"));
            webElement.SendKeys("Ram");
            webElement.SendKeys(Keys.Return);
            IWebElement lastName = driver.FindElement(By.Name("Last Name"));
            lastName.SendKeys("Sharma");


            IWebElement genderMale = driver.FindElement(By.CssSelector("input[name='gender'][value='Male']"));
            genderMale.Click();

            IWebElement dobField = driver.FindElement(By.Name("Date of Birth"));
            dobField.SendKeys("2001-01-01");
            IWebElement usernameField = driver.FindElement(By.Name("Username"));
            usernameField.SendKeys("RamSharma123");
            IWebElement passwordField = driver.FindElement(By.Name("Password"));
            passwordField.SendKeys("RAmsharma@123");
            IWebElement confirmPasswordField = driver.FindElement(By.Name("Confirm Password"));
            confirmPasswordField.SendKeys("RAmsharma@123");
            IWebElement agreeCheckbox = driver.FindElement(By.Name("Agree"));
            if (!agreeCheckbox.Selected)
            {
                agreeCheckbox.Click();
            }


            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
        }

    }

}