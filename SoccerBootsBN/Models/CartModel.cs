using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs

namespace SoccerBootsBN.Models
{
    public class CartModel
    {
        public string InsertCart(BootCart cart)
        {
            try
            {
                db_1525596_co5027Entities db = new db_1525596_co5027Entities();
                db.BootCarts.Add(cart);
                db.SaveChanges();

                return cart.DateBought + " Inserted Successfull";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        public string UpdateCart(int id, BootCart cart)
        {
            try
            {
                db_1525596_co5027Entities db = new db_1525596_co5027Entities();
                //get the info from the db
                BootCart p = db.BootCarts.Find(id);

                p.DateBought = cart.DateBought;
                p.CustomerID = cart.CustomerID;
                p.Price = cart.Price;
                p.InsideCart = cart.InsideCart;
                p.ProductID = cart.ProductID;

                db.SaveChanges();
                return cart.DateBought + " Updated Successfull";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

       

        public string DeleteCart(int id)
        {
            try
            {
                db_1525596_co5027Entities db = new db_1525596_co5027Entities();
                BootCart cart = db.BootCarts.Find(id);

                db.BootCarts.Attach(cart);
                db.BootCarts.Remove(cart);
                db.SaveChanges();

                return cart.DateBought + "Deleted Successfull";

            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public List<BootCart> GetOrdersInCart(string userId)
        {
            db_1525596_co5027Entities db = new db_1525596_co5027Entities();
            List<BootCart> orders = (from x in db.BootCarts
                                     where x.CustomerID == userId
                                     && x.InsideCart
                                     orderby x.DateBought
                                     select x).ToList();
            return orders;
        }

        public int GetTotalOfOrders(string userId)
        {
            try
            {
                db_1525596_co5027Entities db = new db_1525596_co5027Entities();
                int amount = (from x in db.BootCarts
                              where x.CustomerID == userId
                              && x.InsideCart
                              select x.Price).Sum();
                return amount;
            }
            catch
            {
                return 0;
            }
        }

        public void UpdateQuantity(int id, int quantity)
        {
            db_1525596_co5027Entities db = new db_1525596_co5027Entities();
            BootCart cart = db.BootCarts.Find(id);
            cart.Price = quantity;

            db.SaveChanges();
        }

        public void MarkBootsAsPaid(List<BootCart> carts)
        {
            db_1525596_co5027Entities db = new db_1525596_co5027Entities();

            if (carts !=null)
            {
                foreach(BootCart cart in carts)
                {
                    BootCart PreviousCart = db.BootCarts.Find(cart.ID);
                    PreviousCart.DateBought = DateTime.Now;
                    PreviousCart.InsideCart = false;
                }
                db.SaveChanges();
            }
        }
    }
}