using System;

namespace CopyMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TwoDocumentsExample();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        static void TwoDocumentsExample()
        {
            var copyMachine = new CopyMachine(new States.ConsoleCopy.InitialState(), 5);
            copyMachine.EnterMoney();
            copyMachine.SelectDevice();
            copyMachine.SelectDocument();
            copyMachine.PrintSelectedDocument();
            copyMachine.SelectDocument();
            copyMachine.PrintSelectedDocument();
            copyMachine.ReturnRemain();
            Console.WriteLine("Profit!");
        }
    }
}