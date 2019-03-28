using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ManagementApp.DAL;
using AppContext = ManagementApp.DAL.AppContext;

namespace DomainClassLibrary.ApplicationsServices
{
  public class UserService
  {
    private readonly AppContext context;
    public UserService(AppContext context)
    {
      this.context = context;
    }

    public async Task<User> GetUser(string email)
    {
      var user = context.Users.FirstOrDefaultAsync(u => u.Email == email);
      return await user;
    }

    public async Task<User> GetUser(int id)
    {
      var user = await context.Users.FirstOrDefaultAsync(u => u.Id == id);
      return user;
    }

    public async Task<List<User>> GetEmployees()
    {
      return await context.Users.Where(u => u.Role == "Employee").ToListAsync();
    }

    public async Task UpdateEmployeeRecord(User employee)
    {
      context.Users.AddOrUpdate(employee);
      await context.SaveChangesAsync();
    }
   
    #region Login & Security

    public async Task<bool> CheckLogin(string email, string password)
    {
      bool credentialsValid = false;
      try
      {
        var user = await GetUser(email);
        if (user.HashedPassword == HashPassword(password))
        {
          credentialsValid = true;
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }

      return credentialsValid;
    }

    public static string HashPassword(string password)
    {
      if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
        throw new ArgumentException("password");

      string hashedPassword = "";

      using (SHA256 sha256 = SHA256.Create())
      {
        byte[] hashBytes = sha256.ComputeHash(Encoding.ASCII.GetBytes(password));
        hashedPassword = Convert.ToBase64String(hashBytes);
      }
      return hashedPassword;
    } 
    #endregion
  }
}