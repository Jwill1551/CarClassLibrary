using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
   public class Store
   {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }
      
        public Store()
        {
            //We must initilize each list or see the dreaded error: "Null Reference Exception Object reference not set to an instance of an object."
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal checkout()
        {
            decimal totalCost = 0;

            // Calculate the total cost of items in the cart.
            foreach (var c in ShoppingList)
            {
                totalCost += c.Price;
            }

            // Clear the shopping cart
            ShoppingList.Clear();

            // return the total 
            return totalCost;
        }


   }
}
