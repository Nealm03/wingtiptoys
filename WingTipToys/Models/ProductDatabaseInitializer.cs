using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WingTipToys
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));

        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>{
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Cars"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Planes"
                },
                new Category 
                {
                    CategoryID = 3,
                    CategoryName = "Trucks"
                },
                 new Category 
                {
                    CategoryID = 4,
                    CategoryName = "Boats",
                },
                 new Category 
                {
                    CategoryID = 5,
                    CategoryName = "Rockets"
                },
            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                
                new Product
                {
                    ProductID= 1,
                    ProductName="Convertible car",
                    Description ="This is a short description of the related item",
                    unitPrice = 22.50,
                    imagePath ="carconvert.png",
                    categoryID =1
                },
                
                new Product
                {
                    ProductID= 2,
                    ProductName="old time car",
                    Description ="This is a short description of the related item",
                    unitPrice =15.95,
                    categoryID =1, 
                    imagePath="carearly.png"
                },
                new Product
                {
                    ProductID= 3,
                    ProductName="Fast car",
                    Description ="This is a short description of the related item",
                    unitPrice =32.95,
                    categoryID =1, 
                    imagePath="carfast.png"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Super Fast car",
                    Description ="This is a short description of the related item",
                    unitPrice = 8.95,
                    categoryID = 1, 
                    imagePath = "carfaster.png"
                },
                new Product
                {
                    ProductID= 5,
                    ProductName="Old race car",
                    Description ="This is a short description of the related item",
                    unitPrice =34.95,
                    categoryID =1, 
                    imagePath="carracer.png"
                },
                new Product
                {
                    ProductID= 6,
                    ProductName="Ace plane",
                    Description ="This is a short description of the related item",
                    unitPrice =95.00,
                    categoryID =2, 
                    imagePath="planeace.png"
                },
                new Product
                {
                    ProductID= 7,
                    ProductName="Glider",
                    Description ="This is a short description of the related item",
                    unitPrice =32.95,
                    categoryID =2, 
                    imagePath="planeglider.png"
                },
                new Product
                {
                    ProductID= 9,
                    ProductName="Paper plane",
                    Description ="This is a short description of the related item",
                    unitPrice =2.95,
                    categoryID =2, 
                    imagePath="planepaper.png"
                },
                new Product
                {
                    ProductID= 9,
                    ProductName="Propeller Plane",
                    Description ="This is a short description of the related item",
                    unitPrice =30.50,
                    categoryID =1, 
                    imagePath="carfast.png",
                },
                new Product
                {
                    ProductID= 10,
                    ProductName="Early truck",
                    Description ="This is a short description of the related item",
                    unitPrice =15.95,
                    categoryID =3, 
                    imagePath="truckearly.png",
                },
                new Product
                {
                    ProductID=11,
                    ProductName="Fire truck",
                    Description ="This is a short description of the related item",
                    unitPrice =26.00,
                    categoryID =3, 
                    imagePath="truckfire.png"
                },
                new Product
                {
                    ProductID= 12,
                    ProductName="Big Truck",
                    Description ="This is a short description of the related item",
                    unitPrice =29.00,
                    categoryID =3, 
                    imagePath="truckbig.png",
                },
                new Product
                {
                    ProductID= 13,
                    ProductName="Big Ship",
                    Description ="This is a short description of the related item",
                    unitPrice =95.00,
                    categoryID =1, 
                    imagePath="shipbig.png"
                },
                new Product
                {
                    ProductID= 14,
                    ProductName="Paper Boat",
                    Description ="This is a short description of the related item",
                    unitPrice =4.95,
                    categoryID =4, 
                    imagePath="boatpaper.png"
                },
                new Product
                {
                    ProductID= 15,
                    ProductName="Sail Boat",
                    Description ="This is a short description of the related item",
                    unitPrice =42.95,
                    categoryID =4, 
                    imagePath="boatsail.png"
                },
                new Product
                {
                    ProductID= 16,
                    ProductName="Rocket",
                    Description ="This is a short description of the related item",
                    unitPrice =122.95,
                    categoryID =5, 
                    imagePath="rocket.png"
                }
            };
            return products;
    }

    }
}


   
    
