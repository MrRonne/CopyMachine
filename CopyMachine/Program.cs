using System;

namespace CopyMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                USBTwoDocumentsExample();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        static void USBTwoDocumentsExample()
        {
            var copyMachine = new CopyMachine(new States.ConsoleCopy.InitialState(), 5);
            copyMachine.EnterMoney();
            copyMachine.SelectDevice(Device.USB);
            copyMachine.SelectDocument("Example 1");
            copyMachine.PrintSelectedDocument();
            copyMachine.SelectDocument("Example 2");
            copyMachine.PrintSelectedDocument();
            copyMachine.ReturnRemain();
            Console.WriteLine("Profit!");
        }
    }
}