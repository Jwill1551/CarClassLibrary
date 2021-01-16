using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program
    {
        static Store CarStore = new Store();

        static void Main(string[] args)
        {
            Console.Out.WriteLine("Welcome to the car store. First you must create some cars and put them " +
                "into the store inventory. Then you may add cars to the cart. Finally, you may checkout, which " +
                "will calculate your total bill.");

            int choice = userChoice();
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        // You chose add a car 
                        Console.WriteLine("You chose to add a new car to the store: ");

                        // Ask for three property details 
                        string carMaker;
                        string carModel;
                        decimal carPrice;

                        Console.Out.Write("What is the car maker? Ford, Tesla, Toyota, Hyundai, or etc. ");
                        carMaker = Console.ReadLine();

                        Console.Out.Write("What is the car model? Corvett, Model X, Camry, Sonata, or etc. ");
                        carModel = Console.ReadLine();

                        Console.Out.Write("What is the car price? Only numbers please. ");
                        carPrice = int.Parse(Console.ReadLine());

                        // Create a new car onject and add it to the list 
                        Car newCar = new Car();
                        newCar.Maker = carMaker;
                        newCar.Model = carModel;
                        newCar.Price = carPrice;
                        CarStore.CarList.Add(newCar);
                        displayInventory(CarStore);
                        break;

                    case 2:
                        // You chose buy a car

                        // Display the list of cars in inventory
                        displayInventory(CarStore);

                        // Ask for a car number to purchase 
                        int choice = 0;
                        Console.Out.Write("Which car would you like to add to the cart? (number) ");
                        choice = int.Parse(Console.ReadLine());

                        // Add the car to the shopping cart
                        CarStore.ShoppingList.Add(CarStore.CarList[choice]);

                        displayInventory(CarStore);

                        break;
                }
            }
        }

        static public int userChoice;
        static public void displayInventory(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in the store inventory: ");
            int i = 0;
            foreach (var c in carStore.CarList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1} ", i, c.Display));
            }
        }
    }
}
