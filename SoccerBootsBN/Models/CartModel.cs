using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

                return cart.DateBought + "Inserted Successfull";
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
                return cart.DateBought + "Updated Successfull";
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
    }
}