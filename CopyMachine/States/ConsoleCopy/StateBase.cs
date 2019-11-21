using System;

namespace CopyMachine.States.ConsoleCopy
{
    public abstract class StateBase : IState
    {
        public void EnterMoney(CopyMachine context)
        {
            Console.WriteLine("Enter money:");
            var amount = uint.Parse(Console.ReadLine());
            Console.WriteLine($"{amount} was deposited in the bill acceptor");
            context.Balance += amount;
            Console.WriteLine($"Current balance is {context.Balance}");
        }

        public abstract void SelectDevice(CopyMachine context);
        public abstract void SelectDocument(CopyMachine context);
        public abstract void PrintSelectedDocument(CopyMachine context);

        public void ReturnRemain(CopyMachine context)
        {
            Console.WriteLine("Returning remain...");
            Console.WriteLine(context.Balance);
            context.Balance = 0;
            context.SelectedDocument = null;
            context.State = new InitialState();
        }
    }
}