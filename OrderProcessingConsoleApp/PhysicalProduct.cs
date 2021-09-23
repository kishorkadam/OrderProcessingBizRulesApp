using System;
using System.Collections.Generic;

namespace OrderProcessingConsoleApp
{
    public abstract class PhysicalProduct :Product
    {
         public override void GetSlip()
        {
            Activities.Add("Generated a packing slip for shipping.");
            Console.WriteLine("Generated a packing slip for shipping.");
        }
        
        public virtual void AddCommission()
        {
            Activities.Add("Commission payment to the agent");
            Console.WriteLine("Commission payment to the agent");
        }
    }
}