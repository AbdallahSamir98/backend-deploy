using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProjecrStore.Infrastructure.Domain.DTOs.Supervisor
{
    public class CreateSupervisorDTO
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Position { set; get; }
        public string Address { set; get; }
        public int DepartmentId { set; get; }
        public DateTime BirthDate { set; get; }
    }
}
