using CoreStudies.Interfaces.Bridge;

namespace CoreStudies.Dominio.Bridge
{
    public class Switch
    {
        public IEletricalEquipment equipment { get; set; }

        public void On(){
            equipment.PowerOn();
        }

        public void Off(){
            equipment.PowerOff();
        }
    }
}