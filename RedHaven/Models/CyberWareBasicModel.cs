using RedHaven.Enums.CharacterEnums;
using RedHaven.Enums.CyberwareEnums;

namespace RedHaven.Models
{
    public class CyberWareBasicModel : CyberWareModel
    {
        public CyberWareBasic NameCyberWareBasic { get; set; }       // Название 
        
        public int NumberSlotsEmbedded { get; set; }                                   // Добавляемое кол-во слотов для Встраиваемых имплантов
        public List<CyberWareEmbeddedModel> CyberWareEmbeddedList { get; set; }           // Установленные Встраиваемые импланты
        
        public CyberWarePlace CyberWareInstallationPlace { get; set; }              // Место установки
    }
}