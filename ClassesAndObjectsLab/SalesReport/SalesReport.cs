using System;
using System.Collections.Generic;

class SalesReport
{
    static void Main()
    {
        int salesCount = int.Parse(Console.ReadLine());

        List<Sale> sales = new List<Sale>();
         
        for (int i = 0; i < salesCount; i++)
        {
            string[] currentSale = Console.ReadLine().Split(' ');

            Sale sale = new Sale { Town = currentSale[0],
                Product = currentSale[1],
                Price = decimal.Parse(currentSale[2]),
                Quanity = decimal.Parse(currentSale[3])};
            sales.Add(sale);
        }
        SortedDictionary<string,decimal> result = new SortedDictionary<string, decimal>();
        foreach (var sale in sales)
        {
            if (!result.ContainsKey(sale.Town))
            {
                result[sale.Town] = 0;
            }
            result[sale.Town] += sale.Price * sale.Quanity;
        }
        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
        }
    }
}

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quanity { get; set; }
}