using System;

namespace CreatingPhoneWithOOP.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string iMEI, int memory) : base(number, model, iMEI, memory)
        {
        }

        public override void InstallApplication(string nameApp)
        {
            Console.WriteLine($"Installing the app {nameApp} on Iphone.");
        }
    }
}