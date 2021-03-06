﻿using System;
using System.Device.Gpio;
using System.Threading;

namespace OpenPlantMonitorPi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int pin = 4;
            GpioController controller = new GpioController();
            controller.OpenPin(pin, PinMode.Output);

            while(true)
            {
                controller.Write(pin, PinValue.High);
                Thread.Sleep(1000);
                controller.Write(pin, PinValue.Low);
                Thread.Sleep(1000);
            }
        }
    }
}
