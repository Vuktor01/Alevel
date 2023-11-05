using ProductsLibrary;

namespace ShoppingCartLibrary
{
    public class ShoppingCart
    {
        private Product[] items = new Product[10];
        private int itemCount = 0;

        public void AddToCart(Product product)
        {
            if (itemCount < items.Length)
            {
                items[itemCount] = product;
                itemCount++;
            }
            else
            {
                Console.WriteLine("The cart is full. More items cannot be added.");
            }
        }

        public int GetItemCount()
        {
            return itemCount;
        }

        public void ClearCart()
        {
            items = new Product[10];
            itemCount = 0;
        }
    }
}