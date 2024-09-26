using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GroupProject_Service
{
   
    public class WebService : IWebService
    {

        LinqDataContext dc = new LinqDataContext();

        public bool AddProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void AddToCart(int productId, int cartID)
        {
            throw new NotImplementedException();
        }

        public void AddToWishList(int productId, int wishListId)
        {
            throw new NotImplementedException();
        }

        public bool decreaseQuantity(int id)
        {
            throw new NotImplementedException();
        }

        public bool deleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public bool EditProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void GenerateInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }


        public Cart GetCart(int session)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetCartItems(int session)
        {
            throw new NotImplementedException();
        }
        public List<string> GetCategories()
        {
           
            List<string> categories = (from p in dc.Products select p.Category).Distinct().ToList();

            if (categories.Any()) 
            {
                return categories;
            }
            else
            {
                return new List<string>();
            }
        }



        public List<Invoice> GetInvoicesByUserID(int Id)
        {
              throw new NotImplementedException();
        }

        public Product GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductbyName(string prod_name)
        {
                throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            dynamic prodList = (from p in dc.Products select p).ToList();

            if (prodList != null)
            {
                List<Product> toReturn = new List<Product>();
                foreach (Product p in prodList)
                {
                    toReturn.Add(p);

                }
                return toReturn;
            }
            else
            {
                return null;
            }
        }


        public List<Product> GetProductsbyCategory(string category)
        {
            dynamic prodList = (from p in dc.Products where p.Category == category select p).DefaultIfEmpty().ToList();
            if (prodList != null)
            {
                return prodList;
            }
            else
            {
                return null;
            }
        }

        public List<Product> GetProductsOnSale()
        {
            dynamic prodList = (from p in dc.Products where p.onSale == true select p).DefaultIfEmpty().ToList();
            if (prodList != null)
            {
                return prodList;
            }
            else
            {
                return null;
            }
        }

        public List<Product> GetProductsOnSaleOnCategory(string category)
        {
            dynamic prodList = (from p in dc.Products where (p.onSale == true && p.Category == category) select p).DefaultIfEmpty().ToList();
            if (prodList != null)
            {
                return prodList;
            }
            else
            {
                return null;
            }
        }

        public List<Product> GetFeaturedProducts()
        {
            dynamic prodList = (from p in dc.Products where  p.isNew == true select p).DefaultIfEmpty().ToList();
            if (prodList != null)
            {
                return prodList;
            }
            else
            {
                return null;
            }
        }

        public List<Invoice> GetSortedInvoices(int userId, string orderBy)
        {
            throw new NotImplementedException();
        }

        public double GetTotalPrice()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetWishListItems(int wishlistId)
        {
            throw new NotImplementedException();
        }

        public bool increaseQuantity(int id)
        {
            throw new NotImplementedException();
        }


        public User Login(string loginType, string password)
        {
            throw new NotImplementedException();
        }

        public int PlaceOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public bool productExists(string name)
        {
            throw new NotImplementedException();
        }

        public bool Register(User user)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromCart(int session, int productId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFromCart(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFromWishlist(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCart(Cart cart)
        {
            throw new NotImplementedException();
        }

        public bool updateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool userExistence(string email)
        {
            throw new NotImplementedException();
        }
    }
}
