using Rabe_Celina_HW6.DAL;
using System;
using System.Linq;


namespace Rabe_Celina_HW6.Utilities
{
    public static class GenerateNextSKU
    {
        public static Int32 GetNextSKU(AppDbContext db)
        {
            Int32 intMaxSKU; //the current maximum course number
            Int32 intNextSKU; //the course number for the next class

            if (db.Products.Count() == 0) //there are no registrations in the database yet
            {
                intMaxSKU = 5000; //registration numbers start at 101
            }
            else
            {
                intMaxSKU = db.Products.Max(c => c.SKU); //this is the highest number in the database right now
            }

            //add one to the current max to find the next one
            intNextSKU = intMaxSKU + 1;

            //return the value
            return intNextSKU;
        }

    }
}

