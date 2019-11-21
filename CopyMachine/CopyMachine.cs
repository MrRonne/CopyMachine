using CopyMachine.States;

namespace CopyMachine
{
    public class CopyMachine
    {
        public IState State { get; set; }
        public string SelectedDocument { get; set; }
        public uint CopyCost { get; }
        public uint Balance { get; set; }

        public CopyMachine(IState initialState, uint copyCost)
        {
            CopyCost = copyCost;
            Balance = 0;
            SelectedDocument = null;
            State = initialState;
        }

        public void EnterMoney() => State.EnterMoney(this);

        public void SelectDevice(Device device) => State.SelectDevice(this, device);

        public void SelectDocument(string name) => State.SelectDocument(this, name);

        public void PrintSelectedDocument() => State.PrintSelectedDocument(this);

        public void ReturnRemain() => State.ReturnRemain(this);
    }
}