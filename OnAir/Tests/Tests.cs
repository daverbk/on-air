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

        // Type Keychron K2 into the search bar + press enter
        LandingPage.SearchItem(ItemToSearch);

        // Check that the search results contain Keychron K2
        var isSearchResultsContainSearchedItemName = SearchResultsPage.IsAnyResultItemsContainTextInName(ItemToSearch);
        Assert.IsTrue(isSearchResultsContainSearchedItemName, "Search didn't yield any results similar to the searched one.");
    }

    [Test]
    public void AddingItemToCart()
    {
        // Navigate to the Newegg website
        LandingPage.Open();

        // Type Keychrome K2 into the search bar + press enter
        LandingPage.SearchItem(ItemToSearch);

        // Click on the first item in the search results
        SearchResultsPage.ClickFirstItemInSearchResults(ItemToSearch);

        // Click on the Add to CartPage button
        ProductPage.ClickAddToCartButton();

        // Refuse the warranty
        ProductPage.RefuseWarranty();

        // Check that the item was added to the cart
        CartPage.Open();
        var isItemAddedToCart = CartPage.IsItemAddedToCart(ItemToSearch);
        Assert.IsTrue(isItemAddedToCart, $"The item {ItemToSearch} was not added to the cart.");
    }
}