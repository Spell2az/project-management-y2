namespace DomainClassLibrary.ApplicationsServices
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string  Name { get; set; }
        public string Role { get; set; }
        public string HashedPassword { get; set; }

        public virtual EmployeeInfo EmployeeInfo { get; set; }
    }
}