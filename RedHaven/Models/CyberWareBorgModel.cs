using RedHaven.Enums.CyberwareEnums;

namespace RedHaven.Models
{
    public class CyberWareBorgModel : CyberWareModel
    {
        public BorgCyberWare NameBorgCyberWare { get; set; }
        public int NumberSlotsBasic { get; set; }
        
    }
}