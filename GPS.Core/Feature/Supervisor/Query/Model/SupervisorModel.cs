using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProjectStore.Core.Feature.Supervisors.Query.Model
{
    public class SupervisorModel
    {
        public int Supervisor_Number { set; get; }
        public string Supervisor_FName { set; get; }
        public string Supervisor_LName { set; get; }
        public string Supervisor_Position { set; get; }
        public string Supervisor_Address { set; get; }
        public DateTime Supervisor_BirthDate { set; get; }
        public int Supervisor_DepartmentId { set; get; }
    }
}
