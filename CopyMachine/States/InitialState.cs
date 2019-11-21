using System;

namespace CopyMachine.States
{
    public class InitialState : StateBase
    {
        public override void SelectDevice(ICopyMachine context, Device device)
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

        public override void SelectDocument(ICopyMachine context, string name)
        {
            throw new Exception("Device not selected");
        }

        public override void PrintSelectedDocument(ICopyMachine context)
        {
            throw new Exception("Device and document not selected");
        }
    }
}