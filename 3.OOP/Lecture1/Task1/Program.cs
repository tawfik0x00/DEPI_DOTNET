using System;
using System.Data.Common;

namespace OOP_TASK
{
    class Product
    {
        // Our memebers
        int id;
        string name ;
        int qty;
        DateTime registeration;


        // Methods to make setters and getters
        public void Set_id(int Id)
        {
            id = Id;
        }
        public int Get_id()
        {
            return id;
        }

        // Getter and setter for name
        public void Set_name(string Name)
        {
            name = Name;
        }
        public string Get_name()
        {
            return name;
        }

        // getter and setter for the qty
        public void Set_qty(int Qty)
        {
            qty = Qty;
        }
        public int Get_qty( )
        {
            return qty;
        }

        // setter and getter for registeration
        public void Set_registerationDate(DateTime r)
        {
            registeration = r;
        }
        public DateTime Get_registerationDate()
        {
            return registeration;
        }

        // Properties
        public int Id
        {
            set
            {
                // Value is after equal sign 
                id = value;
            }

            get
            {
                return id;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Qty
        {
            set
            {
                qty = value;
            }

            get
            {
                return qty;
            }
        }

        public DateTime RegisterationData
        {
            set
            {
                registeration = value;
            }

            get
            {
                return registeration;
            }
        }
    }

    // Class using dynamic properties
    class Product_D
    {
        public int Id {set; get;}
        public string Name {set; get;}
        public int Qty{set; get;}
        public DateTime RegisterationDate{set; get;}

        // Consturctor overloading
       


        public void DisplayInfo()
        {
            System.Console.WriteLine($"{Id} : {Name} : {Qty} : {RegisterationDate}");
        }
    }


    class Program
    {
        public static void Main()
        {   
            // Using Dynamic Properites
            Product_D d1 = new Product_D();
            d1.RegisterationDate = DateTime.Now;
            d1.Name = "q1";
            d1.Id = 1;
            d1.Qty = 10;
            d1.DisplayInfo();

            // using normal methods
            Product d2 = new Product();
            d2.Set_name("q2");
            d2.Set_id(2);
            d2.Set_qty(10);
            d2.Set_registerationDate(DateTime.Now);

            Console.WriteLine($"{d2.Get_id()} : {d2.Get_name()} : {d2.Get_qty()} : {d2.Get_registerationDate()}");

            // using Normal Properties
            Product d3 = new Product();
            d3.Id = 3;
            d3.Name = "q3";
            d3.Qty = 10;
            d3.RegisterationData = DateTime.Now;

            Console.WriteLine($"{d3.Id} : {d3.Name} : {d3.Qty} : {d3.RegisterationData}");

        }
    }
}