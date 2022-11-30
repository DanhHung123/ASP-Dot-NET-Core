using System.ComponentModel.DataAnnotations;

namespace WorldcupWeb.Models
{
    public class WorldCup
    {
        public int Id { get; set; }
        public string Country1 { get; set; }
        public string Score { get; set; }
        public string Country2 { get; set; }
    }
}

