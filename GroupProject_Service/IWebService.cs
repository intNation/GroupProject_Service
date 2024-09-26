using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GroupProject_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWebService" in both code and config file together.
    [ServiceContract]
    public interface IWebService
    {

        [OperationContract]
        bool Register(User user);

        [OperationContract]
        User Login(string logype, string password);

        [OperationContract]
        bool userExistence(string email);

        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        List<Product> GetProductsOnSale();

        [OperationContract]
        List<Product> GetProductsOnSaleOnCategory(string category);

        [OperationContract]
        List<Product> GetFeaturedProducts();


        [OperationContract]
        Product GetProductByID(int id);

        [OperationContract]
        List<Product> GetProductsbyCategory(string category);

        [OperationContract]
        List<string> GetCategories();

        [OperationContract]
        Product GetProductbyName(string prod_name);

        [OperationContract]
        void AddToWishList(int productId,int wishListId);

        [OperationContract]
        void AddToCart(int productId, int cartID);

        [OperationContract]
        List<Product> GetWishListItems(int wishlistId);

        [OperationContract]
        Cart GetCart(int session);

        [OperationContract]
        List<Product> GetCartItems(int cartId);
        //
        [OperationContract]
        bool increaseQuantity(int id);
        //
        [OperationContract]
        bool decreaseQuantity(int id);
        //                          
        [OperationContract]
        bool RemoveFromWishlist(int id);
        //
        [OperationContract]
        bool RemoveFromCart(int id);
        //
        [OperationContract]
        bool AddProduct(int productId);
       
        [OperationContract]
        bool EditProduct(int productId);

        [OperationContract]
        bool DeleteProduct(int productId);

        [OperationContract]
        double GetTotalPrice();

        [OperationContract]
        int PlaceOrder(Order order);

        [OperationContract]
        void GenerateInvoice(Invoice invoice);

        [OperationContract]
        List<Invoice> GetSortedInvoices(int userId, string orderBy);

        


        /*  [OperationContract]
          User Login(string loginType, string password);

          [OperationContract]
          bool Register(User user);

          [OperationContract]
          List<Product> GetProducts();

          [OperationContract]
          List<Product> GetProductsOnSale();

          [OperationContract]
          bool productExists(string name);

          [OperationContract]
          void addProduct(Product product);

          [OperationContract]
          bool deleteProduct(Product product);

          [OperationContract]
          bool updateProduct(Product product);

          [OperationContract]
          List<Product> GetProductsbyCategory(string category);
          [OperationContract]
          List<string> GetCategories();

          [OperationContract]
          Product GetProductbyName(string prod_name);

          [OperationContract]
          void InsertToCart(int session, int productId, int qty);

          [OperationContract]
          List<Product> GetCartItems(int session);

          [OperationContract]
          void RemoveFromCart(int session, int productId);

          [OperationContract]
          Cart GetCart(int session);

          [OperationContract]
          void UpdateCart(Cart cart);

          [OperationContract]
          int PlaceOrder(Order order);

          [OperationContract]
          void GenerateInvoice(Invoice invoice);

          [OperationContract]
          List<Invoice> GetInvoicesByUserID(int Id);

          [OperationContract]
          List<Invoice> GetSortedInvoices(int userId, string orderBy);*/
    }
}
