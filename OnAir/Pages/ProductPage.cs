using OpenQA.Selenium;

namespace OnAir.Pages;

public class ProductPage : PageBase
{
    private IWebElement AddToCartButton => Driver.FindElement(By.XPath("//*[@id = 'ProductBuy']//button[normalize-space(text()) = 'Add to cart']"));
    private IWebElement RefuseWarrantyButton => Driver.FindElement(By.XPath("//button[@data-dismiss]"));

    public ProductPage(IWebDriver driver) : base(driver)
    { }

    public void ClickAddToCartButton() => AddToCartButton.Click();

    public void RefuseWarranty() => RefuseWarrantyButton.Click();
}