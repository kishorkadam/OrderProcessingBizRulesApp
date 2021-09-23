using System;
using System.Collections.Generic;

namespace OrderProcessingConsoleApp
{
    public class Book : PhysicalProduct
    {
        public Book(string itemName)
        {
            ItemName = itemName;
            Activities = new List<string>();
            base.GetSlip();
            base.AddCommission();
            GetSlip();
        }
        public override void GetSlip()
        {
            Activities.Add("Create a duplicate packing slip for the royalty department.");
            Console.WriteLine("Create a duplicate packing slip for the royalty department.");
        }
    }
}