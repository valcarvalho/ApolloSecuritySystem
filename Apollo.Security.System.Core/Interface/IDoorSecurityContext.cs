using System.Data.Entity;
using Apollo.Security.System.Core.Model;

namespace Apollo.Security.System.Core.Interface
{
    public interface IDoorSecurityContext
    {
        DbSet<Lock> Locks { get; set; }
        DbSet<Member> Members { get; set; }
        int SaveChanges();
    }
}