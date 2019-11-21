using System;

namespace CopyMachine.States
{
    public class PrintFromWiFiState : WiFiDeviceState
    {
        public override void PrintSelectedDocument(ICopyMachine context)
        {
            if (context.Balance < context.CopyCost)
                throw new Exception("Insufficient funds on balance");
            context.Balance -= context.CopyCost;
            Console.WriteLine("Printing document from WiFi device...");
            Console.WriteLine(context.SelectedDocument);
        }
    }
}