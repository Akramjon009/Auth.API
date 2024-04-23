using Auth.MyModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Auth
{
    public class ApplicationIndentityDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationIndentityDbContext(DbContextOptions<ApplicationIndentityDbContext> options)
            :base(options)
        {
            
        }
    }
}
