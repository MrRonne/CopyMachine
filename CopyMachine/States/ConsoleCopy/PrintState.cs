using System;

namespace CopyMachine.States.ConsoleCopy
{
    public abstract class PrintState : StateBase
    {
        public override void SelectDevice(CopyMachine context)
        {
            throw new Exception("Device already selected");
        }

        public override void PrintSelectedDocument(CopyMachine context)
        {
            if (context.SelectedDocument == null)
            {
                context.State = new ErrorState();
                context.State.PrintSelectedDocument(context);
            }
            if (context.Balance < context.CopyCost)
                throw new Exception("Insufficient funds on balance");
            context.Balance -= context.CopyCost;
            Console.WriteLine("Printing document...");
            Console.WriteLine(context.SelectedDocument);
            Console.WriteLine($"Current balance is {context.Balance}");
        }
    }
}