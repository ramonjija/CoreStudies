using System;
using CoreStudies.Interfaces.Bridge;

namespace CoreStudies.Dominio.Bridge
{
    public class Light : IEletricalEquipment
    {
        public void PowerOff()
        {
            Console.WriteLine("The Light is Off!");
        }

        public void PowerOn()
        {
            Console.WriteLine("The Light is On!");
        }
    }
}