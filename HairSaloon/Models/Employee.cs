using System.Collections.Generic;

namespace HairSaloon.Models
{
  public class Employee
    {
        public Employee()
        {
            this.Clients = new HashSet<Client>();
        }

        public int EmployeeId { get; set; }
        public string Skills { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}


git commit -m "Client.cs Employee.cs HairSaloonContext.cs Program.cs Startup.cs appsettings.Json and styles.css files. Fully populated"