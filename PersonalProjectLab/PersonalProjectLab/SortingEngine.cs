using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SortingEngine
{
    public class SearchEngine
    {
        List<Tuple<string, int>> _products;
        string _productreq = "";
        int lowestprice = 100000000;


        public ImportList(List<Tuple<string,int>> products)
        {

            products = _products;
        }

       public importuserinput(string productreq)
        {
            productreq = _productreq;
        }
        public int LowestPrice()
        {


            
            foreach (var productItem in _products)
            {
                if (productItem.Item1 == _productreq)
                {

                      if(productItem.Item2<lowestprice)
                    { lowestprice = productItem.Item2;
                    }
                      
                    
                }
            }
            return lowestprice;
            
        }
       public int average()
        {

            int sum = 0;
            int numberofproducts = 0;
            foreach (var productItem in _products)
            {
                if (productItem.Item1 == _productreq)
                {

                    sum += productItem.Item2;
                    numberofproducts++;
                }
            }
            int avg = sum / numberofproducts;
            return avg;
        }
    }
}
