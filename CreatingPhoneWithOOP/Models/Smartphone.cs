using System;

namespace CreatingPhoneWithOOP.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        private string Model { get; set; }
        private string IMEI { get; set; }
        private int Memory { get; set; }

        public Smartphone(string number, string model, string iMEI, int memory)
        {
            Number = number;
            Model = model;
            IMEI = iMEI;
            Memory = memory;
        }

        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receiving call...");
        }

        public abstract void InstallApplication(string nameApp);
    }
}