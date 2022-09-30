using System;

namespace Module2HW2
{
    class ProductListServices
    {
        ProductList productList = new ProductList();
        public void ShowProducts()
        {
            Console.WriteLine("Наш каталог:");
            foreach (Product i in productList.Products)
            {
                Console.WriteLine($"Id: {i.Id} Названия: {i.Name} Цена: {i.Price}");
            }
        }
        public Product[] GetAllProducts()
        {
            return productList.Products;
        }

        public Product GetOneProduct(int id)
        {
            foreach (Product product in GetAllProducts())
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return new Product();
        }
    }
}
