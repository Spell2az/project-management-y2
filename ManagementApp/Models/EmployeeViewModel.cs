namespace ManagementApp.Models
{
  public class EmployeeViewModel
  {
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public bool Receive { get; set; }
    public bool Stow { get; set; }
    public bool Pick { get; set; }
    public bool Pack { get; set; }
    public bool Ship { get; set; }
  }
}