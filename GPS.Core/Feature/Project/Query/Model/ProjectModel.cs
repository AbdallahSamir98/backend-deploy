using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;

namespace GraduationProjectStore.Core.Feature.Projects.Query.Model
{
    public class ProjectModel
    {
        public int Project_Id { set; get; }
        public string Project_Description { set; get; }
        public string Project_ContentType { get; set; }
        public byte[] Project_Data { get; set; }
        public DateTime Project_UploadAt { set; get; }
        public int Project_SupervisorId { set; get; }
        public int Project_DepartmentId { set; get; }
    }
}
