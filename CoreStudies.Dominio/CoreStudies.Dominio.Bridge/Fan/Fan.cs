using System;
using CoreStudies.Interfaces.Bridge;

namespace CoreStudies.Dominio.Bridge
{
    public class Fan : IEletricalEquipment
    {
        public void PowerOff()
        {
          Console.WriteLine("The Fan is Off!");
        }

        public void PowerOn()
        {
          Console.WriteLine("The Fan is On!");
        }
    }
}