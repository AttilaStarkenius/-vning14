using Microsoft.AspNetCore.Identity;
using Övning14.Data;
using Övning14.Models;

namespace Övning14
{
    public class SeedData
    {
        private static ApplicationDbContext db = default!;
        private static RoleManager<IdentityRole> roleManager = default!;
        private static UserManager<ApplicationUser> userManager = default!;

        public static async Task InitAsync(ApplicationDbContext context, 
            IServiceProvider services, string adminPW)
        {
            if (string.IsNullOrWhiteSpace(adminPW))
            {
                throw new Exception("Can't get password from config");
            }
            if(context is null)
            {
                throw new NullReferenceException(nameof(ApplicationDbContext));
            }
            db = context;

            if (db.Users.Any())
            {
                return;
            }
            roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            if(roleManager is null)
            {
                throw new NullReferenceException(nameof(RoleManager<IdentityRole>));
            }
            
            userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            if(userManager is null)
            {
                throw new NullReferenceException(nameof(UserManager<ApplicationUser>));
            }
        }
    }
}
