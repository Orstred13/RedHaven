using RedHaven.Enums.CharacterEnums;
using RedHaven.Enums.CyberwareEnums;

namespace RedHaven.Models
{
    public class CyberWareBorgModel : CyberWareModel
    {
        public CyberWareBorg NameCyberWareBorg { get; set; }                        // Название 
        public Dictionary<StatType, int> StatRequired { get; set; }                 // Необходимые для установки характерискики и их значение
        public Dictionary<StatType, int> StatChanged { get; set; }                  // Получаемые характерискики и их значение
        public Dictionary<CyberWareBasic, int> CyberWareBasicRequired { get; set; } // Необходимые для установки базовые импланты и их ко-во
        public Dictionary<CyberWareBorg, int> CyberWareBorgRequired { get; set; }   // Необходимые для установки боргирования  и их ко-во (опционально)
        public Dictionary<CyberWareEmbed, int> CyberWareEmbedRequired { get; set; } // Необходимые для установки встраиваемые импланты и их ко-во
       
        public int NumberSlots { get; set; }                                        // Добавляемое кол-во слотов для имплантов
        public List<CyberWareModel> CyberWareList { get; set; }                     // Установленные импланты и их кол-во
    }
}