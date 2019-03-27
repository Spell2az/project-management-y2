using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using DomainClassLibrary.ApplicationsServices;

namespace ManagementApp.DAL
{
  public class UserEntityConfiguration: EntityTypeConfiguration<User>
  {
    public UserEntityConfiguration()
    {
      ToTable("Users");

      HasKey<int>(u => u.Id);

      Property(u => u.Name)
        .HasColumnName("Name")
        .IsRequired()
        .HasMaxLength(120)
        .HasColumnType("varchar");

      

    }
  }
}