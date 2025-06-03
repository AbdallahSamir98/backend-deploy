using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using Microsoft.AspNetCore.Identity;

namespace GraduationProjecrStore.Infrastructure.Domain.Entities.Security
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string Address { set; get; }
        public ICollection<Contact> ? Contacts { set; get; } = new List<Contact>();
    }
}
