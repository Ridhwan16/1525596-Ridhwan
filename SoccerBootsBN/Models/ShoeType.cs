using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs

namespace SoccerBootsBN.Models
{
    public class ShoeType
    {
        public string InsertProductType(BootType bootType)
        {
            try
            {
                db_1525596_co5027Entities db = new db_1525596_co5027Entities();
                db.BootTypes.Add(bootType);
                db.SaveChanges();

                return bootType.ShoeName + " Inserted Successfull";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        public string UpdateProductType(int id, BootType bootType)
        {
            try
            {
                db_1525596_co5027Entities db = new db_1525596_co5027Entities();
                //get the info from the db
                BootType p = db.BootTypes.Find(id);

                p.ShoeName = bootType.ShoeName;
                
                db.SaveChanges();
                return bootType.ShoeName + " Updated Successfull";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        public string DeleteProductType(int id)
        {
            try
            {
                db_1525596_co5027Entities db = new db_1525596_co5027Entities();
                BootType bootType = db.BootTypes.Find(id);

                db.BootTypes.Attach(bootType);
                db.BootTypes.Remove(bootType);
                db.SaveChanges();

                return bootType.ShoeName + " Deleted Successfull";

            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
    }
}