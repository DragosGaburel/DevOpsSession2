namespace DevOpsSession2;

public class SaleService
{
    public Sale? GetHighestSale(List<Sale> sales)
    {
        return sales.MaxBy(s => s.Amount);
    }
}