using System;

namespace CopyMachine.States.ConsoleCopy
{
    public class USBPrintState : PrintState
    {
        public override void SelectDocument(CopyMachine context, string name)
        {
            context.State = new USBDeviceState();
            context.State.SelectDocument(context, name);
        }
    }
}