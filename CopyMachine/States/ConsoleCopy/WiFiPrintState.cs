using System;

namespace CopyMachine.States.ConsoleCopy
{
    public class WiFiPrintState : PrintState
    {
        public override void SelectDocument(CopyMachine context, string name)
        {
            context.State = new WiFiDeviceState();
            context.State.SelectDocument(context, name);
        }
    }
}