using System;

namespace CopyMachine.States
{
    public abstract class DeviceState : StateBase
    {
        public override void SelectDevice(ICopyMachine context, Device device)
        {
            throw new Exception("Device already selected");
        }

        public override void PrintSelectedDocument(ICopyMachine context)
        {
            throw new Exception("Document not selected");
        }
    }
}