using System;
using System.Collections.Generic;

namespace OrderProcessingConsoleApp
{
    public class Upgrade : NonPhysicalProduct
    {
        public Upgrade()
        {
            Activities = new List<string>();
            base.GetSlip();
            Activities.Add("Apply the upgrade");
            Console.WriteLine("Apply the upgrade");
            base.DropMail();
        }
    }
}