namespace CopyMachine.States.ConsoleCopy
{
    public class USBPrintState : PrintState
    {
        public override void SelectDocument(CopyMachine context)
        {
            context.State = new USBDeviceState();
            context.State.SelectDocument(context);
        }
    }
}