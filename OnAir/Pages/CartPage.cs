using OpenQA.Selenium;

namespace OnAir.Pages;

public class CartPage : PageBase
{
    private IEnumerable<IWebElement> AddedItems => Driver.FindElements(By.XPath("//*[@class = 'item-cell']"));

    public CartPage(IWebDriver driver, string url) : base(driver, url)
    { }
    
    public bool IsItemAddedToCart(string itemName) => 
        AddedItems.Select(element => element.Text.Contains(itemName)).Any(containsResult => containsResult);
}