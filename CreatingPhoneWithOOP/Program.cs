using CreatingPhoneWithOOP.Models;
using System;

namespace CreatingPhoneWithOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Samsung");
            Smartphone samsung = new Samsung(number: "12123232", model: "AJXQ", iMEI: "12635175642", memory: 64);
            samsung.Call();
            samsung.InstallApplication("Whatsapp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone");
            Smartphone iphone = new Iphone(number: "1625312", model: "KVDP", iMEI: "1827364", memory: 256);
            iphone.ReceiveCall();
            iphone.InstallApplication("Telegram");

            Console.ReadKey();
        }
    }
}
