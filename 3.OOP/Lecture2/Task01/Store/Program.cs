/*
    Task 01

    A small store wants to manage basic information about its products using a Array 
    Create a struct for Product contains Id,Name,Price,Qty
    In the Main method:
    Create an array of Product with a fixed size of 5.
    Fill the array with data entered by the user.
    Display all products in a readable format.
*/
using System;

namespace Store
{
    // Create a data type for saving information about a procut using struct
    struct Product
    {
        public int Id {set; get;}
        public string Name {set; get;}
        public int Price {set; get;}
        public int Qty{set; get;}

        // set some Construcotrs for this struct
        Product (int _id)
        {
            // Initialize all members for the struct
            Id = _id;
            Name = "Default Name";
            Price = 0;
            Qty = 0;
        }

        Product (int _id, string _name)
        {
            Id = _id;
            Name = _name;
            Price  = 0;
            Qty = 0;
        }

        Product (int _id, string _name, int _price)
        {
            Id = _id;
            Name = _name;
            Price = _price;
            Qty = 0;
        }

        Product (int _id, string _name, int _price, int _qty)
        {
            Id = _id;
            Name = _name;
            Price = _price;
            Qty = _qty;
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine($"Id: {Id} Name: {Name}    Price :{Price}  Quantity:{Qty}");
        }
    }
    class Program
    {
        public static void Main()
        {
            const int size = 5;
            Product[] products = new Product[5];

            System.Console.WriteLine("\nWelcome to Product Record Panel!\n");

            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine($"Enter Data for product {i + 1}.");

                // Read Id
                System.Console.Write($"Id: ");
                products[i].Id = int.Parse(Console.ReadLine());

                System.Console.Write($"Name: ");
                products[i].Name = Console.ReadLine();

                System.Console.Write($"Price: ");
                products[i].Price = int.Parse(Console.ReadLine());

                System.Console.Write($"Quantity: ");
                products[i].Qty = int.Parse(Console.ReadLine());

                // take a new line
                Console.WriteLine();

            }


            foreach(Product p in products)
            {
                p.DisplayInfo();
            }


        }
    }
}