using System;
using System.Collections.Generic;

namespace OrderProcessingConsoleApp
{
    public  class Video : NonPhysicalProduct
    {
        public Video(string videoName)
        {
            Activities = new List<string>();
            ItemName = videoName;

            GetSlip();
        }
        public override void GetSlip()
        {
            base.GetSlip();
            if (ItemName.ToLower().Equals("learning to ski"))
            {
                Activities.Add("'First Aid' video added to the packing slip as result of court decision in 1997.");
                Console.WriteLine("'First Aid' video added to the packing slip");
            }
        }
    }
}