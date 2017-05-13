using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerBootsBN.Models
{
    public class ShoeModel
    {
        public string InsertProduct(BootProduct product)
        {
           try
            {
                db_1525596_co5027Entities db = new db_1525596_co5027Entities();
                db.BootProducts.Add(product);
                db.SaveChanges();

                return product.ShoeName + "Inserted Successfull";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        public string UpdateProduct(int id, BootProduct product)
        {
            try
            {
                db_1525596_co5027Entities db = new db_1525596_co5027Entities();
                //get the info from the db
                BootProduct p = db.BootProducts.Find(id);

                p.ShoeName = product.ShoeName;
                p.Price = product.Price;
                p.ShoeType = product.ShoeType;
                p.Description = product.Description;
                p.Image = product.Image;

                db.SaveChanges();
                return product.ShoeName + "Updated Successfull";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        public string DeleteProduct(int id)
        {
            try
            {
                db_1525596_co5027Entities db = new db_1525596_co5027Entities();
                BootProduct product = db.BootProducts.Find(id);

                db.BootProducts.Attach(product);
                db.BootProducts.Remove(product);
                db.SaveChanges();

                return product.ShoeName + "Deleted Successfull"; 

            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        public BootProduct GetProducts(int id)
        {
            try
            {
                using (db_1525596_co5027Entities db = new db_1525596_co5027Entities())
                {
                    BootProduct product = db.BootProducts.Find(id);
                    return product;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<BootProduct>RetrieveAllProduct()
        {
            try
            {
                using (db_1525596_co5027Entities db = new db_1525596_co5027Entities())
                {
                    List<BootProduct> product = (from x in db.BootProducts
                                                 select x).ToList();
                    return product;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<BootProduct>SortProductByType(int shoetype)
        {
            try
            {
                using (db_1525596_co5027Entities db = new db_1525596_co5027Entities())
                {
                    List<BootProduct> product = (from x in db.BootProducts
                                                 where x.ShoeType == shoetype
                                                 select x).ToList();
                    return product;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}