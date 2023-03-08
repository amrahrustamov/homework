namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Brandin sayi : ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            decimal total = 0;
            while (count > 0)
            {
            string brandName = "";
                
                while (true)
                {
                Console.Write("Brandin adi : ");
                brandName = Console.ReadLine();
                    if (brandName.Length > 5 && brandName.Length < 15)
                    {
                        break;
                    }

                }



                Console.Write("Brandin qiymeti : ");
                decimal brandPrice = decimal.Parse(Console.ReadLine());
                Console.Write("Say : ");
                int brandCount = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                decimal totalBrandPrice = brandPrice * brandCount;
                total = total + totalBrandPrice;

                Console.WriteLine("Name of brand : " + brandName);
                Console.WriteLine("Price o brand : " + brandPrice + "(AZN)");
                Console.WriteLine("Count of brand : " + brandCount);
                Console.WriteLine("Total price : " + totalBrandPrice + "(AZN)");
                Console.WriteLine("######################################");

                count -= 1;
            }

            Console.Write("Yekun qiymet : ");
            Console.WriteLine(total);

            Console.ReadLine();

        }
    }
}