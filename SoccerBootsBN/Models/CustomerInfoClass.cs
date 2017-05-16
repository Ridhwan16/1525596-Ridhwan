using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs

namespace SoccerBootsBN.Models
{
    public class CustomerInfoClass
    {
        public CustomerInfo GetCustomerInformation(string guId)
        {
            db_1525596_co5027Entities db = new db_1525596_co5027Entities();
            CustomerInfo info = (from x in db.CustomerInfoes
                                 where x.GUID == guId
                                        select x).FirstOrDefault();
            return info;
        }

        public void InsertCustomerInformation(CustomerInfo info)
        {
            db_1525596_co5027Entities db = new db_1525596_co5027Entities();
            db.CustomerInfoes.Add(info);
            db.SaveChanges();
        }
    }
}