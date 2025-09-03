using RedHaven.Enums.CharacterEnums;
using RedHaven.Enums.CyberwareEnums;

namespace RedHaven.Models
{
    public class CyberWareBorgModel : CyberWareModel
    {
        public Guid Id { get; set; }
        public CyberWareBorg NameCyberWareBorg { get; set; }                                // Название 
        public Dictionary<StatType, int> StatRequired { get; set; }                         // Необходимые для установки статы и их значение
        public Dictionary<StatType, int> StatChanged { get; set; }                          // Получаемые статы и их значение
        public Dictionary<CyberWareBasic, int> CyberWareBasicRequired { get; set; }         // Необходимые для установки базовые импланты и их ко-во
        public Dictionary<CyberWareBorg, int> CyberWareBorgRequired { get; set; }           // Необходимые для установки боргирования  и их ко-во (опционально)
        public Dictionary<CyberWareEmbedded, int> CyberWareEmbeddedRequired { get; set; }   // Необходимые для установки встраиваемые импланты и их ко-во
        
        public int NumberSlotsBasic { get; set; }                                           // Добавляемое кол-во слотов для Базовых имплантов
        public List<CyberWareBasicModel> CyberWareBasicList { get; set; }                   // Установленные Базовые импланты
        public List<CyberWareEmbedded> CyberWareEmbedded { get; set; }                      // Лист разрешенных встраиваемых имплантов
        public int NumberSlotsEmbed { get; set; }                                           // Добавляемое кол-во слотов для Встраиваемых имплантов
        public List<CyberWareEmbeddedModel> CyberWareEmbeddedList { get; set; }             // Установленные Встраиваемые импланты
        
        public CyberWarePlace CyberWareInstallationPlace { get; set; }                      // Место установки

        //Проверка для установки
        public bool CheckingInstallation(Dictionary<StatType,int> characterStats, List<CyberWareBasicModel> basicList, List<CyberWareBorgModel> borgList) { 
            
            if (StatRequired != null) {
                foreach (var (stat, val) in StatRequired) {
                    if (characterStats[stat] != val) {
                        return false;
                    }
                }
            }

            if (basicList != null) {
                foreach (var (cyberWareBasic, val) in CyberWareBasicRequired) {
                    if (basicList.Where(cyberWare => cyberWare.NameCyberWareBasic == cyberWareBasic).Count() != val) {
                        return false;
                    }
                }
                
            }
            
            if (borgList != null) {
                foreach (var (cyberWareBorg, val) in CyberWareBorgRequired) {
                    if (borgList.Where(cyberWare => cyberWare.NameCyberWareBorg == cyberWareBorg).Count() != val) {
                        return false;
                    }
                }
                
            }

            if (CyberWareEmbeddedRequired != null) {
                foreach (var (cyberWareEmbedded, val) in CyberWareEmbeddedRequired) {
                    
                }
            }
            return true;
        }
        
        
        
        
    }
}