using System;

namespace Module2HW2
{
    class ShoppingListServices
    {
        ShoppingList shoppingCart = new ShoppingList();
        public void Add(Product product)
        {
            Array.Resize(ref shoppingCart.ShoppingCart, shoppingCart.Counter + 1);
            shoppingCart.ShoppingCart[shoppingCart.Counter] = product;
            shoppingCart.Counter++;
        }
        public void Delite()
        {
            shoppingCart.ShoppingCart = new Product[0];
            shoppingCart.OrderPrice = 0;
        }
        public void Summ()
        {
            foreach (Product product in shoppingCart.ShoppingCart)
            {

                shoppingCart.OrderPrice += product.Price;
            }
        }
        public void Show()
        {
            foreach (Product product in shoppingCart.ShoppingCart)
            {
                Console.WriteLine($"{product.Id} {product.Name} {product.Price}");
            }
        }
        public void Order()
        {
            Summ();
            shoppingCart.ShoppingCartId = ++shoppingCart.ShoppingCartId;
            Console.WriteLine($"\nНомер заказа {shoppingCart.ShoppingCartId}\nКонечная цена {shoppingCart.OrderPrice}");
            Show();
            Delite();

        }
    }
}
