using RedHaven.Enums.SkillEnums;
using RedHaven.Enums.WeaponEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHaven.Models
{
    public abstract class WeaponModel
    {
        public string Name { get; set; }
        public SkillName WeaponSkill { get; set; }
        public string Damage { get; set; }
        public int ROF { get; set; }
        public bool FullHand { get; set; }
        public bool Stealthed { get; set; }
        public WeaponQuality WeaponQuality { get; set; }
        public bool IsExotic { get; set; }
        public int Price { get; set; }
    }
}
