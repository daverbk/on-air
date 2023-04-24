using OpenQA.Selenium;

namespace OnAir.Pages;

public abstract class PageBase
{
    protected IWebDriver Driver;

    protected PageBase(IWebDriver driver)
    {
        Driver = driver;
    }
}