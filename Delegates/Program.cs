namespace Delegates
{
    internal class Program
    {
        delegate int CalculateDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            #region Part One Explantion
            //int num1 = 20;
            //int num2 = 10;
            //CalculateWithDelegate(num1, num2, Add);
            //CalculateWithDelegate(num1, num2, Subtract);
            //CalculateWithDelegate(num1, num2, delegate (int num1, int num2) { return num1 * num2; });// More Easy then pass type of Operation 
            //CalculateWithDelegate(num1, num2, (x, y) => x / y);// Lampda Expression
            //// If You Create Function to do Spacial Operation Like '%' Delegate to Sovle That
            //CalculateWithDelegate(num1, num2, (x, y) => x % y);

            #endregion


            Console.ReadKey();  

        }
        static void CalculateWithDelegate(int num1, int num2, CalculateDelegate dlg)
        {
            int result = dlg(num1, num2);
            Console.WriteLine(result);

        }
        static int Add(int num1, int num2)
        {
            Console.WriteLine("Add From Function");
            return num1 + num2;
        }
        static int Subtract(int num1, int num2)
        {
            Console.WriteLine("Subtract From Function");
            return num1 - num2;
        }
        static int Multiply(int num1, int num2)
        {
            Console.WriteLine("Multiply");
            return num1 * num2;
        }
        static int Divide(int num1, int num2)
        {
            Console.WriteLine("Divide");
            return num1 / num2;
        }
    }
}
