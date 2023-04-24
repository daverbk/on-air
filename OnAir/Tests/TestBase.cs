using NUnit.Framework;
using OnAir.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnAir.Tests;

public abstract class TestBase
{
    protected IWebDriver Driver = null!;
    
    protected CartPage CartPage = null!;
    protected LandingPage LandingPage = null!;
    protected ProductPage ProductPage = null!;
    protected SearchResultsPage SearchResultsPage = null!;

    [SetUp]
    public void SetUp()
    {
        Driver = new ChromeDriver();
        Driver.Manage().Window.Maximize();
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        LandingPage = new LandingPage(Driver, "https://www.newegg.com/");
        SearchResultsPage = new SearchResultsPage(Driver);
        ProductPage = new ProductPage(Driver);
        CartPage = new CartPage(Driver, "https://secure.newegg.com/shop/cart");
    }

    [TearDown]
    public void CloseDriver() => Driver.Quit();
}