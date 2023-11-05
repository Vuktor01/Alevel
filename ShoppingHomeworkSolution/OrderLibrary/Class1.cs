using ShoppingCartLibrary;

namespace OrderLibrary
{
    public class OrderService
    {
        private int orderNumber = 1;

        public int PlaceOrder(ShoppingCart cart)
        {
            int generatedOrderNumber = orderNumber++;
            return generatedOrderNumber;
        }
    }
}