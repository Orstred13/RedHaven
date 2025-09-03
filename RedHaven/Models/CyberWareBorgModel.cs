using RedHaven.Enums.CharacterEnums;
using RedHaven.Enums.CyberwareEnums;

namespace RedHaven.Models
{
    public class CyberWareBorgModel : CyberWareModel
    {
        public CyberWareBorg NameCyberWareBorg { get; set; }                        // Название 
        public Dictionary<StatType, int> StatRequired { get; set; }                 // Необходимые для установки статы и их значение
        public Dictionary<StatType, int> StatChanged { get; set; }                  // Получаемые статы и их значение
        public Dictionary<CyberWareBasic, int> CyberWareBasicRequired { get; set; } // Необходимые для установки базовые импланты и их ко-во
        public Dictionary<CyberWareBorg, int> CyberWareBorgRequired { get; set; }   // Необходимые для установки боргирования  и их ко-во (опционально)
        public Dictionary<CyberWareEmbed, int> CyberWareEmbedRequired { get; set; } // Необходимые для установки встраиваемые импланты и их ко-во
       
        public int NumberSlotsBasic { get; set; }                                   // Добавляемое кол-во слотов для Базовых имплантов
        public List<CyberWareBasicModel> CyberWareBasicList { get; set; }           // Установленные Базовые импланты
        public int NumberSlotsEmbed { get; set; }                                   // Добавляемое кол-во слотов для Встраиваемых имплантов
        public List<CyberWareEmbedModel> CyberWareEmbedList { get; set; }           // Установленные Встраиваемые импланты
        
        public CyberWarePlace CyberWareInstallationPlace { get; set; }              // Место установки
    }
}