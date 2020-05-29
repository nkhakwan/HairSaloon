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
        public virtual ICollection<Client> Clients { get; set; }
    }
}


git commit -m "Client.cs Employee.cs HairSaloonContext.cs Program.cs Startup.cs appsettings.Json and styles.css files. Fully populated"