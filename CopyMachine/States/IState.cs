namespace CopyMachine.States
{
    public interface IState
    {
        void EnterMoney(CopyMachine context);
        void SelectDevice(CopyMachine context, Device device);
        void SelectDocument(CopyMachine context, string name);
        void PrintSelectedDocument(CopyMachine context);
        void ReturnRemain(CopyMachine context);
    }
}