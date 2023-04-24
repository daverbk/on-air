using OpenQA.Selenium;

namespace OnAir.Pages;

public class SearchResultsPage : PageBase
{
    private string SearchResultItemByNamePartXPath => "//*[contains(@id, 'item_cell')]//*[@class = 'item-info']//*[contains(text(), '{0}')]";

    private IEnumerable<IWebElement> SearchResultItems => Driver.FindElements(By.XPath("//*[contains(@id, 'item_cell')]"));

    public SearchResultsPage(IWebDriver driver) : base(driver)
    { }

    public bool IsAnyResultItemsContainTextInName(string textToContain) => 
        SearchResultItems.Select(element => element.Text.Contains(textToContain)).Any(containsResult => containsResult);

    public void ClickFirstItemInSearchResults(string itemToClickNamePart) => 
        Driver.FindElement(By.XPath(string.Format(SearchResultItemByNamePartXPath, itemToClickNamePart))).Click();
}