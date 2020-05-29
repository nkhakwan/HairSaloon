namespace HairSaloon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}