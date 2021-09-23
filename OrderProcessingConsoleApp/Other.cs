using System;
using System.Collections.Generic;

namespace OrderProcessingConsoleApp
{
    public class Other : PhysicalProduct
    {
        public Other(string name)
        {
            ItemName = name;
            Activities = new List<string>();
            base.GetSlip();
            base.AddCommission();
        }
    }
}