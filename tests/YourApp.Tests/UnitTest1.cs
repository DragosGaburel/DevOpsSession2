using Xunit;
using DevOpsSession2;

namespace YourApp.Tests;

public class UnitTest1
{
    [Fact]
    public void TestGetHighestSale()
    {
        //Arrange
        List<Sale> sales = new List<Sale>
        {
            new Sale { Id = 1, CustomerName = "Emma Nielsen", Product = "Laptop", Amount = 10000, Date = new DateTime(2026, 2, 1) },
            new Sale { Id = 2, CustomerName = "Lucas Hansen", Product = "Mouse", Amount = 249.00m, Date = new DateTime(2026, 2, 2) },
            new Sale { Id = 3, CustomerName = "Sofia Larsen", Product = "Office Chair", Amount = 1599.00m, Date = new DateTime(2026, 2, 3) },
            new Sale { Id = 4, CustomerName = "Noah Andersen", Product = "Monitor", Amount = 1899.00m, Date = new DateTime(2026, 2, 4) },
            new Sale { Id = 5, CustomerName = "Freja Christensen", Product = "Keyboard", Amount = 499.00m, Date = new DateTime(2026, 2, 5) }
        };
        var saleService = new SaleService();
        //Act
        var highestSale = saleService.GetHighestSale(sales);
        //Assert
        Assert.Equal(10000, highestSale.Amount);
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(5, 2 + 3);
    }
}
