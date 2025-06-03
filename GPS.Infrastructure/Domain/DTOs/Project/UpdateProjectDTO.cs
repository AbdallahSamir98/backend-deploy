using Microsoft.AspNetCore.Http;

namespace GraduationProjectStore.Core.Feature.Projects
{
    public class UpdateProjectDTO
    {
        public int Id { set;get; }
        public string Description { set; get; }
        public IFormFile projectFile { set; get; }
        public DateTime UploadAt { set; get; }
        public int SupervisorId { set; get; }
        public int DepartmentId { set; get; }
        public string CollegeId { set; get; }
    }
}
