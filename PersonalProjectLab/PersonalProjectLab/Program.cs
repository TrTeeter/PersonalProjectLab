using SortingEngine;
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


            string line = ("");
           
            string productreq;
           

            List<Tuple<string, int>> products = new List<Tuple<string, int>>();

            Console.WriteLine("WELCOME TO T.A.P.C.");
            Console.WriteLine("'Totally Awesome Price Comparitor'");
          
            //hard code an import list of items and prices
      

            if (File.Exists("importeddata.txt"))
            {
                
                using (StreamReader sr = File.OpenText("importeddata.txt"))
                {
                    
                  
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        products.Add(new Tuple<string, int>(values[0], int.Parse(values[1])));

                    }


                }

            }
            

            //create a class that runs through the document and adds each object into a bank to search from that sorts them by name, then price then lists the source
            //If the price is better than replace with the lowest price
            //ask the user for the name of the product they are looking for

            Console.WriteLine("What Can I help you find today?");
            productreq= Console.ReadLine();


            //create class that selects object and best price
            SearchEngine basic = new SearchEngine();
            basic.ImportList(products);
            basic.importuserinput(productreq);

            int calcavg = basic.average();
            int lowprice = basic.LowestPrice();

            Console.WriteLine("The lowest Price for a " + productreq + " is $" + lowprice);
            Console.WriteLine("The Average Price for a " + productreq + " is $" + calcavg);


            //Using looping, Display the lowest price by running through the classes and if the price is equal or lower replace it as the display product
            //While doing this loop is happing, create an average price index to display for information about the product.
            //If the product isn’t shown redirect to the name of the product
            // display the product, price, average price, and store
            //ask the user if they would like to repeat the process.
        }
    }
}