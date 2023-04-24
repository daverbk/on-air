using OpenQA.Selenium;

namespace OnAir.Pages;

public class LandingPage : PageBase
{
    private IWebElement SearchTextBox => Driver.FindElement(By.XPath("//input[@type = 'search']"));

    public LandingPage(IWebDriver driver, string url) : base(driver, url)
    { }

    public void SearchItem(string itemName)
    {
        SearchTextBox.SendKeys(itemName);
        SearchTextBox.SendKeys(Keys.Enter);
    }
}