namespace CopyMachine.States.ConsoleCopy
{
    public class WiFiPrintState : PrintState
    {
        public override void SelectDocument(CopyMachine context)
        {
            context.State = new WiFiDeviceState();
            context.State.SelectDocument(context);
        }
    }
}