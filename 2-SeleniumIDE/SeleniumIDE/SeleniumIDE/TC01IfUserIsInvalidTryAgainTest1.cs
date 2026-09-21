using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class TC01IfUserIsInvalidTryAgainTest
{
    private IWebDriver driver = null!;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
    }

    [TearDown]
    protected void TearDown()
    {
        driver?.Quit();
    }

    [Test]
    public void TC01IfUserIsInvalidTryAgain()
    {
        const string expectedErrorMessage =
            "Epic sadface: Username and password do not match any user in this service";

        driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        driver.Manage().Window.Size =
            new System.Drawing.Size(1552, 832);

        IWebElement usernameInput =
            driver.FindElement(By.CssSelector("[data-test=\"username\"]"));

        IWebElement passwordInput =
            driver.FindElement(By.CssSelector("[data-test=\"password\"]"));

        usernameInput.SendKeys("user123");
        passwordInput.SendKeys("secret_sauce");

        driver.FindElement(
            By.CssSelector("[data-test=\"login-button\"]")
        ).Click();

        string actualErrorMessage = driver.FindElement(
            By.CssSelector("[data-test=\"error\"]")
        ).Text;

        Assert.That(
            actualErrorMessage,
            Is.EqualTo(expectedErrorMessage),
            "The expected invalid-login message was not displayed."
        );

        Console.WriteLine("Wrong username");

        usernameInput = driver.FindElement(
            By.CssSelector("[data-test=\"username\"]")
        );

        usernameInput.Clear();
        usernameInput.SendKeys("standard_user");

        driver.FindElement(
            By.CssSelector("[data-test=\"login-button\"]")
        ).Click();

        string pageTitle = driver.FindElement(
            By.CssSelector("[data-test=\"title\"]")
        ).Text;

        Assert.That(
            pageTitle,
            Is.EqualTo("Products"),
            "The user was not redirected to the Products page."
        );

        Console.WriteLine("Successful login");
    }
}