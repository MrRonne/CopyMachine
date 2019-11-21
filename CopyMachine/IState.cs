namespace CopyMachine
{
    public interface IState
    {
        void EnterMoney(ICopyMachine context, uint amount);
        void SelectDevice(ICopyMachine context, Device device);
        void SelectDocument(ICopyMachine context, string name);
        void PrintSelectedDocument(ICopyMachine context);
        uint GetRemain(ICopyMachine context);
    }
}