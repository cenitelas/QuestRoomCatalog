using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace QuestRoomCatalog.Models
{
    // Чтобы добавить данные профиля для пользователя, можно добавить дополнительные свойства в класс ApplicationUser. Дополнительные сведения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var hash = new PasswordHasher();
            var context = new ApplicationDbContext();
            if (!await context.Roles.AnyAsync(i => i.Name == "Admin"))
            {
                var adminRole = new IdentityRole() { Name = "Admin" };
                var userRole = new IdentityRole() { Name = "User" };
                var admin = new ApplicationUser() { Email = "Admin@text.ru", UserName = "Admin", PasswordHash = hash.HashPassword("Admin") };
                var user = new ApplicationUser() { Email = "User@text.ru", UserName = "User", PasswordHash = hash.HashPassword("User") };
                context.Users.Add(admin);
                context.Users.Add(user);
                context.Roles.Add(adminRole);
                context.Roles.Add(userRole);
                context.SaveChanges();
                var role1 = new IdentityUserRole() { RoleId = adminRole.Id, UserId = admin.Id };
                var role2 = new IdentityUserRole() { RoleId = userRole.Id, UserId = user.Id };
                adminRole.Users.Add(role1);
                userRole.Users.Add(role2);
                context.SaveChanges();

            }
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("Model1", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext CreateAsync()
        {         
            return new ApplicationDbContext();
        }
    }
}