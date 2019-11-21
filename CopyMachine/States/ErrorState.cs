using System;

namespace CopyMachine.States
{
    public class ErrorState : IState
    {
        public void EnterMoney(CopyMachine context)
        {
            throw new Exception("Some error");
        }

        public void SelectDevice(CopyMachine context)
        {
            throw new Exception("Some error");
        }

        public void SelectDocument(CopyMachine context)
        {
            throw new Exception("Some error");
        }

        public void PrintSelectedDocument(CopyMachine context)
        {
            throw new Exception("Some error");
        }

        public void ReturnRemain(CopyMachine context)
        {
            throw new Exception("Some error");
        }
    }
}