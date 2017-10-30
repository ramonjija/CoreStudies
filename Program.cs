using System;
using CoreStudies.Dominio.Bridge;
using CoreStudies.Interfaces.Bridge;

namespace CoreStudies
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch botao = new Switch();
            Fan ventilador = new Fan();
            Light luz = new Light();
            
            botao.equipment = ventilador;
            botao.On();
            botao.Off();
            Console.ReadKey();
            
            botao.equipment = luz;
            botao.On();
            botao.Off();
            Console.ReadKey();
        }
    }
}
