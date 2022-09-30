using System;

namespace Module2HW2
{
    class Starter
    {
        public void Run()
        {
            ProductListServices productListService = new ProductListServices();
            ShoppingListServices order = new ShoppingListServices();
            ProductList productList = new ProductList();
            productListService.ShowProducts();
            Product getProduct = new Product();
            string Text = string.Empty;
            while (Text != "E")
            {
                Console.WriteLine("\nПредложенные команды:\nВведите букву S для того, что бы показать карзину\nБукву D для того, что бы очистить карзину\n" +
                    "Букву O для того, что бы сформировать заказ\nБукву E для того, что бы выйти из программы\nВведите Id товаров, которые вы хотите добавить в карзину:");
                Text = Console.ReadLine();
                bool isInt = int.TryParse(Text, out int userTextToInt);
                if (!isInt)
                {
                    switch (Text)
                    {
                        case "S":
                            order.Show();
                            break;
                        case "D":
                            order.Delite();
                            break;
                        case "O":
                            order.Order();
                            break;
                        default:
                            Console.WriteLine("Что-то пошло не так, проверте введенные данные и повторите попытку снова");
                            break;
                    }
                }
                else
                {
                    if (userTextToInt > productList.Products.Length)
                    {
                        Console.WriteLine("Нет продукта с таким Id");
                    }
                    else
                    {
                        getProduct = productListService.GetOneProduct(userTextToInt);
                        order.Add(getProduct);
                    }
                }
            }
        }
    }
}
