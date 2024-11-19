using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class ApplicationRole : IdentityRole<int>
    {
        public string Description { get; set; } // A custom property for description of the role

        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime

    }
}
