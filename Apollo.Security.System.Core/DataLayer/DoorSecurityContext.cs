using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Apollo.Security.System.Core.Interface;
using Apollo.Security.System.Core.Model;

namespace Apollo.Security.System.Core.DataLayer
{
    public class DoorSecurityContext:DbContext, IDoorSecurityContext
    {
        public DbSet<Lock> Locks { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
