using System;
using System.Collections.Generic;

namespace OrderProcessingConsoleApp
{
    public class Membership : NonPhysicalProduct
    {
        public Membership()
        {
            Activities = new List<string>();
            base.GetSlip();
            Activities.Add("Activate that membership");
            Console.WriteLine("Activate that membership");
            base.DropMail();
        }
    }
}