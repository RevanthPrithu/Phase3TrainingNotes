using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreApp_GenerateIdentityDbApp
{
    public class MyIdentityDbContext:IdentityDbContext
    {
        public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options) : base(options)
        {

        }
    }
}