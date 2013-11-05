using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPTTest.Models;


namespace WebAPTTest.Services
{
    public class ARservice
    {
       
        public ARDATA[] GetAllContacts()
        {

            ARDATA[] ar = new ARDATA[] { };

            var cx = new ARDBEntities2();
   
             ar = cx.ARDATAs.Select(x => x).ToArray();

            return ar;

        }
        public ARDATA[] GetContacts(double rlog,double rlat,double raz)
        {

            ARDATA[] ar = new ARDATA[] { };

            var cx = new ARDBEntities2();

            ar = cx.ARDATAs.Where(x => (x.Longitute==rlog && x.Latitude==rlat && x.Azimuth==raz)).Select(x => x).ToArray();
            
            //var query = cx.ARDATAs.Where(u => u.Longitute == rlog ).First();
            
            
            return ar;



        }

    }
}