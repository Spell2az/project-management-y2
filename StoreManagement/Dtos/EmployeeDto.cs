namespace StoreManagement.Dtos
{
    public class EmployeeDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public bool Receive { get; set; }
        public bool Stow { get; set; }
        public bool Pick { get; set; }
        public bool Pack { get; set; }
        public bool Ship { get; set; }
    }
}