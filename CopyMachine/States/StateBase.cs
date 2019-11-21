using System;

namespace CopyMachine.States
{
    public abstract class StateBase : IState
    {
        public void EnterMoney(ICopyMachine context, uint amount)
        {
            Console.WriteLine($"{amount} was deposited in the bill acceptor");
            context.Balance += amount;
            Console.WriteLine($"Current balance is {context.Balance}");
        }

        public abstract void SelectDevice(ICopyMachine context, Device device);
        public abstract void SelectDocument(ICopyMachine context, string name);
        public abstract void PrintSelectedDocument(ICopyMachine context);

        public uint GetRemain(ICopyMachine context)
        {
            var remain = context.Balance;
            context.Balance = 0;
            Console.WriteLine($"Returning remain {remain}");
            Console.WriteLine("Profit!");
            context.State = new InitialState();
            return remain;
        }
    }
}