using System;
using System.Collections.Generic;

namespace OrderProcessingConsoleApp
{
    public abstract class Product
    {
        public string ItemName { get; set; }
        public List<string> Activities { get; set; }
        public abstract void GetSlip();
    }
}