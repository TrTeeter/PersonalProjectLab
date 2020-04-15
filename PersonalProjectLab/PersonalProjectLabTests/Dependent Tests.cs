using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingEngine;


namespace PersonalProjectLabTests
{
    [TestClass]
    public class PersonalProjectLabTests
    {
        
        [TestMethod]
        public void TestAvg()
        {
            List<Tuple<string, int>> products = new List<Tuple<string, int>>();
            string line = ("");
            string productreq = "testproduct1";


            using (StreamReader sr = File.OpenText("testtxt.txt"))
                {


                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        products.Add(new Tuple<string, int>(values[0], int.Parse(values[1])));

                    }


                }

            
            SearchEngine test = new SearchEngine();
            test.ImportList(products);
            test.importuserinput(productreq);

            int testavg = test.average();

            Assert.AreEqual(50, testavg);



        }
        [TestMethod]
        public void Testlowestprice()
        {
            List<Tuple<string, int>> products = new List<Tuple<string, int>>();
            string line = ("");
            string productreq = "testproduct1";


            using (StreamReader sr = File.OpenText("testtxt.txt"))
            {


                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    products.Add(new Tuple<string, int>(values[0], int.Parse(values[1])));

                }


            }


            SearchEngine test = new SearchEngine();
            test.ImportList(products);
            test.importuserinput(productreq);

            int testlow = test.LowestPrice();

            Assert.AreEqual(0, testlow);



        }
    }
}
