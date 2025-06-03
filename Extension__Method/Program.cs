namespace Extension__Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int presentage = 60;
            if (presentage.IsBetween(0, 50))
            {
                Console.WriteLine("Valid Input ");
            }
            else
            {
                Console.WriteLine("InValid Input Number");


            }


            Console.ReadKey();

        }
    }
}
