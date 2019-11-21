namespace CopyMachine.States
{
    public interface IState
    {
        void EnterMoney(CopyMachine context);
        void SelectDevice(CopyMachine context);
        void SelectDocument(CopyMachine context);
        void PrintSelectedDocument(CopyMachine context);
        void ReturnRemain(CopyMachine context);
    }
}