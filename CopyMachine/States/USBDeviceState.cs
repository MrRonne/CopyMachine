using System;

namespace CopyMachine.States
{
    public class USBDeviceState : DeviceState
    {
        public override void SelectDocument(ICopyMachine context, string name)
        {
            //TODO: File system operations
            //Example:
            var document = $"Title:\t{name}\nBody:\tdocument from USB device";
            var found = true;

            if (!found)
                throw new Exception($"Document {name} not found");
            context.SelectedDocument = document;
            Console.WriteLine($"Selected document {name}");
            context.State = new PrintFromUSBState();
        }
    }
}