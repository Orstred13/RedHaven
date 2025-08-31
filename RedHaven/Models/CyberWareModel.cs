
namespace RedHaven.Models
{
    public abstract CyberWareModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Clinic { get; set; }
        public int HumanityLoss { get; set; }
    }
}

