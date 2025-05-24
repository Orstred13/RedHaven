using RedHaven.Enums.CharacterEnums;
using RedHaven.Enums.SkillEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHaven.Models
{
    internal class SkillModel
    {
        public SkillName Name { get; set; }
        public string? Specialization { get; set; }
        public StatType Stat { get; set; }
        public int Level { get; set; }
        public bool IsDifficult { get; set; }
    }
}
