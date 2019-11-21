using CopyMachine.States;

namespace CopyMachine
{
    public class ConsoleCopyMachine : ICopyMachine
    {
        public IState State { get; set; }
        public string SelectedDocument { get; set; }
        public uint CopyCost { get; }
        public uint Balance { get; set; }

        public ConsoleCopyMachine(uint copyCost)
        {
            CopyCost = copyCost;
            Balance = 0;
            SelectedDocument = null;
            State = new InitialState();
        }

        public void EnterMoney(uint amount) => State.EnterMoney(this, amount);

        public void SelectDevice(Device device) => State.SelectDevice(this, device);

        public void SelectDocument(string name) => State.SelectDocument(this, name);

        public void PrintSelectedDocument() => State.PrintSelectedDocument(this);

        public uint GetRemain() => State.GetRemain(this);
    }
}