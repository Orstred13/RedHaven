using RedHaven.Enums.CharacterEnums;
using RedHaven.Enums.CyberwareEnums;
using RedHaven.Enums.SkillEnums;

namespace RedHaven.Models
{
    
    public class CyberWareEmbedModel : CyberWareModel
    {
        public CyberWareBorg NameCyberWareBorg { get; set; }                        // Название
        
        public Dictionary<CyberWareBasic, int> CyberWareBasicRequired { get; set; } // Необходимые для установки базовые импланты и их ко-во
        public int NumberSlotsRequired { get; set; }                                // Кол-во занимаемых слотов
        public Dictionary<StatType, int> StatChanged { get; set; }                  // Получаемые статы и их значение
        public Dictionary<SkillName, int> SkillChanged { get; set; }                // Получаемые скилы и их значение
        public string AdditionalOptions { get; set; }                               // Получаемые доп особенности
        public List<WeaponModel> AdditionalWeaponList  { get; set; }                // Лист встроенного оружия
        
    }
}