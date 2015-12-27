using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderForm
{
    class PizzaOrder
    {
            string name;
            string size;
            int quantity;

            public PizzaOrder()
            {

            }

            public PizzaOrder(string pizzaName, string pizzaSize, int quantity)
            {
                name = pizzaName;
                size = pizzaSize;
            }

            private double calculatePrice()
            {
                switch (size)
                {
                    case "small": return (9.9 * quantity);
                    case "large": return (15.9 * quantity);
                    default: return (25.9 * quantity);
                }
            }

            private string showOrder()
            {
                return ("Pizza : " + name + "\nSize: " + size + "\nAmount: " + quantity + "\n");
            }
    }
}
