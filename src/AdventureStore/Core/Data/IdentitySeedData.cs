using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace AdventureSports.Core.Data
{

    public static class IdentitySeedData {
        private const string adminUser = "admin";
        private const string adminPassword = "password";

        public static async Task EnsurePopulated(UserManager<IdentityUser> userManager) {
            
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null) {
                user = new IdentityUser("admin");
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}