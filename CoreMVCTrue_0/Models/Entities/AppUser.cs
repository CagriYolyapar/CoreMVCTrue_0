using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace CoreMVCTrue_0.Models.Entities
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properties
        public virtual UserProfile Profile { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
