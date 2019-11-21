using System;

namespace CopyMachine.States.ConsoleCopy
{
    public class InitialState : StateBase
    {
        public override void SelectDevice(CopyMachine context)
        {
            Console.WriteLine("Enter input device (USB or WiFi):");
            if (!Enum.TryParse(Console.ReadLine(), true, out Device device))
                throw new Exception("Wrong device name");
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

        public override void SelectDocument(CopyMachine context)
        {
            throw new Exception("Device not selected");
        }

        public override void PrintSelectedDocument(CopyMachine context)
        {
            throw new Exception("Device and document not selected");
        }
    }
}