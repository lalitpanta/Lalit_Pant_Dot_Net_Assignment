using Lalit_Pant_Dot_Net_Assignment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lalit_Pant_Dot_Net_Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object donors;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<BloodBank> BloodBanks { get; set; }
        public DbSet<DonationRequest> DonationRequests { get; set; }
        public DbSet<Lalit_Pant_Dot_Net_Assignment.Models.emergencyaccepter> emergencyaccepter { get; set; } = default!;
    }
}
