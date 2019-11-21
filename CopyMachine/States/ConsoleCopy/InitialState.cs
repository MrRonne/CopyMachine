using System;

namespace CopyMachine.States.ConsoleCopy
{
    public class InitialState : StateBase
    {
        public override void SelectDevice(CopyMachine context, Device device)
        {
            switch (device)
            {
                case Device.USB:
                    context.State = new USBDeviceState();
                    break;
                case Device.WiFi:
                    context.State = new WiFiDeviceState();
                    break;
                default:
                    throw new Exception($"Selected unknown device {device}");
            }
            Console.WriteLine($"Selected device {device}");
        }

        public override void SelectDocument(CopyMachine context, string name)
        {
            throw new Exception("Device not selected");
        }

        public override void PrintSelectedDocument(CopyMachine context)
        {
            throw new Exception("Device and document not selected");
        }
    }
}