namespace DomainClassLibrary.ApplicationsServices
{
  public class EmployeeInfo
  {
    public int Id { get; set; }
    public bool Receive { get; set; }
    public bool Stow { get; set; }
    public bool Pick { get; set; }
    public bool Pack { get; set; }
    public bool Ship { get; set; }

    public virtual User User { get; set; }
  }
}