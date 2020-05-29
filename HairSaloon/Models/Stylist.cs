using System.Collections.Generic;

namespace HairSaloon.Models
{
  public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }

        public int StylistId { get; set; }
        public string Skills { get; set; }
        public string StylistName { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}

