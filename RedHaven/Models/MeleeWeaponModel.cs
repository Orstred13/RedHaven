using RedHaven.Enums.WeaponEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHaven.Models
{
    public class MeleeWeaponModel : WeaponModel
    {
        public MeleeWeaponType WeaponType { get; set; }
    }
}
