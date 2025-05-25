using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHaven.Models
{
    public class RoleAbilityModel
    {
        public string Name { get; set; }             // Название способности
        public int Rank { get; set; }                // Уровень способности
        public string Description { get; set; }
    }
}
