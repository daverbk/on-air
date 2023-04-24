using NUnit.Framework;

namespace OnAir.Tests;

public class Tests : TestBase
{
    private const string ItemToSearch = "Keychron K2";

    [Test]
    public void ItemSearch()
    {
        // Navigate to the Newegg website
        LandingPage.Open();

        // Type Keychron Q2 into the search bar + press enter
        LandingPage.SearchItem(ItemToSearch);

        // Check that the search results contain Keychron
        var isSearchResultsContainSearchedItemName = SearchResultsPage.IsAnyResultItemsContainTextInName(ItemToSearch);
        Assert.IsTrue(isSearchResultsContainSearchedItemName, "Some search items didn't contain the searched item name.");
    }

    // unfinished / in process 
    [Test]
    public void AddingItemToCart()
    {
        // Navigate to the Newegg website
        LandingPage.Open();

        // Type Keychrome K2 into the search bar + press enter
        LandingPage.SearchItem(ItemToSearch);

        // Click on the first item in the search results

        // Click on the Add to CartPage button

        // Refuse the warranty

        // Check that the item was added to the cart
    }
}