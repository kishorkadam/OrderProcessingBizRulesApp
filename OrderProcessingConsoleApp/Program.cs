using System;

namespace OrderProcessingConsoleApp
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Enum.GetValues(typeof(EnumProductType)))
            {
                Console.WriteLine($" {i} {Enum.GetName(typeof(EnumProductType), i)}");
            }

            Console.WriteLine("Enter Product number from the above list");

            var input = Console.ReadLine();
            var output = OrderProcessor.GetProductType(Convert.ToInt32(input));

            Console.WriteLine("Item Name : {0} Operations : {1}", output.ItemName, string.Join(' ', output.Activities));
            Console.ReadLine();
        }
    }

    public class OrderProcessor
    {
        public static Product GetProductType(int input)
        {
            EnumProductType type;
            Product product;
            string name = Enum.GetName(typeof(EnumProductType), input);

            try
            {
                type = (EnumProductType)Enum.Parse(typeof(EnumProductType), input.ToString(), ignoreCase: true);
            }
            catch (Exception e)
            {
                type = EnumProductType.Other;
            }

            switch (type)
            {
                case EnumProductType.Membership:
                    {
                        product = new Membership();
                        break;
                    }
                case EnumProductType.Upgrade:
                    {
                        product = new Upgrade();
                        break;
                    }
                case EnumProductType.Video:
                    {
                        product = new Video(name);
                        break;
                    }
                case EnumProductType.Book:
                    {
                        product = new Book(name);
                        break;
                    }
                case EnumProductType.Other:
                default:
                    {
                        product = new Other(name);
                        break;
                    }
            }
            return product;
        }
    }
}
