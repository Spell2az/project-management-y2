namespace ApplicationCore.Domain
{
    public class EmployeeInfo
    {
        public bool Receive { get; set; }
        public bool Stow { get; set; }
        public bool Pick { get; set; }
        public bool Pack { get; set; }
        public bool Ship { get; set; }
    }
}