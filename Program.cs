
using System;
using System.Collections;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            List<Product> list = new List<Product>(); //arratList 
            // list.Add(new Product(){ name = "Sugar", price = 2000, stock = 20});
            // list.Add(new Product(){ name = "Salt", price = 500, stock = 11});
            // list.Add(new Product(){ name = "Shoes", price = 2500, stock = 40});


            Console.WriteLine("Welcome To Jumia Online Store");
            while(true){
                try
                {
                    Console.WriteLine("Press\n1 to view product List.\n2 to add a new product\n3 to sell a product\n0 to Exist");
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n\n");

                    if(input == 0){
                         Console.WriteLine("Thanks for using our online store. Have a nice day");
                        break;

                    }else{
                        switch(input)
                        {
                            case 1:
                                Console.WriteLine("\n\n");
                                Console.WriteLine("List of Product. "+list.Count+" Items");
                                foreach(Product p in list){
                                    String disp = String.Format("Name: {0}, Price: {1}, Stock: {2}", p.name, p.price, p.stock);
                                    Console.WriteLine(disp);
                                }
                            break;


                            case 2:
                                Console.WriteLine("\n\n");

                                Product pdt = new Product();

                                Console.WriteLine("Enter Product Name:");
                                pdt.name = Console.ReadLine();

                                Console.WriteLine("Enter Product Price:");
                                pdt.price = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter Product Stock:");
                                pdt.stock = int.Parse(Console.ReadLine());

                                list.Add(pdt);
                            break;

                            case 3:
                                Console.WriteLine("\n\n");
                                Console.WriteLine("This will be implemented in our next class insha'allah");
                            break;


                            default:
                                Console.WriteLine("\n\n");
                                Console.WriteLine("Invalid Option, please try again");
                            break;
                        }
                    }
                }catch(Exception e){
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Error: "+ e.Message);
                }
            }

        }
    }
}