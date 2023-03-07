//using Business.Concrete;
//using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
//using System;

//namespace ConsoleUI
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ProductTest();
//            //CategoryTest();

//        }

//        private static void CategoryTest()
//        {
//            TonerManager categoryManager = new TonerManager(new EfTonerDal());
//            foreach (var category in categoryManager.GetAll().Data)
//            {
//                Console.WriteLine(category.CategoryName);
//            }
//        }

//        private static void ProductTest()
//        {
//            PrinterManager productManager = new PrinterManager(new EfPrinterDal()
//                ,new TonerManager(new EfTonerDal()));

//            var result = productManager.GetProductDetails();
//            if (result.Success == true)
//            {
//                foreach (var product in result.Data)
//                {
//                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
//                } 
//            }

//            else
//            {
//                Console.WriteLine(result.Message);
//            }

//            }

            
        
//    }
//}
