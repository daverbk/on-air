using OpenQA.Selenium;

namespace OnAir.Pages;

public class LandingPage : PageBase
{
    private IWebElement SearchTextBox => Driver.FindElement(By.XPath("//input[@type = 'search']"));

    public LandingPage(IWebDriver driver) : base(driver)
    { }

    public void Open()
    {
        Driver.Navigate().GoToUrl("https://www.newegg.com/");
    }

    public void SearchItem(string itemName)
    {
        SearchTextBox.SendKeys(itemName);
        SearchTextBox.SendKeys(Keys.Enter);
    }
}