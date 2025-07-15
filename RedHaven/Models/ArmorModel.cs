using RedHaven.Enums.ArmorEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHaven.Models
{
    public class ArmorModel
    {
        public ArmorLocation Location { get; set; }  // "Head" или "Body"
        public int MaxSP { get; set; }                  // Стойкость брони
        public int CurrentSP { get; set; }
        public int Penalty { get; set; }             // Штрафы к REF, DEX, MOVE

        public void GetHit(bool isArmorBreaker = false) {
            CurrentSP -= 1;
        }

        public void Repair() {
            CurrentSP = MaxSP;
        }
    }
}
