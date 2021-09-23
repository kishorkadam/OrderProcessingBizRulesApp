using System;
using System.Collections.Generic;

namespace OrderProcessingConsoleApp
{
    public abstract class NonPhysicalProduct : Product
    {
        public override void GetSlip()
        {
            Activities.Add("Generated a packing slip.");
            Console.WriteLine("Generated a packing slip.");
        }
        public virtual void DropMail()
        {
            Activities.Add("Mail Sent");
            Console.WriteLine("Mail Sent");
        }

    }
}