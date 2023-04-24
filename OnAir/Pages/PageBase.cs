using OpenQA.Selenium;

namespace OnAir.Pages;

public abstract class PageBase
{
    private string? _url;
    protected IWebDriver Driver;

    protected PageBase(IWebDriver driver, string? url = null)
    {
        Driver = driver;
        _url = url;
    }

    public void Open() => Driver.Navigate().GoToUrl(_url);
}