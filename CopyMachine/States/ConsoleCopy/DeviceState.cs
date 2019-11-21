using System;

namespace CopyMachine.States.ConsoleCopy
{
    public abstract class DeviceState : StateBase
    {
        public override void SelectDevice(CopyMachine context, Device device)
        {
            throw new Exception("Device already selected");
        }

        public override void PrintSelectedDocument(CopyMachine context)
        {
            throw new Exception("Document not selected");
        }
    }
}