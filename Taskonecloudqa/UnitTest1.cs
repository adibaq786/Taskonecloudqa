using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace TestProject2
{
    public class Tests
    {
        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); 
        }

        [Test]
        public void TestFormFields()
        {
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            driver.Manage().Window.Maximize();

            IWebElement firstName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//label[text()='First Name']/following-sibling::input")));
            firstName.SendKeys("Ram");

           
            IWebElement lastName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//label[text()='Last Name']/following-sibling::input")));
            lastName.SendKeys("Sharma");

            IWebElement usernameField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='Username' and @name='Username' and @type='text']")));
            usernameField.SendKeys("RamSharma123");

            IWebElement passwordField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='password' and @placeholder='Password' and @name='Password']")));
            passwordField.SendKeys("StrongPassword123");

            
            IWebElement confirmPasswordField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='password' and @placeholder='Confirm Password' and @name='Confirm Password']")));
            confirmPasswordField.SendKeys("StrongPassword123");

            
            IWebElement genderMale = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[text()='Gender']/following-sibling::div//input[@value='Male']")));
            genderMale.Click();

            
            IWebElement dobField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("dob")));
            dobField.SendKeys("2002-01-01");

            
            IWebElement agreeCheckbox = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@type='checkbox' and @id='Agree' and @value='Agree' and @name='Agree']")));
            if (!agreeCheckbox.Selected)
            {
                agreeCheckbox.Click();
            }

            
            IWebElement submitButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@id='submit']")));
            submitButton.Click();
        }

        
    }
}

