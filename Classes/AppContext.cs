using System.Data.Entity;

namespace WpfEDSS.Classes
{
    internal class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Client> Clients { get; set; }
        /*
        public DbSet<QR_code> QR_Codes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Jobtitle> Jobtitles { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Role> Roles { get; set; }*/

        public AppContext(): base("DefaultConnection") { }

        
    }
}
