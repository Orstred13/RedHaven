using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHaven.Enums.WeaponEnums
{
    public enum RangeWeaponType
    {
        [Description("Средний пистолет")]
        MediumPistol,

        [Description("Тяжёлый пистолет")]
        HeavyPistol,

        [Description("Очень тяжёлый пистолет")]
        VeryHeavyPistol,

        [Description("Пистолет-пулемёт")]
        SubmachineGun,

        [Description("Тяжёлый ПП")]
        HeavySMG,

        [Description("Дробовик")]
        Shotgun,

        [Description("Штурмовая винтовка")]
        AssaultRifle,

        [Description("Снайперская винтовка")]
        SniperRifle,

        [Description("Луки и арбалеты")]
        BowsAndCrossbows,

        [Description("Гранатомёт")]
        GrenadeLauncher,

        [Description("Ракетомёт")]
        RocketLauncher
    }
}
