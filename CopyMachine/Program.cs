using System;

namespace CopyMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CorrectExample();
            Console.ReadKey();
        }

        static void CorrectExample()
        {
            var copyMachine = new ConsoleCopyMachine(5);
            copyMachine.EnterMoney(12);
            copyMachine.SelectDevice(Device.USB);
            copyMachine.SelectDocument("Example 1");
            copyMachine.PrintSelectedDocument();
            copyMachine.SelectDocument("Example 2");
            copyMachine.PrintSelectedDocument();
            copyMachine.GetRemain();
        }
    }
}