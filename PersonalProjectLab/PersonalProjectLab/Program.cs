using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {


            string line;
            SortedList<string,int> products = new SortedList<string,int>();

            Console.WriteLine("WELCOME TO T.A.P.C.");
            Console.WriteLine("'Totally Awesome Price Comparitor'");
            Console.ReadLine();
            //hard code an import list of items and prices
      

            if (File.Exists("datafile.txt"))
            {
                Console.WriteLine("test");
                using (StreamReader sr = File.OpenText("datafile.txt"))
                {
                    
                  
                    while ((line = sr.ReadLine()) != null)
                    {
                        // convert the
                        (line) = SortedList<string,int> name;
                        // add to list
                        products.Add(name);
                        
                    }


                }

            }
            Console.WriteLine(products);
        
        //create a class that runs through the document and adds each object into a bank to search from that sorts them by name, then price then lists the source
        //If the price is better than replace with the lowest price
        // ask the user for the name of the object/price/store they are searching for or the price or the store
        //Using looping, Display the lowest price by running through the classes and if the price is equal or lower replace it as the display product
        //While doing this loop is happing, create an average price index to display for information about the product.
        //If the product isn’t shown redirect to the name of the product
        // display the product, price, average price, and store
        //ask the user if they would like to repeat the process.
    }
    }
}