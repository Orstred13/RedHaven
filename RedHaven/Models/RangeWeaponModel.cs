using RedHaven.Enums.SkillEnums;
using RedHaven.Enums.WeaponEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHaven.Models
{
    public class RangeWeaponModel : WeaponModel
    {
        public RangeWeaponType Type { get; set; }
        public int MaxAmmo { get; set; }
        public int CurrentAmmo { get; set; }
        public bool IsAutoFire { get; set; }
        public int? AutoFireBullet { get; set; }
        public bool FireToSuppress { get; set; }
    }
}
