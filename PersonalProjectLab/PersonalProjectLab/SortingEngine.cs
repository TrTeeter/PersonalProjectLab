using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SortingEngine
{
    public class SearchEngine
    {
        List<Tuple<string, int>> _products;
        string _productreq;
        


        public void Importlist(List<Tuple<string,int>> products)
        {
            products = _products;
        }

        public void importuserinput(string productreq)
        {
            productreq = _productreq;
        }
        private List<Tuple<string, int>> SearchResults()
        {

            int sum = 0;
            int numberofproducts = 0;
            List<Tuple<string, int>> SearchResults;

            foreach (var productItem in _products)
            {
                if (productItem.Item1 == _productreq)
                {

                     SearchResults += productItem;
                    
                }
            }
            
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
